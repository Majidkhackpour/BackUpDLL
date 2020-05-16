using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using PacketParser;
using PacketParser.Services;

namespace BackUpDLL
{
    public class DatabaseAction
    {
        public static void SetMultiUser(string connectionString)
        {
            try
            {
                var csb = new SqlConnectionStringBuilder(connectionString);
                var serverConnectionString = connectionString.Replace("Initial Catalog=" + csb.InitialCatalog, "Initial Catalog=");
                var cn = new SqlConnection(serverConnectionString);
                var cmd = new SqlCommand("ALTER DATABASE [" + csb.InitialCatalog + "] SET Multi_USER", cn)
                {
                    CommandType = CommandType.Text
                };

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        public static string CreateFileName(string connectionString)
        {
            try
            {
                var FileName = "";
                var csd = new SqlConnectionStringBuilder(connectionString);
                var temp = Calendar.MiladiToShamsi(DateTime.Now);/*/*Settings.DateManagment.DateM.Date*/
                temp = temp.Replace("/", "-");
                temp = temp.Replace("\\", "-");
                FileName = csd.InitialCatalog + "__" + temp + "__" + DateTime.Now.Hour/*Settings.DateManagment.DateM.Hour.ToString()*/ + "-" + DateTime.Now.Minute.ToString()/*Settings.DateManagment.DateM.Minute.ToString()*/ + ".NP";
                FileName = FileName.Replace(" ", "");
                var subPath = Path.Combine(Application.StartupPath, "TempBackUp"); // your code goes here
                var exists = Directory.Exists(subPath);
                if (!exists)
                    Directory.CreateDirectory(subPath);
                var fullPath = Path.Combine(subPath, FileName); // defultpath
                return fullPath;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return "";
            }
        }
        public static string BackupDB(string connectionString)
        {
            try
            {
                var fullPath = CreateFileName(connectionString);
                return BackupDB(connectionString, fullPath);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return "";
            }
        }

        public static string BackupDB(string connectionString, string path)
        {
            var fullPath = path;
            if (string.IsNullOrEmpty(fullPath))
            {
                fullPath = CreateFileName(connectionString);
                path = fullPath;
            }
            try
            {
                try
                {
                    var fileName = "";
                    var csbfilename = new SqlConnectionStringBuilder(connectionString);
                    var temp1 = Calendar.MiladiToShamsi(DateTime.Now);
                    temp1 = temp1.Replace("/", "-");
                    temp1 = temp1.Replace("\\", "-");
                    fileName = csbfilename.InitialCatalog + "__" + temp1 + "__" +
                               DateTime.Now.Hour + "-" +
                               DateTime.Now.Minute +
                               ".NP";
                    if (!path.ToLower().Contains(".bak") && !path.ToLower().Contains(".np"))
                    {
                        var exists = Directory.Exists(path);
                        if (!exists)
                            Directory.CreateDirectory(path);
                        fullPath = Path.Combine(path, fileName);
                    }
                    var cn = new SqlConnection(connectionString);
                    var csb = new SqlConnectionStringBuilder(connectionString);
                    var cmd =
                        new SqlCommand("Backup database [" + csb.InitialCatalog + "] to disk='" + fullPath + "'", cn)
                        {
                            CommandType = CommandType.Text
                        };
                    cmd.CommandTimeout *= 1000;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    return path;
                }
                catch (SqlException ex2)
                {
                    MessageBox.Show($"حطا در تهیه نسخه پشتیبان اطلاعات \r\nحساب کاربری SQL دسترسی به مسیر نصب برنامه ندارد\r\n{ex2.Message}",
                        "خطا", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    WebErrorLog.ErrorInstence.StartErrorLog(ex2);
                    return "";
                }
                catch (Exception ex)
                {
                    WebErrorLog.ErrorInstence.StartErrorLog(ex);
                    return "";
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return "";
            }
        }
        public static string ReStoreDB(string connectionString, string pathf, bool autoBackup)
        {
            var cn = new SqlConnection();
            try
            {
                GC.Collect();
                SqlConnection.ClearAllPools();

                if (autoBackup)
                {

                    var dir = Application.StartupPath + "\\NovinPardazBackUp";
                    if (!Directory.Exists(dir))
                        Directory.CreateDirectory(dir);

                    var file = Path.GetFileName(System.Reflection.Assembly.GetEntryAssembly().Location).Replace(".exe", "__");
                    var d = Calendar.MiladiToShamsi(DateTime.Now).Replace("/", "_");
                    d += "__" + DateTime.Now.Hour + " - " + DateTime.Now.Minute;
                    file += d;

                    var filepath = dir + "\\" + file + ".Bak";
                    if (BackupDB(connectionString, filepath) == "")
                        return $"حساب کاربری SQL دسترسی به مسیر نصب برنامه ندارد\r\nbackup Failed {connectionString}\r\nto address:{filepath}";
                }
                var csb = new SqlConnectionStringBuilder(connectionString);
                var ServerConnectionString = connectionString.Replace("Initial Catalog=" + csb.InitialCatalog, "Initial Catalog=");
                cn = new SqlConnection(ServerConnectionString) { ConnectionString = ServerConnectionString };
                var cmd = new SqlCommand("RESTORE DATABASE [dbName] FROM  DISK = N'bkPath' WITH  FILE = 1,  MOVE N'novin' TO N'dbMDFPath',  MOVE N'novin_log' TO N'dbLDFPath',   NOUNLOAD,  REPLACE,  STATS = 5", cn);
                //var dbInfo = new CLSServerDBs(connectionString);
                //var backUpInfo = new DataBaseBackUpInfo(pathf, cn.ConnectionString.ToString());

                cmd.CommandText = cmd.CommandText.Replace("dbName", csb.InitialCatalog);
                cmd.CommandText = cmd.CommandText.Replace("bkPath", pathf);
                //cmd.CommandText = cmd.CommandText.Replace("novin", backUpInfo.LogicalName);
                //cmd.CommandText = cmd.CommandText.Replace("novin_log", backUpInfo.LogicalName + "_log.ldf");
                //cmd.CommandText = cmd.CommandText.Replace("dbMDFPath", dbInfo.FileName);
                //cmd.CommandText = cmd.CommandText.Replace("dbLDFPath", dbInfo.FileName.ToLower().Replace(".mdf", "_log.Ldf"));
                cmd.CommandTimeout *= 1000;

                cn.Open();
                var temp = cmd.CommandText;
                cmd.CommandText = "ALTER DATABASE [" + csb.InitialCatalog + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                cmd.ExecuteNonQuery();

                cmd.CommandText = temp;
                cmd.ExecuteNonQuery();

                cmd.CommandText = cmd.CommandText.Replace("dbName", csb.InitialCatalog);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "ALTER DATABASE [" + csb.InitialCatalog + "] SET Multi_USER";
                cmd.ExecuteNonQuery();
                cn.Close();

                SqlConnection.ClearAllPools();
                Application.DoEvents();
                SetMultiUser(connectionString);
                return "";
            }
            catch (SqlException ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                cn.Close();
                SetMultiUser(connectionString);
                MessageBox.Show($"حساب کاربری SQL دسترسی به مسیر نصب برنامه ندارد\r\n{ex.Message }", "خطا", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                return ex.Message;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                cn.Close();
                SetMultiUser(connectionString);
                return ex.Message;
            }
        }

        //public static CreateDatabaseResult CreateDataBase(string DbName, string ServerConnectionString)
        //{
        //    var ret = new CreateDatabaseResult();
        //    if (string.IsNullOrEmpty(DbName))
        //    {
        //        ret.Status = EnCreateDataBase.DatabaseExists;
        //        ret.Result.AddReturnedValue(ReturnedState.Error, $"نام بانک اطلاعاتی خالی است.");
        //        return ret;
        //    }

        //    if (string.IsNullOrEmpty(ServerConnectionString))
        //    {
        //        ret.Status = EnCreateDataBase.ServerConnectionStringError;
        //        ret.Result.AddReturnedValue(ReturnedState.Error, $"رشته اتصال به سرور خالی است.");
        //        return ret;
        //    }

        //    try
        //    {
        //        try
        //        {
        //            var serverCn = new SqlConnection(ServerConnectionString);
        //            serverCn.Open();
        //            serverCn.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            ret.Status = EnCreateDataBase.ServerConnectionStringError;
        //            ret.Result.AddReturnedValue(ReturnedState.Error, $"سرویس sql در دسترس نیست \r\nserver:{ServerConnectionString}\r\n{ex.Message}");
        //            return ret;
        //        }

        //        SqlConnectionStringBuilder cbs = new SqlConnectionStringBuilder(ServerConnectionString);
        //        cbs.InitialCatalog = "master";

        //        if (ISExistDatabase(DbName, cbs.ConnectionString))
        //        {
        //            ret.Result.AddReturnedValue(ReturnedState.Error, $"بانک اطلاعاتی با نام {DbName} \r\nدر سرویس {ServerConnectionString}\r\n در حال حاضر وجود دارد.");
        //            ret.Status = EnCreateDataBase.DatabaseExists;
        //            return ret;
        //        }

        //        SqlConnection cn = new SqlConnection(cbs.ConnectionString);
        //        SqlCommand cmd = new SqlCommand("", cn);
        //        cmd.CommandType = CommandType.Text;
        //        string DBPath = System.Windows.Forms.Application.StartupPath + "\\DataBase";

        //        cmd.CommandText = "CREATE DATABASE [DBName]";
        //        cmd.CommandText = cmd.CommandText.Replace("DBName", DbName);

        //        var constr = cn.ConnectionString.Replace("master", DbName);
        //        cn.Open();
        //        cmd.ExecuteNonQuery();
        //        cn.Close();

        //        //return cn.ConnectionString.Replace("master", DbName);
        //        ret.ConnectionString = constr;
        //        ret.Status = EnCreateDataBase.Success;
        //    }
        //    catch (Exception ex)
        //    {
        //        if (ex.Message.ToLower().Contains("because it already exists".ToLower()))
        //            ret.Status = EnCreateDataBase.DatabaseExists;
        //        else
        //            WebErrorLog.ErrorInstence.StartErrorLog(ex);
        //        ret.Result.AddReturnedValue(ex);
        //    }
        //    return ret;
        //}

        public static bool ISExistDatabase(string DBName, string CN)
        {
            try
            {
                int Exist = 0;
                SqlConnection cn = new SqlConnection(CN);
                SqlCommand cmd = new SqlCommand("SELECT case when exists (select 1 from sys.Databases where Name = @DbName) then 1 else 0 end as DbExists", cn);
                cmd.Parameters.AddWithValue("@DbName", DBName);
                cn.Open();
                Exist = int.Parse(cmd.ExecuteScalar().ToString());
                cn.Close();
                if (Exist == 0)
                    return false;
                else return true;
            }
            catch (Exception e)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(e);
                return false;
            }
        }
    }
}

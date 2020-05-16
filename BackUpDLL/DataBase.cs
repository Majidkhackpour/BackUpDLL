using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Threading;
using PacketParser.Services;
using System.Windows.Forms;

namespace BackUpDLL
{
    public class DataBase
    {
        public static bool BackUpStart(string connectionString, string fileLocation = "", bool autoBackUp = false, CancellationToken token = default)
        {
            try
            {
                token.ThrowIfCancellationRequested();
                if (fileLocation == "")
                {
                    token.ThrowIfCancellationRequested();
                    var dlg = new SaveFileDialog { Title = @"پشتیبان گیری اطلاعات نوین پرداز" };
                    token.ThrowIfCancellationRequested();
                    var file = Path.GetFileName(System.Reflection.Assembly.GetEntryAssembly()?.Location)
                        ?.Replace(".exe", "__");
                    var d = Calendar.MiladiToShamsi(DateTime.Now).Replace("/", "_");
                    d += "__" + DateTime.Now.Hour + " - " + DateTime.Now.Minute;
                    file += d;
                    file = file.Replace(" ", "");
                    dlg.FileName = file;
                    token.ThrowIfCancellationRequested();
                    dlg.Filter = "*.Bak|*.Bak";
                    token.ThrowIfCancellationRequested();
                    token.ThrowIfCancellationRequested();
                    if (dlg.ShowDialog() != DialogResult.OK) return false;
                    token.ThrowIfCancellationRequested();
                    var result = DatabaseAction.BackupDB(connectionString, dlg.FileName);
                    token.ThrowIfCancellationRequested();

                    if (result != "")
                    {
                        MessageBox.Show(@"پشتیبان گیری با موفقیت انجام شد", @"پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                        return true;
                    }
                    MessageBox.Show(@"خطا در عملیات پشتیبان گیری اطلاعات", @"پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    return false;
                }
                else
                {
                    token.ThrowIfCancellationRequested();
                    var result = DatabaseAction.BackupDB(connectionString, fileLocation);
                    if (result != "")
                    {
                        token.ThrowIfCancellationRequested();
                        if (autoBackUp == false) { MessageBox.Show("پشتیبان گیری با موفیقیت انجام شد", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign); }

                        return true;
                    }
                    token.ThrowIfCancellationRequested();
                    if (autoBackUp == false) { MessageBox.Show("خطا در عملیات پشتیبان گیری اطلاعات", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign); }

                    return false;
                }
            }
            catch (ThreadAbortException) { return false; }
            catch (OperationCanceledException) { return false; }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return false;
            }
        }
        public static bool ReStoreStart(string connctionString, IWin32Window owner, string path = "", bool autoBackup = true)
        {
            try
            {
                if (path == "")
                {
                    var OFD = new OpenFileDialog
                    {
                        Multiselect = false,
                        Title = @"فایل حاوی اطلاعات پشتیبانی نرم افزار را انتخاب نمائید"
                    };

                    if (OFD.ShowDialog(owner) != DialogResult.OK) return false;
                    var backUpVersion = GetBackUpVersion(connctionString, OFD.FileName);
                    var dataBaseVersion = GetDataBaseVersion(connctionString);
                    if (backUpVersion > dataBaseVersion)
                    {
                        MessageBox.Show($@"{backUpVersion} نسخه فایل پشتیبان" + " \r\n" +
                                        $@"{dataBaseVersion} نسخه دیتابیس" + "\r\n" +
                                        "بدلیل بالاتر بودن نسخه پشتیبان نسبت به دیتابیس، امکان بازگردانی وجود ندارد");
                        return false;
                    }

                    SqlConnection.ClearAllPools();

                    if (DatabaseAction.ReStoreDB(connctionString, OFD.FileName, autoBackup) == "")
                    {

                        MessageBox.Show("بازگردانی اطلاعات با موفقیت انجام شد", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var exepath = Path.Combine(Application.StartupPath, System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe");
                        System.Diagnostics.Process.Start(exepath);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show(" خطا در بازگردانی اطلاعات ", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DatabaseAction.SetMultiUser(connctionString);
                        return false;
                    }

                }
                else
                {
                    var restoreMessage = DatabaseAction.ReStoreDB(connctionString, path, autoBackup);
                    if (restoreMessage == "")
                    {
                        MessageBox.Show("بازگردانی اطلاعات با موفقیت انجام شد", "پیغام سیستم", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        return true;
                    }
                    MessageBox.Show(" خطا در بازگردانی اطلاعات " + Environment.NewLine + restoreMessage, "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return false;
            }
        }

        private static float GetBackUpVersion(string connctionString, string backUpFileName)
        {
            var ver = (float)0;
            try
            {
                var cn = new SqlConnection(connctionString);
                if (string.IsNullOrEmpty(backUpFileName)) return ver;
                var command = @"RESTORE HEADERONLY FROM DISK ='" + backUpFileName + "'";

                using (var sqlCommand = new SqlCommand(command, cn))
                {
                    cn.Open();
                    var sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        Console.WriteLine();
                        var d = $"{sqlDataReader["DatabaseVersion"]}";
                        if (string.IsNullOrEmpty(d)) continue;
                        switch (d)
                        {
                            case "406": ver = 6; break;
                            case "408": ver = (float)6.5; break;
                            case "515": ver = 7; break;
                            case "539": ver = 2000; break;
                            case "611": ver = 2005; break;
                            case "612": ver = 2005; break;
                            case "655": ver = 2008; break;
                            case "661": ver = 2008; break;
                            case "706": ver = 2012; break;
                            case "782": ver = 2014; break;
                            case "869": ver = 2017; break;
                            case "895": ver = 2019; break;
                            case "852": ver = 2016; break;
                            default: ver = 0; break;
                        }

                        return ver;
                    }
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                ver = 0;
            }

            return ver;
        }

        private static float GetDataBaseVersion(string connctionString)
        {
            var ver = (float)0;
            try
            {
                var cn = new SqlConnection(connctionString);
                var query = "SELECT case" +
                           " when CONVERT(sysname, SERVERPROPERTY('ProductVersion')) " +
                           "like '8.0%' then 'SQL Server 2000'" +
                           "when CONVERT(sysname, SERVERPROPERTY('ProductVersion')) " +
                           "like '9.0%' then 'SQL Server 2005'" +
                           "when CONVERT(sysname, SERVERPROPERTY('ProductVersion')) " +
                           "like '10.0%' then 'SQL Server 2008' " +
                           "when CONVERT(sysname, SERVERPROPERTY('ProductVersion')) " +
                           "like '10.5%' then 'SQL Server 2008 R2' " +
                           "when CONVERT(sysname, SERVERPROPERTY('ProductVersion')) " +
                           "like '11.0%' then 'SQL Server 2012' " +
                           "when CONVERT(sysname, SERVERPROPERTY('ProductVersion')) " +
                           "like '12.0%' then 'SQL Server 2014' " +
                           "when CONVERT(sysname, SERVERPROPERTY('ProductVersion')) " +
                           "like '13.0%' then 'SQL Server 2016' " +
                           "when CONVERT(sysname, SERVERPROPERTY('ProductVersion')) " +
                           "like '14.0%' then 'SQL Server 2017' " +
                           "when CONVERT(sysname, SERVERPROPERTY('ProductVersion')) " +
                           "> '14.0.9' then 'SQL Server 2019 RC' " +
                           "else 'unknown' end as [version]";
                var da = new SqlDataAdapter(query, cn);
                var dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count <= 0) ver = 0;
                var versionName = dt.Rows[0].ItemArray[0].ToString().Remove(0, 11);
                ver = float.Parse(versionName);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                ver = 0;
            }

            return ver;

        }
    }
}

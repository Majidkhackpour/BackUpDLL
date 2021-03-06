﻿using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Services;

namespace BackUpDLL
{
    public partial class frmSetConnectionString : Form
    {
        public string connectionString = Settings.ServerConnectionsString;
        private string dbName;
        private ENSource _source;
        public frmSetConnectionString(ENSource source, string defaulConnection)
        {
            try
            {
                InitializeComponent();
                connectionString = defaulConnection;
                _source = source;
                var cn = new SqlConnection(connectionString);
                dbName = cn.Database;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void frmSetConnectionString_Load(object sender, EventArgs e)
        {
            try
            {
                switch (_source)
                {
                    case ENSource.Building:
                        Txt_DatabaseName.Text = "AradRealStatedb";
                        this.Text = "تنظیم رشته اتصال بانک اطلاعاتی املاک";
                        break;
                    case ENSource.Department:
                        Txt_DatabaseName.Text = "Department";
                        this.Text = "تنظیم رشته اتصال بانک اطلاعاتی دپارتمان";
                        break;
                }
                Txt_PathConnection.Text = connectionString;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void BTN_Intial_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frmSetEngin();
                frm.ShowDialog(this);

                if (!string.IsNullOrEmpty(Txt_PathConnection.Text))
                {
                    var cn = new SqlConnectionStringBuilder(Txt_PathConnection.Text);
                    var newCn = new SqlConnection(Settings.ServerConnectionsString);
                    cn.DataSource = newCn.DataSource;
                    Txt_PathConnection.Text = cn.ConnectionString;
                    return;
                }

                Txt_PathConnection.Text = Settings.ServerConnectionsString;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void Btn_Cansel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                var er = new ErrorProvider();
                er.Clear();
                if (string.IsNullOrEmpty(connectionString) || connectionString != Txt_PathConnection.Text)
                    connectionString = Txt_PathConnection.Text;
                if (rbtnCreate.Checked)
                {
                    if (string.IsNullOrEmpty(Txt_DatabaseName.Text))
                    {
                        er.SetError(Txt_DatabaseName, "نام بانک اطلاعاتی را وارد نمایید");
                        return;
                    }
                    var res = DataBase.CreateDatabase(Txt_DatabaseName.Text,
                        connectionString);


                    if (res.Result.HasError)
                    {
                        for (var i = 1; i < 20; i++)
                        {
                            var dbName = Txt_DatabaseName.Text + i;
                            res = DataBase.CreateDatabase(dbName, Txt_PathConnection.Text);
                            if (res.Result.HasError) continue;
                            Txt_DatabaseName.Text = dbName;
                            break;
                        }

                        if (res.Result.HasError)
                        {
                            return;
                        }
                    }

                    var cn = new SqlConnectionStringBuilder(connectionString) { InitialCatalog = Txt_DatabaseName.Text };
                    connectionString = cn.ConnectionString;
                }


                DialogResult = DialogResult.OK;
                if (!string.IsNullOrEmpty(connectionString))
                {
                    switch (_source)
                    {
                        case ENSource.Department:
                            Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Arad\\Department", "SQLCN",
                                connectionString);
                            break;
                        case ENSource.Building:
                            Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Arad",
                                "BuildingCn", connectionString);
                            break;
                    }
                }
                Close();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void BTN_NetIntial_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new FRMInitialSettings();
                if (frm.ShowDialog(this) != DialogResult.OK) return;
                connectionString = frm.ConnectionString;
                Txt_PathConnection.Text = frm.ConnectionString;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void rbtnCreate_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (!rbtnCreate.Checked) return;
                grpNetwork.Visible = false;
                GroupBox1.Visible = true;
                Txt_PathConnection.Text = "";
                this.Size = new Size(420, 471);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void rbtnNetwork_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (!rbtnNetwork.Checked) return;
                grpNetwork.Visible = true;
                GroupBox1.Visible = false;
                this.Size = new Size(420, 339);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
    }
}

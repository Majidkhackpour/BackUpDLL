using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Services;

namespace BackUpDLL
{
    public partial class frmSetEngin : Form
    {
        string _serverConnectionsString = "";
        public frmSetEngin()
        {
            InitializeComponent();
        }
        private SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

        private void frmSetEngin_Load(object sender, System.EventArgs e)
        {
            try
            {
                var temp = new SqlConnectionStringBuilder(Settings.ServerConnectionsString);
                TxtServerName.Text = temp.DataSource;
                RBWindowsDetect.Checked = temp.IntegratedSecurity;
                RBSqlServerDetect.Checked = !temp.IntegratedSecurity;
                TxtUserName.Text = temp.UserID;
                TxtPassword.Text = temp.Password;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void BTNCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (!TestConnection(false)) return;
                Settings.ServerConnectionsString = builder.ConnectionString;
                _serverConnectionsString = builder.ConnectionString;

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }
        private bool TestConnection(bool swShowDialo)
        {
            try
            {
                builder.DataSource = TxtServerName.Text;
                if (RBSqlServerDetect.Checked)
                {
                    builder.UserID = TxtUserName.Text;
                    builder.Password = TxtPassword.Text;
                    builder.IntegratedSecurity = false;
                }
                else
                {
                    builder.UserID = "";
                    builder.Password = "";
                    builder.IntegratedSecurity = true;
                }

                builder.AsynchronousProcessing = true;
                var con = new SqlConnection { ConnectionString = builder.ConnectionString };
                con.Open();
                if (swShowDialo)
                    MessageBox.Show(this, "ارتباط با بانک اطلاعاتی با موفقیت برقرار شد", "خطا", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                Settings.ServerConnectionsString = builder.ConnectionString;
                con.Close();

                return true;

            }
            catch (Exception)
            {
                MessageBox.Show(this, "ارتباط با بانک اطلاعاتی برقرار نیست", "خطا", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return false;
            }
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            try
            {
                TestConnection(true);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void RBSqlServerDetect_CheckedChanged(object sender, EventArgs e)
        {
            GBoxSql.Enabled = RBSqlServerDetect.Checked;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            return keyData == (Keys.F6) || base.ProcessCmdKey(ref msg, keyData);
        }

        private void frmSetEngin_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.F5:
                    BtnOk.PerformClick();
                    break;
                case Keys.Escape:
                    BTNCancel.PerformClick();
                    break;
                case Keys.F6:
                    BtnTest.PerformClick();
                    break;
            }
        }
    }
}

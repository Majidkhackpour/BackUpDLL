namespace BackUpDLL
{
    partial class frmSetEngin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetEngin));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtServerName = new System.Windows.Forms.TextBox();
            this.RBWindowsDetect = new System.Windows.Forms.RadioButton();
            this.RBSqlServerDetect = new System.Windows.Forms.RadioButton();
            this.GBoxSql = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.BtnOk = new DevComponents.DotNetBar.ButtonX();
            this.BTNCancel = new DevComponents.DotNetBar.ButtonX();
            this.BtnTest = new DevComponents.DotNetBar.ButtonX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GBoxSql.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(288, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "نام سرور:";
            // 
            // TxtServerName
            // 
            this.TxtServerName.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtServerName.Location = new System.Drawing.Point(21, 20);
            this.TxtServerName.Name = "TxtServerName";
            this.TxtServerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtServerName.Size = new System.Drawing.Size(259, 31);
            this.TxtServerName.TabIndex = 13;
            // 
            // RBWindowsDetect
            // 
            this.RBWindowsDetect.AutoSize = true;
            this.RBWindowsDetect.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RBWindowsDetect.Location = new System.Drawing.Point(158, 3);
            this.RBWindowsDetect.Name = "RBWindowsDetect";
            this.RBWindowsDetect.Size = new System.Drawing.Size(167, 30);
            this.RBWindowsDetect.TabIndex = 1;
            this.RBWindowsDetect.TabStop = true;
            this.RBWindowsDetect.Text = "احراز هویت توسط ویندوز";
            this.RBWindowsDetect.UseVisualStyleBackColor = true;
            // 
            // RBSqlServerDetect
            // 
            this.RBSqlServerDetect.AutoSize = true;
            this.RBSqlServerDetect.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RBSqlServerDetect.Location = new System.Drawing.Point(158, 38);
            this.RBSqlServerDetect.Name = "RBSqlServerDetect";
            this.RBSqlServerDetect.Size = new System.Drawing.Size(169, 30);
            this.RBSqlServerDetect.TabIndex = 2;
            this.RBSqlServerDetect.TabStop = true;
            this.RBSqlServerDetect.Text = "احراز هویت توسط SQL";
            this.RBSqlServerDetect.UseVisualStyleBackColor = true;
            this.RBSqlServerDetect.CheckedChanged += new System.EventHandler(this.RBSqlServerDetect_CheckedChanged);
            // 
            // GBoxSql
            // 
            this.GBoxSql.Controls.Add(this.label3);
            this.GBoxSql.Controls.Add(this.label2);
            this.GBoxSql.Controls.Add(this.TxtPassword);
            this.GBoxSql.Controls.Add(this.TxtUserName);
            this.GBoxSql.Enabled = false;
            this.GBoxSql.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GBoxSql.Location = new System.Drawing.Point(21, 128);
            this.GBoxSql.Name = "GBoxSql";
            this.GBoxSql.Size = new System.Drawing.Size(335, 102);
            this.GBoxSql.TabIndex = 15;
            this.GBoxSql.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(257, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "رمز عبور : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(257, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام کاربری :";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtPassword.Location = new System.Drawing.Point(16, 63);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtPassword.Size = new System.Drawing.Size(230, 31);
            this.TxtPassword.TabIndex = 4;
            // 
            // TxtUserName
            // 
            this.TxtUserName.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtUserName.Location = new System.Drawing.Point(16, 20);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtUserName.Size = new System.Drawing.Size(230, 31);
            this.TxtUserName.TabIndex = 3;
            // 
            // BtnOk
            // 
            this.BtnOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnOk.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.BtnOk.Location = new System.Drawing.Point(111, 251);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(99, 34);
            this.BtnOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnOk.TabIndex = 19;
            this.BtnOk.Text = "تائید(F5)";
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BTNCancel
            // 
            this.BTNCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNCancel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.BTNCancel.Location = new System.Drawing.Point(7, 251);
            this.BTNCancel.Name = "BTNCancel";
            this.BTNCancel.Size = new System.Drawing.Size(99, 34);
            this.BTNCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNCancel.TabIndex = 18;
            this.BTNCancel.Text = "انصراف(Esc)";
            this.BTNCancel.Click += new System.EventHandler(this.BTNCancel_Click);
            // 
            // BtnTest
            // 
            this.BtnTest.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnTest.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnTest.Location = new System.Drawing.Point(216, 251);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(99, 34);
            this.BtnTest.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnTest.TabIndex = 17;
            this.BtnTest.Text = "تست ارتباط (F6)";
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RBWindowsDetect);
            this.panel1.Controls.Add(this.RBSqlServerDetect);
            this.panel1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panel1.Location = new System.Drawing.Point(21, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 74);
            this.panel1.TabIndex = 16;
            // 
            // frmSetEngin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 304);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtServerName);
            this.Controls.Add(this.GBoxSql);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.BTNCancel);
            this.Controls.Add(this.BtnTest);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetEngin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تنظیمات ارتباط با شبکه";
            this.Load += new System.EventHandler(this.frmSetEngin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSetEngin_KeyDown);
            this.GBoxSql.ResumeLayout(false);
            this.GBoxSql.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtServerName;
        private System.Windows.Forms.RadioButton RBWindowsDetect;
        private System.Windows.Forms.RadioButton RBSqlServerDetect;
        private System.Windows.Forms.GroupBox GBoxSql;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUserName;
        private DevComponents.DotNetBar.ButtonX BtnOk;
        private DevComponents.DotNetBar.ButtonX BTNCancel;
        private DevComponents.DotNetBar.ButtonX BtnTest;
        private System.Windows.Forms.Panel panel1;
    }
}
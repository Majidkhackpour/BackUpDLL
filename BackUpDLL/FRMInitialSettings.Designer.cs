namespace BackUpDLL
{
    partial class FRMInitialSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMInitialSettings));
            this.PanelDB = new System.Windows.Forms.Panel();
            this.Label5 = new System.Windows.Forms.Label();
            this.InitialCategory = new System.Windows.Forms.ComboBox();
            this.BTNCancel = new DevComponents.DotNetBar.ButtonX();
            this.BTNTestConnection = new DevComponents.DotNetBar.ButtonX();
            this.BTNOK = new DevComponents.DotNetBar.ButtonX();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.DataSource = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Pass = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.IntegratedSecuriry = new System.Windows.Forms.CheckBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.PanelDB.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelDB
            // 
            this.PanelDB.Controls.Add(this.Label5);
            this.PanelDB.Controls.Add(this.InitialCategory);
            this.PanelDB.Controls.Add(this.TextBox1);
            this.PanelDB.Location = new System.Drawing.Point(10, 333);
            this.PanelDB.Name = "PanelDB";
            this.PanelDB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PanelDB.Size = new System.Drawing.Size(396, 71);
            this.PanelDB.TabIndex = 9;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(305, 11);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(96, 20);
            this.Label5.TabIndex = 1;
            this.Label5.Text = "نام بانك اطلاعاتي :";
            // 
            // InitialCategory
            // 
            this.InitialCategory.FormattingEnabled = true;
            this.InitialCategory.Items.AddRange(new object[] {
            "Hesab88"});
            this.InitialCategory.Location = new System.Drawing.Point(207, 36);
            this.InitialCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InitialCategory.Name = "InitialCategory";
            this.InitialCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InitialCategory.Size = new System.Drawing.Size(127, 28);
            this.InitialCategory.TabIndex = 0;
            this.InitialCategory.Enter += new System.EventHandler(this.InitialCategory_Enter);
            // 
            // BTNCancel
            // 
            this.BTNCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNCancel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.BTNCancel.Location = new System.Drawing.Point(9, 414);
            this.BTNCancel.Name = "BTNCancel";
            this.BTNCancel.Size = new System.Drawing.Size(97, 34);
            this.BTNCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNCancel.TabIndex = 12;
            this.BTNCancel.Text = "انصراف";
            this.BTNCancel.Click += new System.EventHandler(this.BTNCancel_Click);
            // 
            // BTNTestConnection
            // 
            this.BTNTestConnection.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNTestConnection.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNTestConnection.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.BTNTestConnection.Location = new System.Drawing.Point(111, 414);
            this.BTNTestConnection.Name = "BTNTestConnection";
            this.BTNTestConnection.Size = new System.Drawing.Size(97, 34);
            this.BTNTestConnection.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNTestConnection.TabIndex = 11;
            this.BTNTestConnection.Text = "تست ارتباط";
            this.BTNTestConnection.Click += new System.EventHandler(this.BTNTestConnection_Click);
            // 
            // BTNOK
            // 
            this.BTNOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNOK.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.BTNOK.Location = new System.Drawing.Point(212, 414);
            this.BTNOK.Name = "BTNOK";
            this.BTNOK.Size = new System.Drawing.Size(97, 34);
            this.BTNOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNOK.TabIndex = 10;
            this.BTNOK.Text = "تاييد";
            this.BTNOK.Click += new System.EventHandler(this.BTNOK_Click);
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("B Titr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label2.Location = new System.Drawing.Point(9, 10);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(401, 58);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "كاربر گرامي ، \r\nتوصيه ميشود جهت تنظيم پارامترهاي اين قسمت از تيم فني گروه نرم افز" +
    "اري آراد كمك بگيريد";
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.DataSource);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Font = new System.Drawing.Font("B Titr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GroupBox1.Location = new System.Drawing.Point(10, 73);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox1.Size = new System.Drawing.Size(396, 140);
            this.GroupBox1.TabIndex = 7;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "مشخصات سرور";
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("B Titr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label3.ForeColor = System.Drawing.Color.Blue;
            this.Label3.Location = new System.Drawing.Point(14, 63);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(365, 72);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "1- در صورتي كه سيستم در شبكه كار ميكند اين بخش را بايد پس از راه اندازي شبكه به ص" +
    "ورت ServerIP\\SQLExpress پر كنيد\r\n2- و اگر سيستم بدون شبكه كار ميكند با .\\SQLExpr" +
    "ess";
            // 
            // DataSource
            // 
            this.DataSource.FormattingEnabled = true;
            this.DataSource.Items.AddRange(new object[] {
            ".\\SQLExpress",
            ".",
            "(Local)"});
            this.DataSource.Location = new System.Drawing.Point(116, 30);
            this.DataSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataSource.Name = "DataSource";
            this.DataSource.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataSource.Size = new System.Drawing.Size(220, 28);
            this.DataSource.TabIndex = 0;
            this.DataSource.SelectedIndexChanged += new System.EventHandler(this.DataSource_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(344, 30);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(49, 28);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "نام سرور :";
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.GroupBox2.Controls.Add(this.Panel1);
            this.GroupBox2.Controls.Add(this.IntegratedSecuriry);
            this.GroupBox2.Location = new System.Drawing.Point(10, 223);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox2.Size = new System.Drawing.Size(396, 102);
            this.GroupBox2.TabIndex = 8;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "احراز هويت";
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.Pass);
            this.Panel1.Controls.Add(this.Label6);
            this.Panel1.Controls.Add(this.UserName);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Enabled = false;
            this.Panel1.Location = new System.Drawing.Point(5, 53);
            this.Panel1.Name = "Panel1";
            this.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Panel1.Size = new System.Drawing.Size(391, 41);
            this.Panel1.TabIndex = 1;
            // 
            // Pass
            // 
            this.Pass.Font = new System.Drawing.Font("B Titr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Pass.Location = new System.Drawing.Point(7, 5);
            this.Pass.Name = "Pass";
            this.Pass.PasswordChar = '*';
            this.Pass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Pass.Size = new System.Drawing.Size(118, 27);
            this.Pass.TabIndex = 1;
            // 
            // Label6
            // 
            this.Label6.Font = new System.Drawing.Font("B Titr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label6.Location = new System.Drawing.Point(131, 8);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(52, 27);
            this.Label6.TabIndex = 2;
            this.Label6.Text = "كلمه عبور :";
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("B Titr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.UserName.Location = new System.Drawing.Point(202, 5);
            this.UserName.Name = "UserName";
            this.UserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UserName.Size = new System.Drawing.Size(129, 27);
            this.UserName.TabIndex = 0;
            // 
            // Label4
            // 
            this.Label4.Font = new System.Drawing.Font("B Titr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label4.Location = new System.Drawing.Point(337, 8);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(49, 27);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "نام كاربر :";
            // 
            // IntegratedSecuriry
            // 
            this.IntegratedSecuriry.AutoSize = true;
            this.IntegratedSecuriry.Checked = true;
            this.IntegratedSecuriry.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IntegratedSecuriry.Location = new System.Drawing.Point(186, 23);
            this.IntegratedSecuriry.Name = "IntegratedSecuriry";
            this.IntegratedSecuriry.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.IntegratedSecuriry.Size = new System.Drawing.Size(203, 24);
            this.IntegratedSecuriry.TabIndex = 0;
            this.IntegratedSecuriry.Text = "احراز هويت توسط ويندوز انجام شود";
            this.IntegratedSecuriry.UseVisualStyleBackColor = true;
            this.IntegratedSecuriry.CheckedChanged += new System.EventHandler(this.IntegratedSecuriry_CheckedChanged);
            // 
            // TextBox1
            // 
            this.TextBox1.Font = new System.Drawing.Font("B Titr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBox1.Location = new System.Drawing.Point(169, 4);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBox1.Size = new System.Drawing.Size(129, 27);
            this.TextBox1.TabIndex = 0;
            this.TextBox1.Visible = false;
            // 
            // FRMInitialSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 458);
            this.Controls.Add(this.PanelDB);
            this.Controls.Add(this.BTNCancel);
            this.Controls.Add(this.BTNTestConnection);
            this.Controls.Add(this.BTNOK);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox2);
            this.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMInitialSettings";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تنظیمات ارتباط با شبکه";
            this.Load += new System.EventHandler(this.FRMInitialSettings_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FRMInitialSettings_KeyDown);
            this.PanelDB.ResumeLayout(false);
            this.PanelDB.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel PanelDB;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ComboBox InitialCategory;
        private DevComponents.DotNetBar.ButtonX BTNCancel;
        private DevComponents.DotNetBar.ButtonX BTNTestConnection;
        private DevComponents.DotNetBar.ButtonX BTNOK;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ComboBox DataSource;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.TextBox Pass;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox UserName;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.CheckBox IntegratedSecuriry;
        internal System.Windows.Forms.TextBox TextBox1;
    }
}
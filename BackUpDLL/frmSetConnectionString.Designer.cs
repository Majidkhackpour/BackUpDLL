namespace BackUpDLL
{
    partial class frmSetConnectionString
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetConnectionString));
            this.BTN_NetIntial = new System.Windows.Forms.Button();
            this.BTN_Intial = new System.Windows.Forms.Button();
            this.Txt_DatabaseName = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_PathConnection = new System.Windows.Forms.TextBox();
            this.grpNetwork = new System.Windows.Forms.GroupBox();
            this.rbtnNetwork = new System.Windows.Forms.RadioButton();
            this.rbtnCreate = new System.Windows.Forms.RadioButton();
            this.Label2 = new System.Windows.Forms.Label();
            this.Txt_Conectiontring = new System.Windows.Forms.TextBox();
            this.Btn_Cansel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.grpNetwork.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_NetIntial
            // 
            this.BTN_NetIntial.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.BTN_NetIntial.Location = new System.Drawing.Point(9, 32);
            this.BTN_NetIntial.Name = "BTN_NetIntial";
            this.BTN_NetIntial.Size = new System.Drawing.Size(381, 38);
            this.BTN_NetIntial.TabIndex = 0;
            this.BTN_NetIntial.Text = "تنظیم رشته ی اتصال";
            this.BTN_NetIntial.UseVisualStyleBackColor = true;
            this.BTN_NetIntial.Click += new System.EventHandler(this.BTN_NetIntial_Click);
            // 
            // BTN_Intial
            // 
            this.BTN_Intial.Location = new System.Drawing.Point(11, 164);
            this.BTN_Intial.Name = "BTN_Intial";
            this.BTN_Intial.Size = new System.Drawing.Size(385, 27);
            this.BTN_Intial.TabIndex = 1;
            this.BTN_Intial.Text = "تنظیم رشته ی اتصال";
            this.BTN_Intial.UseVisualStyleBackColor = true;
            this.BTN_Intial.Click += new System.EventHandler(this.BTN_Intial_Click);
            // 
            // Txt_DatabaseName
            // 
            this.Txt_DatabaseName.Font = new System.Drawing.Font("B Titr", 8.25F, System.Drawing.FontStyle.Bold);
            this.Txt_DatabaseName.Location = new System.Drawing.Point(15, 26);
            this.Txt_DatabaseName.Name = "Txt_DatabaseName";
            this.Txt_DatabaseName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_DatabaseName.Size = new System.Drawing.Size(223, 27);
            this.Txt_DatabaseName.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(276, 30);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(114, 20);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "نام بانک اطلاعاتی :";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Txt_PathConnection);
            this.GroupBox1.Controls.Add(this.BTN_Intial);
            this.GroupBox1.Controls.Add(this.Txt_DatabaseName);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Font = new System.Drawing.Font("B Titr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GroupBox1.Location = new System.Drawing.Point(-1, 178);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(402, 200);
            this.GroupBox1.TabIndex = 24;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "تنظیمات بانک";
            // 
            // Txt_PathConnection
            // 
            this.Txt_PathConnection.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Txt_PathConnection.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Txt_PathConnection.ForeColor = System.Drawing.Color.Yellow;
            this.Txt_PathConnection.Location = new System.Drawing.Point(11, 59);
            this.Txt_PathConnection.Multiline = true;
            this.Txt_PathConnection.Name = "Txt_PathConnection";
            this.Txt_PathConnection.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_PathConnection.Size = new System.Drawing.Size(385, 99);
            this.Txt_PathConnection.TabIndex = 13;
            // 
            // grpNetwork
            // 
            this.grpNetwork.Controls.Add(this.BTN_NetIntial);
            this.grpNetwork.Font = new System.Drawing.Font("B Titr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grpNetwork.Location = new System.Drawing.Point(3, 176);
            this.grpNetwork.Name = "grpNetwork";
            this.grpNetwork.Size = new System.Drawing.Size(402, 79);
            this.grpNetwork.TabIndex = 25;
            this.grpNetwork.TabStop = false;
            this.grpNetwork.Text = "تنظیمات رشته اتصال";
            // 
            // rbtnNetwork
            // 
            this.rbtnNetwork.AutoSize = true;
            this.rbtnNetwork.Font = new System.Drawing.Font("B Titr", 9.75F, System.Drawing.FontStyle.Bold);
            this.rbtnNetwork.Location = new System.Drawing.Point(34, 145);
            this.rbtnNetwork.Name = "rbtnNetwork";
            this.rbtnNetwork.Size = new System.Drawing.Size(191, 27);
            this.rbtnNetwork.TabIndex = 21;
            this.rbtnNetwork.TabStop = true;
            this.rbtnNetwork.Text = "تنظیمات رشته اتصال  پیشرفته/شبکه";
            this.rbtnNetwork.UseVisualStyleBackColor = true;
            this.rbtnNetwork.CheckedChanged += new System.EventHandler(this.rbtnNetwork_CheckedChanged);
            // 
            // rbtnCreate
            // 
            this.rbtnCreate.AutoSize = true;
            this.rbtnCreate.Font = new System.Drawing.Font("B Titr", 9.75F, System.Drawing.FontStyle.Bold);
            this.rbtnCreate.Location = new System.Drawing.Point(251, 145);
            this.rbtnCreate.Name = "rbtnCreate";
            this.rbtnCreate.Size = new System.Drawing.Size(144, 27);
            this.rbtnCreate.TabIndex = 20;
            this.rbtnCreate.Text = "بانک اطلاعاتی ایجاد شود";
            this.rbtnCreate.UseVisualStyleBackColor = true;
            this.rbtnCreate.CheckedChanged += new System.EventHandler(this.rbtnCreate_CheckedChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("B Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label2.ForeColor = System.Drawing.Color.Red;
            this.Label2.Location = new System.Drawing.Point(135, 4);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(264, 23);
            this.Label2.TabIndex = 27;
            this.Label2.Text = "بانک اطلاعاتی با رشته اتصال ذیل در دسترس نمی باشد";
            // 
            // Txt_Conectiontring
            // 
            this.Txt_Conectiontring.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Txt_Conectiontring.ForeColor = System.Drawing.Color.Yellow;
            this.Txt_Conectiontring.Location = new System.Drawing.Point(10, 28);
            this.Txt_Conectiontring.Multiline = true;
            this.Txt_Conectiontring.Name = "Txt_Conectiontring";
            this.Txt_Conectiontring.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_Conectiontring.Size = new System.Drawing.Size(385, 78);
            this.Txt_Conectiontring.TabIndex = 26;
            // 
            // Btn_Cansel
            // 
            this.Btn_Cansel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Cansel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cansel.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Cansel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Cansel.Location = new System.Drawing.Point(11, 386);
            this.Btn_Cansel.Name = "Btn_Cansel";
            this.Btn_Cansel.Size = new System.Drawing.Size(95, 42);
            this.Btn_Cansel.TabIndex = 23;
            this.Btn_Cansel.Text = "انصراف";
            this.Btn_Cansel.UseVisualStyleBackColor = true;
            this.Btn_Cansel.Click += new System.EventHandler(this.Btn_Cansel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_OK.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_OK.Location = new System.Drawing.Point(108, 386);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(95, 42);
            this.btn_OK.TabIndex = 22;
            this.btn_OK.Text = "تائید";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // frmSetConnectionString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 432);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.grpNetwork);
            this.Controls.Add(this.rbtnNetwork);
            this.Controls.Add(this.rbtnCreate);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Txt_Conectiontring);
            this.Controls.Add(this.Btn_Cansel);
            this.Controls.Add(this.btn_OK);
            this.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetConnectionString";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSetConnectionString_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.grpNetwork.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BTN_NetIntial;
        public System.Windows.Forms.Button BTN_Intial;
        public System.Windows.Forms.TextBox Txt_DatabaseName;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        public System.Windows.Forms.TextBox Txt_PathConnection;
        internal System.Windows.Forms.GroupBox grpNetwork;
        public System.Windows.Forms.RadioButton rbtnNetwork;
        public System.Windows.Forms.RadioButton rbtnCreate;
        internal System.Windows.Forms.Label Label2;
        public System.Windows.Forms.TextBox Txt_Conectiontring;
        internal System.Windows.Forms.Button Btn_Cansel;
        internal System.Windows.Forms.Button btn_OK;
    }
}
namespace AttendanceManagementSystem.Forms.Auth
{
    partial class SignUp_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp_Form));
            this.pe_ImageDisplay = new DevExpress.XtraEditors.PictureEdit();
            this.panel_UserData = new DevExpress.XtraEditors.PanelControl();
            this.btn_Close = new DevExpress.XtraEditors.SimpleButton();
            this.icon_Password = new DevExpress.XtraEditors.PictureEdit();
            this.icon_Email = new DevExpress.XtraEditors.PictureEdit();
            this.icon_Person = new DevExpress.XtraEditors.PictureEdit();
            this.btn_CreateAccount = new DevExpress.XtraEditors.SimpleButton();
            this.label_LogInNow = new System.Windows.Forms.Label();
            this.label_Instruction = new System.Windows.Forms.Label();
            this.label_Desciption = new System.Windows.Forms.Label();
            this.txt_Password = new DevExpress.XtraEditors.TextEdit();
            this.txt_Email = new DevExpress.XtraEditors.TextEdit();
            this.txt_UserName = new DevExpress.XtraEditors.TextEdit();
            this.label_Heading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pe_ImageDisplay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_UserData)).BeginInit();
            this.panel_UserData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_Password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_Email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_Person.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_UserName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pe_ImageDisplay
            // 
            this.pe_ImageDisplay.Dock = System.Windows.Forms.DockStyle.Left;
            this.pe_ImageDisplay.EditValue = ((object)(resources.GetObject("pe_ImageDisplay.EditValue")));
            this.pe_ImageDisplay.Location = new System.Drawing.Point(0, 0);
            this.pe_ImageDisplay.Name = "pe_ImageDisplay";
            this.pe_ImageDisplay.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pe_ImageDisplay.Size = new System.Drawing.Size(518, 734);
            this.pe_ImageDisplay.TabIndex = 4;
            // 
            // panel_UserData
            // 
            this.panel_UserData.Appearance.BackColor = System.Drawing.Color.White;
            this.panel_UserData.Appearance.Options.UseBackColor = true;
            this.panel_UserData.Controls.Add(this.btn_Close);
            this.panel_UserData.Controls.Add(this.icon_Password);
            this.panel_UserData.Controls.Add(this.icon_Email);
            this.panel_UserData.Controls.Add(this.icon_Person);
            this.panel_UserData.Controls.Add(this.btn_CreateAccount);
            this.panel_UserData.Controls.Add(this.label_LogInNow);
            this.panel_UserData.Controls.Add(this.label_Instruction);
            this.panel_UserData.Controls.Add(this.label_Desciption);
            this.panel_UserData.Controls.Add(this.txt_Password);
            this.panel_UserData.Controls.Add(this.txt_Email);
            this.panel_UserData.Controls.Add(this.txt_UserName);
            this.panel_UserData.Controls.Add(this.label_Heading);
            this.panel_UserData.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_UserData.Location = new System.Drawing.Point(519, 0);
            this.panel_UserData.Name = "panel_UserData";
            this.panel_UserData.Size = new System.Drawing.Size(517, 734);
            this.panel_UserData.TabIndex = 5;
            // 
            // btn_Close
            // 
            this.btn_Close.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Close.Appearance.Options.UseBackColor = true;
            this.btn_Close.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Close.ImageOptions.SvgImage")));
            this.btn_Close.Location = new System.Drawing.Point(478, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(39, 38);
            this.btn_Close.TabIndex = 32;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // icon_Password
            // 
            this.icon_Password.EditValue = ((object)(resources.GetObject("icon_Password.EditValue")));
            this.icon_Password.Location = new System.Drawing.Point(75, 402);
            this.icon_Password.Name = "icon_Password";
            this.icon_Password.Properties.AllowZoom = DevExpress.Utils.DefaultBoolean.True;
            this.icon_Password.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.icon_Password.Properties.Appearance.Options.UseBackColor = true;
            this.icon_Password.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.icon_Password.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.icon_Password.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.icon_Password.Properties.SvgImageSize = new System.Drawing.Size(14, 14);
            this.icon_Password.Size = new System.Drawing.Size(22, 18);
            this.icon_Password.TabIndex = 31;
            // 
            // icon_Email
            // 
            this.icon_Email.EditValue = ((object)(resources.GetObject("icon_Email.EditValue")));
            this.icon_Email.Location = new System.Drawing.Point(75, 336);
            this.icon_Email.Name = "icon_Email";
            this.icon_Email.Properties.AllowZoom = DevExpress.Utils.DefaultBoolean.True;
            this.icon_Email.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.icon_Email.Properties.Appearance.Options.UseBackColor = true;
            this.icon_Email.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.icon_Email.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.icon_Email.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.icon_Email.Properties.SvgImageSize = new System.Drawing.Size(14, 14);
            this.icon_Email.Size = new System.Drawing.Size(22, 18);
            this.icon_Email.TabIndex = 30;
            // 
            // icon_Person
            // 
            this.icon_Person.EditValue = ((object)(resources.GetObject("icon_Person.EditValue")));
            this.icon_Person.Location = new System.Drawing.Point(75, 269);
            this.icon_Person.Name = "icon_Person";
            this.icon_Person.Properties.AllowZoom = DevExpress.Utils.DefaultBoolean.True;
            this.icon_Person.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.icon_Person.Properties.Appearance.Options.UseBackColor = true;
            this.icon_Person.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.icon_Person.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.icon_Person.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.icon_Person.Properties.SvgImageSize = new System.Drawing.Size(14, 14);
            this.icon_Person.Size = new System.Drawing.Size(22, 18);
            this.icon_Person.TabIndex = 27;
            // 
            // btn_CreateAccount
            // 
            this.btn_CreateAccount.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(182)))), ((int)(((byte)(125)))));
            this.btn_CreateAccount.Appearance.Font = new System.Drawing.Font("Poppins Medium", 10.54F);
            this.btn_CreateAccount.Appearance.Options.UseBackColor = true;
            this.btn_CreateAccount.Appearance.Options.UseFont = true;
            this.btn_CreateAccount.Appearance.Options.UseTextOptions = true;
            this.btn_CreateAccount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_CreateAccount.Location = new System.Drawing.Point(68, 454);
            this.btn_CreateAccount.Name = "btn_CreateAccount";
            this.btn_CreateAccount.Size = new System.Drawing.Size(380, 54);
            this.btn_CreateAccount.TabIndex = 29;
            this.btn_CreateAccount.Text = "Create Account";
            this.btn_CreateAccount.Click += new System.EventHandler(this.btn_CreateAccount_Click);
            // 
            // label_LogInNow
            // 
            this.label_LogInNow.AutoSize = true;
            this.label_LogInNow.BackColor = System.Drawing.Color.Transparent;
            this.label_LogInNow.Font = new System.Drawing.Font("Poppins SemiBold", 8.54F);
            this.label_LogInNow.Location = new System.Drawing.Point(366, 511);
            this.label_LogInNow.Name = "label_LogInNow";
            this.label_LogInNow.Size = new System.Drawing.Size(82, 22);
            this.label_LogInNow.TabIndex = 28;
            this.label_LogInNow.Text = "LOG IN NOW";
            this.label_LogInNow.Click += new System.EventHandler(this.label_LogInNow_Click);
            // 
            // label_Instruction
            // 
            this.label_Instruction.AutoSize = true;
            this.label_Instruction.BackColor = System.Drawing.Color.Transparent;
            this.label_Instruction.Font = new System.Drawing.Font("Poppins", 8.54F);
            this.label_Instruction.Location = new System.Drawing.Point(64, 511);
            this.label_Instruction.Name = "label_Instruction";
            this.label_Instruction.Size = new System.Drawing.Size(148, 22);
            this.label_Instruction.TabIndex = 26;
            this.label_Instruction.Text = "Already have account?";
            // 
            // label_Desciption
            // 
            this.label_Desciption.AutoSize = true;
            this.label_Desciption.BackColor = System.Drawing.Color.Transparent;
            this.label_Desciption.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.label_Desciption.Location = new System.Drawing.Point(123, 191);
            this.label_Desciption.Name = "label_Desciption";
            this.label_Desciption.Size = new System.Drawing.Size(270, 26);
            this.label_Desciption.TabIndex = 25;
            this.label_Desciption.Text = "SIGN UP AND MANAGE ATTENDANCE";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(68, 389);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Properties.AutoHeight = false;
            this.txt_Password.Properties.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.txt_Password.Properties.PasswordChar = '•';
            this.txt_Password.Size = new System.Drawing.Size(380, 46);
            this.txt_Password.TabIndex = 24;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(68, 323);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Properties.AutoHeight = false;
            this.txt_Email.Properties.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.txt_Email.Size = new System.Drawing.Size(380, 46);
            this.txt_Email.TabIndex = 23;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(68, 256);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Properties.AutoHeight = false;
            this.txt_UserName.Properties.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.txt_UserName.Size = new System.Drawing.Size(380, 46);
            this.txt_UserName.TabIndex = 22;
            // 
            // label_Heading
            // 
            this.label_Heading.AutoSize = true;
            this.label_Heading.BackColor = System.Drawing.Color.Transparent;
            this.label_Heading.Font = new System.Drawing.Font("Poppins SemiBold", 17.71F);
            this.label_Heading.Location = new System.Drawing.Point(187, 149);
            this.label_Heading.Name = "label_Heading";
            this.label_Heading.Size = new System.Drawing.Size(142, 42);
            this.label_Heading.TabIndex = 21;
            this.label_Heading.Text = "Welcome!";
            // 
            // SignUp_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 734);
            this.Controls.Add(this.panel_UserData);
            this.Controls.Add(this.pe_ImageDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp_Form";
            ((System.ComponentModel.ISupportInitialize)(this.pe_ImageDisplay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_UserData)).EndInit();
            this.panel_UserData.ResumeLayout(false);
            this.panel_UserData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_Password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_Email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_Person.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_UserName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pe_ImageDisplay;
        private DevExpress.XtraEditors.PanelControl panel_UserData;
        private DevExpress.XtraEditors.PictureEdit icon_Password;
        private DevExpress.XtraEditors.PictureEdit icon_Email;
        private DevExpress.XtraEditors.PictureEdit icon_Person;
        private DevExpress.XtraEditors.SimpleButton btn_CreateAccount;
        private System.Windows.Forms.Label label_LogInNow;
        private System.Windows.Forms.Label label_Instruction;
        private System.Windows.Forms.Label label_Desciption;
        private DevExpress.XtraEditors.TextEdit txt_Password;
        private DevExpress.XtraEditors.TextEdit txt_Email;
        private DevExpress.XtraEditors.TextEdit txt_UserName;
        private System.Windows.Forms.Label label_Heading;
        private DevExpress.XtraEditors.SimpleButton btn_Close;
    }
}
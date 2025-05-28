namespace AttendanceManagementSystem.Forms.Auth
{
    partial class LogIn_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn_Form));
            this.pe_ImageDisplay = new DevExpress.XtraEditors.PictureEdit();
            this.panel_UserData = new DevExpress.XtraEditors.PanelControl();
            this.btn_Close = new DevExpress.XtraEditors.SimpleButton();
            this.icon_Password = new DevExpress.XtraEditors.PictureEdit();
            this.icon_Email = new DevExpress.XtraEditors.PictureEdit();
            this.btn_LogIn = new DevExpress.XtraEditors.SimpleButton();
            this.label_SignUp = new System.Windows.Forms.Label();
            this.label_Instruction = new System.Windows.Forms.Label();
            this.label_Desciption = new System.Windows.Forms.Label();
            this.txt_Password = new DevExpress.XtraEditors.TextEdit();
            this.txt_Email = new DevExpress.XtraEditors.TextEdit();
            this.label_Heading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pe_ImageDisplay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_UserData)).BeginInit();
            this.panel_UserData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_Password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_Email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Email.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pe_ImageDisplay
            // 
            this.pe_ImageDisplay.Dock = System.Windows.Forms.DockStyle.Left;
            this.pe_ImageDisplay.EditValue = ((object)(resources.GetObject("pe_ImageDisplay.EditValue")));
            this.pe_ImageDisplay.Location = new System.Drawing.Point(0, 0);
            this.pe_ImageDisplay.Name = "pe_ImageDisplay";
            this.pe_ImageDisplay.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pe_ImageDisplay.Size = new System.Drawing.Size(518, 700);
            this.pe_ImageDisplay.TabIndex = 3;
            // 
            // panel_UserData
            // 
            this.panel_UserData.Appearance.BackColor = System.Drawing.Color.White;
            this.panel_UserData.Appearance.Options.UseBackColor = true;
            this.panel_UserData.Controls.Add(this.btn_Close);
            this.panel_UserData.Controls.Add(this.icon_Password);
            this.panel_UserData.Controls.Add(this.icon_Email);
            this.panel_UserData.Controls.Add(this.btn_LogIn);
            this.panel_UserData.Controls.Add(this.label_SignUp);
            this.panel_UserData.Controls.Add(this.label_Instruction);
            this.panel_UserData.Controls.Add(this.label_Desciption);
            this.panel_UserData.Controls.Add(this.txt_Password);
            this.panel_UserData.Controls.Add(this.txt_Email);
            this.panel_UserData.Controls.Add(this.label_Heading);
            this.panel_UserData.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_UserData.Location = new System.Drawing.Point(517, 0);
            this.panel_UserData.Name = "panel_UserData";
            this.panel_UserData.Size = new System.Drawing.Size(517, 700);
            this.panel_UserData.TabIndex = 4;
            // 
            // btn_Close
            // 
            this.btn_Close.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Close.Appearance.Options.UseBackColor = true;
            this.btn_Close.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Close.ImageOptions.SvgImage")));
            this.btn_Close.Location = new System.Drawing.Point(477, 0);
            this.btn_Close.LookAndFeel.SkinMaskColor = System.Drawing.Color.Transparent;
            this.btn_Close.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(40, 33);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // icon_Password
            // 
            this.icon_Password.EditValue = ((object)(resources.GetObject("icon_Password.EditValue")));
            this.icon_Password.Location = new System.Drawing.Point(75, 370);
            this.icon_Password.Name = "icon_Password";
            this.icon_Password.Properties.AllowZoom = DevExpress.Utils.DefaultBoolean.True;
            this.icon_Password.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.icon_Password.Properties.Appearance.Options.UseBackColor = true;
            this.icon_Password.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.icon_Password.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.icon_Password.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.icon_Password.Properties.SvgImageSize = new System.Drawing.Size(14, 14);
            this.icon_Password.Size = new System.Drawing.Size(22, 18);
            this.icon_Password.TabIndex = 20;
            // 
            // icon_Email
            // 
            this.icon_Email.EditValue = ((object)(resources.GetObject("icon_Email.EditValue")));
            this.icon_Email.Location = new System.Drawing.Point(75, 304);
            this.icon_Email.Name = "icon_Email";
            this.icon_Email.Properties.AllowZoom = DevExpress.Utils.DefaultBoolean.True;
            this.icon_Email.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.icon_Email.Properties.Appearance.Options.UseBackColor = true;
            this.icon_Email.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.icon_Email.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.icon_Email.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.icon_Email.Properties.SvgImageSize = new System.Drawing.Size(14, 14);
            this.icon_Email.Size = new System.Drawing.Size(22, 18);
            this.icon_Email.TabIndex = 19;
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(182)))), ((int)(((byte)(125)))));
            this.btn_LogIn.Appearance.Font = new System.Drawing.Font("Poppins Medium", 10.54F);
            this.btn_LogIn.Appearance.Options.UseBackColor = true;
            this.btn_LogIn.Appearance.Options.UseFont = true;
            this.btn_LogIn.Appearance.Options.UseTextOptions = true;
            this.btn_LogIn.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_LogIn.Location = new System.Drawing.Point(68, 422);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(380, 54);
            this.btn_LogIn.TabIndex = 18;
            this.btn_LogIn.Text = "Log in";
            this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
            // 
            // label_SignUp
            // 
            this.label_SignUp.AutoSize = true;
            this.label_SignUp.BackColor = System.Drawing.Color.Transparent;
            this.label_SignUp.Font = new System.Drawing.Font("Poppins SemiBold", 8.54F);
            this.label_SignUp.Location = new System.Drawing.Point(392, 479);
            this.label_SignUp.Name = "label_SignUp";
            this.label_SignUp.Size = new System.Drawing.Size(56, 22);
            this.label_SignUp.TabIndex = 17;
            this.label_SignUp.Text = "SIGN UP";
            this.label_SignUp.Click += new System.EventHandler(this.label_SignUp_Click);
            // 
            // label_Instruction
            // 
            this.label_Instruction.AutoSize = true;
            this.label_Instruction.BackColor = System.Drawing.Color.Transparent;
            this.label_Instruction.Font = new System.Drawing.Font("Poppins", 8.54F);
            this.label_Instruction.Location = new System.Drawing.Point(64, 479);
            this.label_Instruction.Name = "label_Instruction";
            this.label_Instruction.Size = new System.Drawing.Size(152, 22);
            this.label_Instruction.TabIndex = 15;
            this.label_Instruction.Text = "Don\'t have an account?";
            // 
            // label_Desciption
            // 
            this.label_Desciption.AutoSize = true;
            this.label_Desciption.BackColor = System.Drawing.Color.Transparent;
            this.label_Desciption.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.label_Desciption.Location = new System.Drawing.Point(177, 233);
            this.label_Desciption.Name = "label_Desciption";
            this.label_Desciption.Size = new System.Drawing.Size(162, 26);
            this.label_Desciption.TabIndex = 14;
            this.label_Desciption.Text = "LOG IN TO CONTINUE";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(68, 357);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Properties.AutoHeight = false;
            this.txt_Password.Properties.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.txt_Password.Properties.PasswordChar = '•';
            this.txt_Password.Size = new System.Drawing.Size(380, 46);
            this.txt_Password.TabIndex = 13;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(68, 291);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Properties.AutoHeight = false;
            this.txt_Email.Properties.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.txt_Email.Size = new System.Drawing.Size(380, 46);
            this.txt_Email.TabIndex = 12;
            // 
            // label_Heading
            // 
            this.label_Heading.AutoSize = true;
            this.label_Heading.BackColor = System.Drawing.Color.Transparent;
            this.label_Heading.Font = new System.Drawing.Font("Poppins SemiBold", 17.71F);
            this.label_Heading.Location = new System.Drawing.Point(187, 191);
            this.label_Heading.Name = "label_Heading";
            this.label_Heading.Size = new System.Drawing.Size(142, 42);
            this.label_Heading.TabIndex = 10;
            this.label_Heading.Text = "Welcome!";
            // 
            // LogIn_Form
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 700);
            this.Controls.Add(this.panel_UserData);
            this.Controls.Add(this.pe_ImageDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn_Form";
            ((System.ComponentModel.ISupportInitialize)(this.pe_ImageDisplay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_UserData)).EndInit();
            this.panel_UserData.ResumeLayout(false);
            this.panel_UserData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_Password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_Email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Email.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pe_ImageDisplay;
        private DevExpress.XtraEditors.PanelControl panel_UserData;
        private DevExpress.XtraEditors.PictureEdit icon_Password;
        private DevExpress.XtraEditors.PictureEdit icon_Email;
        private DevExpress.XtraEditors.SimpleButton btn_LogIn;
        private System.Windows.Forms.Label label_SignUp;
        private System.Windows.Forms.Label label_Instruction;
        private System.Windows.Forms.Label label_Desciption;
        private DevExpress.XtraEditors.TextEdit txt_Password;
        private DevExpress.XtraEditors.TextEdit txt_Email;
        private System.Windows.Forms.Label label_Heading;
        private DevExpress.XtraEditors.SimpleButton btn_Close;
    }
}
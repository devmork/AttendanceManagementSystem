namespace AttendanceManagementSystem.Forms
{
    partial class MainForm
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
            DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.accordion_Menu = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.btn_QRScanner = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.btn_Dashboard = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator2 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.btn_Attendance = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator3 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.btn_Students = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator4 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.btn_AttendanceRecord = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ace_Reports = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_StudentsAttendance = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_QRCodes = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator6 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.btn_LogOut = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.panel_Body = new DevExpress.XtraEditors.PanelControl();
            accordionControlSeparator5 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.accordion_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Body)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControlSeparator5
            // 
            accordionControlSeparator5.Name = "accordionControlSeparator5";
            accordionControlSeparator5.VisibleInFooter = false;
            // 
            // accordion_Menu
            // 
            this.accordion_Menu.Appearance.Item.Default.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordion_Menu.Appearance.Item.Default.Options.UseFont = true;
            this.accordion_Menu.Appearance.Item.Disabled.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordion_Menu.Appearance.Item.Disabled.Options.UseFont = true;
            this.accordion_Menu.Appearance.Item.Hovered.BackColor = System.Drawing.Color.White;
            this.accordion_Menu.Appearance.Item.Hovered.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordion_Menu.Appearance.Item.Hovered.Options.UseBackColor = true;
            this.accordion_Menu.Appearance.Item.Hovered.Options.UseFont = true;
            this.accordion_Menu.Appearance.Item.Normal.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordion_Menu.Appearance.Item.Normal.Options.UseFont = true;
            this.accordion_Menu.Appearance.Item.Pressed.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordion_Menu.Appearance.Item.Pressed.Options.UseFont = true;
            this.accordion_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordion_Menu.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btn_QRScanner,
            this.accordionControlSeparator1,
            this.btn_Dashboard,
            this.accordionControlSeparator2,
            this.btn_Attendance,
            this.accordionControlSeparator3,
            this.btn_Students,
            this.accordionControlSeparator4,
            this.btn_AttendanceRecord,
            accordionControlSeparator5,
            this.ace_Reports,
            this.accordionControlSeparator6,
            this.btn_LogOut});
            this.accordion_Menu.Location = new System.Drawing.Point(0, 0);
            this.accordion_Menu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.accordion_Menu.Name = "accordion_Menu";
            this.accordion_Menu.OptionsFooter.ActiveGroupDisplayMode = DevExpress.XtraBars.Navigation.ActiveGroupDisplayMode.GroupHeaderAndContent;
            this.accordion_Menu.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.AutoCollapse;
            this.accordion_Menu.Size = new System.Drawing.Size(276, 734);
            this.accordion_Menu.TabIndex = 5;
            this.accordion_Menu.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // btn_QRScanner
            // 
            this.btn_QRScanner.Appearance.Default.Font = new System.Drawing.Font("Poppins", 12F);
            this.btn_QRScanner.Appearance.Default.Options.UseFont = true;
            this.btn_QRScanner.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_QRScanner.ImageOptions.SvgImage")));
            this.btn_QRScanner.ImageOptions.SvgImageSize = new System.Drawing.Size(22, 22);
            this.btn_QRScanner.Name = "btn_QRScanner";
            this.btn_QRScanner.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_QRScanner.Text = "QR Scanner";
            this.btn_QRScanner.Click += new System.EventHandler(this.btn_QRScanner_Click);
            // 
            // accordionControlSeparator1
            // 
            this.accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.Appearance.Default.Font = new System.Drawing.Font("Poppins", 12F);
            this.btn_Dashboard.Appearance.Default.Options.UseFont = true;
            this.btn_Dashboard.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Dashboard.ImageOptions.SvgImage")));
            this.btn_Dashboard.ImageOptions.SvgImageSize = new System.Drawing.Size(22, 22);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_Dashboard.Text = "Dashboard";
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
            // 
            // accordionControlSeparator2
            // 
            this.accordionControlSeparator2.Name = "accordionControlSeparator2";
            // 
            // btn_Attendance
            // 
            this.btn_Attendance.Appearance.Default.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Attendance.Appearance.Default.Options.UseFont = true;
            this.btn_Attendance.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Attendance.ImageOptions.SvgImage")));
            this.btn_Attendance.ImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.btn_Attendance.Name = "btn_Attendance";
            this.btn_Attendance.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_Attendance.Text = "Attendance";
            this.btn_Attendance.Click += new System.EventHandler(this.btn_Attendance_Click);
            // 
            // accordionControlSeparator3
            // 
            this.accordionControlSeparator3.Name = "accordionControlSeparator3";
            // 
            // btn_Students
            // 
            this.btn_Students.Appearance.Default.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Students.Appearance.Default.Options.UseFont = true;
            this.btn_Students.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Students.ImageOptions.SvgImage")));
            this.btn_Students.ImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.btn_Students.Name = "btn_Students";
            this.btn_Students.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_Students.Text = "Students";
            this.btn_Students.Click += new System.EventHandler(this.btn_Students_Click);
            // 
            // accordionControlSeparator4
            // 
            this.accordionControlSeparator4.Name = "accordionControlSeparator4";
            // 
            // btn_AttendanceRecord
            // 
            this.btn_AttendanceRecord.Appearance.Default.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AttendanceRecord.Appearance.Default.Options.UseFont = true;
            this.btn_AttendanceRecord.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_AttendanceRecord.ImageOptions.SvgImage")));
            this.btn_AttendanceRecord.ImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.btn_AttendanceRecord.Name = "btn_AttendanceRecord";
            this.btn_AttendanceRecord.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_AttendanceRecord.Text = "Attendance Records";
            this.btn_AttendanceRecord.Click += new System.EventHandler(this.btn_AttendanceRecord_Click);
            // 
            // ace_Reports
            // 
            this.ace_Reports.Appearance.Default.Font = new System.Drawing.Font("Poppins", 12F);
            this.ace_Reports.Appearance.Default.Options.UseFont = true;
            this.ace_Reports.Appearance.Default.Options.UseTextOptions = true;
            this.ace_Reports.Appearance.Default.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.ace_Reports.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btn_StudentsAttendance,
            this.btn_QRCodes});
            this.ace_Reports.Expanded = true;
            this.ace_Reports.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ace_Reports.ImageOptions.SvgImage")));
            this.ace_Reports.ImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.ace_Reports.Name = "ace_Reports";
            this.ace_Reports.Text = "Reports";
            // 
            // btn_StudentsAttendance
            // 
            this.btn_StudentsAttendance.Appearance.Default.Font = new System.Drawing.Font("Poppins", 12F);
            this.btn_StudentsAttendance.Appearance.Default.Options.UseFont = true;
            this.btn_StudentsAttendance.Appearance.Default.Options.UseTextOptions = true;
            this.btn_StudentsAttendance.Appearance.Default.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.btn_StudentsAttendance.Name = "btn_StudentsAttendance";
            this.btn_StudentsAttendance.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_StudentsAttendance.Text = "Students Attendance";
            this.btn_StudentsAttendance.Click += new System.EventHandler(this.btn_StudentsAttendance_Click);
            // 
            // btn_QRCodes
            // 
            this.btn_QRCodes.Appearance.Default.Font = new System.Drawing.Font("Poppins", 12F);
            this.btn_QRCodes.Appearance.Default.Options.UseFont = true;
            this.btn_QRCodes.Name = "btn_QRCodes";
            this.btn_QRCodes.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_QRCodes.Text = "QR Codes";
            this.btn_QRCodes.Click += new System.EventHandler(this.btn_AllQRCodes_Click);
            // 
            // accordionControlSeparator6
            // 
            this.accordionControlSeparator6.Name = "accordionControlSeparator6";
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Appearance.Default.Font = new System.Drawing.Font("Poppins", 12F);
            this.btn_LogOut.Appearance.Default.Options.UseFont = true;
            this.btn_LogOut.ControlFooterAlignment = DevExpress.XtraBars.Navigation.AccordionItemFooterAlignment.Far;
            this.btn_LogOut.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_LogOut.ImageOptions.SvgImage")));
            this.btn_LogOut.ImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_LogOut.Text = "Log out";
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // panel_Body
            // 
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(276, 0);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(1010, 734);
            this.panel_Body.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 734);
            this.Controls.Add(this.panel_Body);
            this.Controls.Add(this.accordion_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("MainForm.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Event Attendance Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordion_Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Body)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordion_Menu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_Dashboard;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_Attendance;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_AttendanceRecord;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_Students;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_QRScanner;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator2;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator3;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_LogOut;
        private DevExpress.XtraEditors.PanelControl panel_Body;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ace_Reports;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_StudentsAttendance;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_QRCodes;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator6;
    }
}
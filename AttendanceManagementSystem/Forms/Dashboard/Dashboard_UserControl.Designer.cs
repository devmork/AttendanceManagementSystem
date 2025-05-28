namespace AttendanceManagementSystem.Forms.Dashboard
{
    partial class Dashboard_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_UserControl));
            this.lc_Dashboard = new DevExpress.XtraLayout.LayoutControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.icon_Students = new DevExpress.XtraEditors.PictureEdit();
            this.txt_TotalStudents = new DevExpress.XtraEditors.LabelControl();
            this.label_TotalStudents = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panel_Body = new DevExpress.XtraEditors.PanelControl();
            this.icon_Calendar = new DevExpress.XtraEditors.PictureEdit();
            this.txt_TotalAttendance = new DevExpress.XtraEditors.LabelControl();
            this.label_TotalAttendance = new DevExpress.XtraEditors.LabelControl();
            this.panel_PageHeading = new DevExpress.XtraEditors.PanelControl();
            this.label_PageTitle = new DevExpress.XtraEditors.LabelControl();
            this.label_PageDescription = new DevExpress.XtraEditors.LabelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lci_PageHeading = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_PanelBody = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lc_Dashboard)).BeginInit();
            this.lc_Dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_Students.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Body)).BeginInit();
            this.panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_Calendar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).BeginInit();
            this.panel_PageHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PanelBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // lc_Dashboard
            // 
            this.lc_Dashboard.Controls.Add(this.panelControl2);
            this.lc_Dashboard.Controls.Add(this.panelControl1);
            this.lc_Dashboard.Controls.Add(this.panel_Body);
            this.lc_Dashboard.Controls.Add(this.panel_PageHeading);
            this.lc_Dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_Dashboard.Location = new System.Drawing.Point(0, 0);
            this.lc_Dashboard.Name = "lc_Dashboard";
            this.lc_Dashboard.Root = this.Root;
            this.lc_Dashboard.Size = new System.Drawing.Size(1440, 1024);
            this.lc_Dashboard.TabIndex = 0;
            this.lc_Dashboard.Text = "layoutControl1";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.icon_Students);
            this.panelControl2.Controls.Add(this.txt_TotalStudents);
            this.panelControl2.Controls.Add(this.label_TotalStudents);
            this.panelControl2.Location = new System.Drawing.Point(723, 126);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(701, 161);
            this.panelControl2.TabIndex = 6;
            // 
            // icon_Students
            // 
            this.icon_Students.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icon_Students.EditValue = ((object)(resources.GetObject("icon_Students.EditValue")));
            this.icon_Students.Location = new System.Drawing.Point(577, 48);
            this.icon_Students.Name = "icon_Students";
            this.icon_Students.Properties.AllowZoom = DevExpress.Utils.DefaultBoolean.True;
            this.icon_Students.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.icon_Students.Properties.Appearance.Options.UseBackColor = true;
            this.icon_Students.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.icon_Students.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.icon_Students.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.icon_Students.Properties.SvgImageSize = new System.Drawing.Size(14, 14);
            this.icon_Students.Size = new System.Drawing.Size(80, 80);
            this.icon_Students.TabIndex = 21;
            // 
            // txt_TotalStudents
            // 
            this.txt_TotalStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_TotalStudents.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 36.62F);
            this.txt_TotalStudents.Appearance.Options.UseFont = true;
            this.txt_TotalStudents.Location = new System.Drawing.Point(30, 58);
            this.txt_TotalStudents.Name = "txt_TotalStudents";
            this.txt_TotalStudents.Size = new System.Drawing.Size(31, 87);
            this.txt_TotalStudents.TabIndex = 1;
            this.txt_TotalStudents.Text = "0";
            // 
            // label_TotalStudents
            // 
            this.label_TotalStudents.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 15F, System.Drawing.FontStyle.Bold);
            this.label_TotalStudents.Appearance.Options.UseFont = true;
            this.label_TotalStudents.Location = new System.Drawing.Point(30, 16);
            this.label_TotalStudents.Name = "label_TotalStudents";
            this.label_TotalStudents.Size = new System.Drawing.Size(146, 36);
            this.label_TotalStudents.TabIndex = 0;
            this.label_TotalStudents.Text = "Total Students";
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(16, 293);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1408, 715);
            this.panelControl1.TabIndex = 0;
            // 
            // panel_Body
            // 
            this.panel_Body.Controls.Add(this.icon_Calendar);
            this.panel_Body.Controls.Add(this.txt_TotalAttendance);
            this.panel_Body.Controls.Add(this.label_TotalAttendance);
            this.panel_Body.Location = new System.Drawing.Point(16, 126);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(701, 161);
            this.panel_Body.TabIndex = 5;
            // 
            // icon_Calendar
            // 
            this.icon_Calendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icon_Calendar.EditValue = ((object)(resources.GetObject("icon_Calendar.EditValue")));
            this.icon_Calendar.Location = new System.Drawing.Point(577, 48);
            this.icon_Calendar.Name = "icon_Calendar";
            this.icon_Calendar.Properties.AllowZoom = DevExpress.Utils.DefaultBoolean.True;
            this.icon_Calendar.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.icon_Calendar.Properties.Appearance.Options.UseBackColor = true;
            this.icon_Calendar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.icon_Calendar.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.icon_Calendar.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.icon_Calendar.Properties.SvgImageSize = new System.Drawing.Size(14, 14);
            this.icon_Calendar.Size = new System.Drawing.Size(80, 80);
            this.icon_Calendar.TabIndex = 20;
            // 
            // txt_TotalAttendance
            // 
            this.txt_TotalAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_TotalAttendance.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 36.62F);
            this.txt_TotalAttendance.Appearance.Options.UseFont = true;
            this.txt_TotalAttendance.Location = new System.Drawing.Point(31, 58);
            this.txt_TotalAttendance.Name = "txt_TotalAttendance";
            this.txt_TotalAttendance.Size = new System.Drawing.Size(31, 87);
            this.txt_TotalAttendance.TabIndex = 1;
            this.txt_TotalAttendance.Text = "0";
            // 
            // label_TotalAttendance
            // 
            this.label_TotalAttendance.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalAttendance.Appearance.Options.UseFont = true;
            this.label_TotalAttendance.Location = new System.Drawing.Point(31, 16);
            this.label_TotalAttendance.Name = "label_TotalAttendance";
            this.label_TotalAttendance.Size = new System.Drawing.Size(175, 36);
            this.label_TotalAttendance.TabIndex = 0;
            this.label_TotalAttendance.Text = "Total Attendance";
            // 
            // panel_PageHeading
            // 
            this.panel_PageHeading.Controls.Add(this.label_PageTitle);
            this.panel_PageHeading.Controls.Add(this.label_PageDescription);
            this.panel_PageHeading.Location = new System.Drawing.Point(16, 16);
            this.panel_PageHeading.Name = "panel_PageHeading";
            this.panel_PageHeading.Size = new System.Drawing.Size(1408, 104);
            this.panel_PageHeading.TabIndex = 4;
            // 
            // label_PageTitle
            // 
            this.label_PageTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_PageTitle.Appearance.Font = new System.Drawing.Font("Poppins", 17.71F, System.Drawing.FontStyle.Bold);
            this.label_PageTitle.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.label_PageTitle.Appearance.Options.UseFont = true;
            this.label_PageTitle.Location = new System.Drawing.Point(31, 22);
            this.label_PageTitle.Margin = new System.Windows.Forms.Padding(4);
            this.label_PageTitle.Name = "label_PageTitle";
            this.label_PageTitle.Size = new System.Drawing.Size(136, 42);
            this.label_PageTitle.TabIndex = 2;
            this.label_PageTitle.Text = "Dashboard";
            // 
            // label_PageDescription
            // 
            this.label_PageDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_PageDescription.Appearance.Font = new System.Drawing.Font("Poppins", 12F);
            this.label_PageDescription.Appearance.Options.UseFont = true;
            this.label_PageDescription.Location = new System.Drawing.Point(31, 59);
            this.label_PageDescription.Margin = new System.Windows.Forms.Padding(4);
            this.label_PageDescription.Name = "label_PageDescription";
            this.label_PageDescription.Size = new System.Drawing.Size(300, 28);
            this.label_PageDescription.TabIndex = 3;
            this.label_PageDescription.Text = "Overview of school event attendance.";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_PageHeading,
            this.lci_PanelBody,
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1440, 1024);
            this.Root.TextVisible = false;
            // 
            // lci_PageHeading
            // 
            this.lci_PageHeading.Control = this.panel_PageHeading;
            this.lci_PageHeading.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_PageHeading.CustomizationFormText = "layoutControlItem1";
            this.lci_PageHeading.Location = new System.Drawing.Point(0, 0);
            this.lci_PageHeading.Name = "lci_PageHeading";
            this.lci_PageHeading.Size = new System.Drawing.Size(1414, 110);
            this.lci_PageHeading.Text = "layoutControlItem1";
            this.lci_PageHeading.TextSize = new System.Drawing.Size(0, 0);
            this.lci_PageHeading.TextVisible = false;
            // 
            // lci_PanelBody
            // 
            this.lci_PanelBody.Control = this.panel_Body;
            this.lci_PanelBody.Location = new System.Drawing.Point(0, 110);
            this.lci_PanelBody.Name = "lci_PanelBody";
            this.lci_PanelBody.Size = new System.Drawing.Size(707, 167);
            this.lci_PanelBody.TextSize = new System.Drawing.Size(0, 0);
            this.lci_PanelBody.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panelControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 277);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1414, 721);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.panelControl2;
            this.layoutControlItem2.Location = new System.Drawing.Point(707, 110);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(707, 167);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // Dashboard_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lc_Dashboard);
            this.Name = "Dashboard_UserControl";
            this.Size = new System.Drawing.Size(1440, 1024);
            this.Load += new System.EventHandler(this.Dashboard_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lc_Dashboard)).EndInit();
            this.lc_Dashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_Students.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Body)).EndInit();
            this.panel_Body.ResumeLayout(false);
            this.panel_Body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_Calendar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).EndInit();
            this.panel_PageHeading.ResumeLayout(false);
            this.panel_PageHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PanelBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lc_Dashboard;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.PanelControl panel_PageHeading;
        private DevExpress.XtraEditors.LabelControl label_PageTitle;
        private DevExpress.XtraEditors.LabelControl label_PageDescription;
        private DevExpress.XtraLayout.LayoutControlItem lci_PageHeading;
        private DevExpress.XtraEditors.PanelControl panel_Body;
        private DevExpress.XtraLayout.LayoutControlItem lci_PanelBody;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl label_TotalStudents;
        private DevExpress.XtraEditors.LabelControl label_TotalAttendance;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.LabelControl txt_TotalStudents;
        private DevExpress.XtraEditors.LabelControl txt_TotalAttendance;
        private DevExpress.XtraEditors.PictureEdit icon_Calendar;
        private DevExpress.XtraEditors.PictureEdit icon_Students;
    }
}

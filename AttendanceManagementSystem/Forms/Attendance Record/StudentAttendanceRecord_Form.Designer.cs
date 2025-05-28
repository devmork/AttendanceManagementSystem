namespace AttendanceManagementSystem.Forms.Attendance_Report
{
    partial class StudentAttendanceRecord_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentAttendanceRecord_Form));
            this.lc_StudentAttendanceRecord = new DevExpress.XtraLayout.LayoutControl();
            this.panel_StudentInfo = new DevExpress.XtraEditors.PanelControl();
            this.txt_Name = new DevExpress.XtraEditors.LabelControl();
            this.txt_SchoolStudentId = new DevExpress.XtraEditors.LabelControl();
            this.label_SchoolStudentId = new DevExpress.XtraEditors.LabelControl();
            this.label_Name = new DevExpress.XtraEditors.LabelControl();
            this.panel_ResetRecord = new DevExpress.XtraEditors.PanelControl();
            this.btn_ResetRecord = new DevExpress.XtraEditors.SimpleButton();
            this.gc_AttendanceRecord = new DevExpress.XtraGrid.GridControl();
            this.gv_AttendanceRecord = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdclm_AttendanceName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_LogType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_TimeStamp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel_TotalAbsent = new DevExpress.XtraEditors.PanelControl();
            this.label_TotalAbsent = new DevExpress.XtraEditors.LabelControl();
            this.txt_TotalAbsent = new DevExpress.XtraEditors.TextEdit();
            this.panel_TotalPresent = new DevExpress.XtraEditors.PanelControl();
            this.label_TotalPresent = new DevExpress.XtraEditors.LabelControl();
            this.txt_TotalPresent = new DevExpress.XtraEditors.TextEdit();
            this.panel_PageHeading = new DevExpress.XtraEditors.PanelControl();
            this.icon_Student = new DevExpress.XtraEditors.PictureEdit();
            this.btn_CloseForm = new DevExpress.XtraEditors.PictureEdit();
            this.label_PageTitle = new DevExpress.XtraEditors.LabelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lci_PageHeading = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_TotalAbsent = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_TotalPresent = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_gridControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lci_ResetRecord = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_StudentInfo = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lc_StudentAttendanceRecord)).BeginInit();
            this.lc_StudentAttendanceRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_StudentInfo)).BeginInit();
            this.panel_StudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_ResetRecord)).BeginInit();
            this.panel_ResetRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_AttendanceRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_AttendanceRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_TotalAbsent)).BeginInit();
            this.panel_TotalAbsent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TotalAbsent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_TotalPresent)).BeginInit();
            this.panel_TotalPresent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TotalPresent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).BeginInit();
            this.panel_PageHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_Student.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseForm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_TotalAbsent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_TotalPresent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_ResetRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_StudentInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lc_StudentAttendanceRecord
            // 
            this.lc_StudentAttendanceRecord.Controls.Add(this.panel_StudentInfo);
            this.lc_StudentAttendanceRecord.Controls.Add(this.panel_ResetRecord);
            this.lc_StudentAttendanceRecord.Controls.Add(this.gc_AttendanceRecord);
            this.lc_StudentAttendanceRecord.Controls.Add(this.panel_TotalAbsent);
            this.lc_StudentAttendanceRecord.Controls.Add(this.panel_TotalPresent);
            this.lc_StudentAttendanceRecord.Controls.Add(this.panel_PageHeading);
            this.lc_StudentAttendanceRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_StudentAttendanceRecord.Location = new System.Drawing.Point(0, 0);
            this.lc_StudentAttendanceRecord.Name = "lc_StudentAttendanceRecord";
            this.lc_StudentAttendanceRecord.Root = this.Root;
            this.lc_StudentAttendanceRecord.Size = new System.Drawing.Size(680, 640);
            this.lc_StudentAttendanceRecord.TabIndex = 0;
            this.lc_StudentAttendanceRecord.Text = "layoutControl1";
            // 
            // panel_StudentInfo
            // 
            this.panel_StudentInfo.Controls.Add(this.txt_Name);
            this.panel_StudentInfo.Controls.Add(this.txt_SchoolStudentId);
            this.panel_StudentInfo.Controls.Add(this.label_SchoolStudentId);
            this.panel_StudentInfo.Controls.Add(this.label_Name);
            this.panel_StudentInfo.Location = new System.Drawing.Point(16, 64);
            this.panel_StudentInfo.Name = "panel_StudentInfo";
            this.panel_StudentInfo.Size = new System.Drawing.Size(648, 36);
            this.panel_StudentInfo.TabIndex = 2;
            // 
            // txt_Name
            // 
            this.txt_Name.Appearance.Font = new System.Drawing.Font("Poppins", 12F);
            this.txt_Name.Appearance.Options.UseFont = true;
            this.txt_Name.Location = new System.Drawing.Point(385, 4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(134, 28);
            this.txt_Name.TabIndex = 4;
            this.txt_Name.Text = "Den Mark C. Enoy";
            // 
            // txt_SchoolStudentId
            // 
            this.txt_SchoolStudentId.Appearance.Font = new System.Drawing.Font("Poppins", 12F);
            this.txt_SchoolStudentId.Appearance.Options.UseFont = true;
            this.txt_SchoolStudentId.Location = new System.Drawing.Point(69, 4);
            this.txt_SchoolStudentId.Name = "txt_SchoolStudentId";
            this.txt_SchoolStudentId.Size = new System.Drawing.Size(85, 28);
            this.txt_SchoolStudentId.TabIndex = 3;
            this.txt_SchoolStudentId.Text = "2023-0444";
            // 
            // label_SchoolStudentId
            // 
            this.label_SchoolStudentId.Appearance.Font = new System.Drawing.Font("Poppins Medium", 12F);
            this.label_SchoolStudentId.Appearance.Options.UseFont = true;
            this.label_SchoolStudentId.Location = new System.Drawing.Point(15, 4);
            this.label_SchoolStudentId.Name = "label_SchoolStudentId";
            this.label_SchoolStudentId.Size = new System.Drawing.Size(36, 28);
            this.label_SchoolStudentId.TabIndex = 2;
            this.label_SchoolStudentId.Text = "ID #:";
            // 
            // label_Name
            // 
            this.label_Name.Appearance.Font = new System.Drawing.Font("Poppins Medium", 12F);
            this.label_Name.Appearance.Options.UseFont = true;
            this.label_Name.Location = new System.Drawing.Point(328, 4);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(52, 28);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "Name:";
            // 
            // panel_ResetRecord
            // 
            this.panel_ResetRecord.Appearance.BackColor = System.Drawing.Color.White;
            this.panel_ResetRecord.Appearance.Options.UseBackColor = true;
            this.panel_ResetRecord.Controls.Add(this.btn_ResetRecord);
            this.panel_ResetRecord.Location = new System.Drawing.Point(482, 582);
            this.panel_ResetRecord.Name = "panel_ResetRecord";
            this.panel_ResetRecord.Size = new System.Drawing.Size(182, 42);
            this.panel_ResetRecord.TabIndex = 9;
            // 
            // btn_ResetRecord
            // 
            this.btn_ResetRecord.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(51)))), ((int)(((byte)(234)))));
            this.btn_ResetRecord.Appearance.Font = new System.Drawing.Font("Poppins", 13.5F);
            this.btn_ResetRecord.Appearance.Options.UseBackColor = true;
            this.btn_ResetRecord.Appearance.Options.UseFont = true;
            this.btn_ResetRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ResetRecord.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_ResetRecord.ImageOptions.ImageToTextIndent = 22;
            this.btn_ResetRecord.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_ResetRecord.ImageOptions.SvgImage")));
            this.btn_ResetRecord.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btn_ResetRecord.Location = new System.Drawing.Point(2, 2);
            this.btn_ResetRecord.Name = "btn_ResetRecord";
            this.btn_ResetRecord.Size = new System.Drawing.Size(178, 38);
            this.btn_ResetRecord.TabIndex = 0;
            this.btn_ResetRecord.Text = "Reset Record";
            this.btn_ResetRecord.Click += new System.EventHandler(this.btn_ResetRecord_Click);
            // 
            // gc_AttendanceRecord
            // 
            this.gc_AttendanceRecord.Location = new System.Drawing.Point(16, 266);
            this.gc_AttendanceRecord.MainView = this.gv_AttendanceRecord;
            this.gc_AttendanceRecord.Name = "gc_AttendanceRecord";
            this.gc_AttendanceRecord.Size = new System.Drawing.Size(648, 310);
            this.gc_AttendanceRecord.TabIndex = 8;
            this.gc_AttendanceRecord.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_AttendanceRecord});
            this.gc_AttendanceRecord.Load += new System.EventHandler(this.gc_AttendanceRecord_Load);
            // 
            // gv_AttendanceRecord
            // 
            this.gv_AttendanceRecord.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdclm_AttendanceName,
            this.grdclm_LogType,
            this.grdclm_TimeStamp});
            this.gv_AttendanceRecord.GridControl = this.gc_AttendanceRecord;
            this.gv_AttendanceRecord.Name = "gv_AttendanceRecord";
            this.gv_AttendanceRecord.OptionsView.ShowGroupPanel = false;
            // 
            // grdclm_AttendanceName
            // 
            this.grdclm_AttendanceName.Caption = "Name";
            this.grdclm_AttendanceName.FieldName = "AttendanceName";
            this.grdclm_AttendanceName.Name = "grdclm_AttendanceName";
            this.grdclm_AttendanceName.Visible = true;
            this.grdclm_AttendanceName.VisibleIndex = 0;
            // 
            // grdclm_LogType
            // 
            this.grdclm_LogType.Caption = "Log Type";
            this.grdclm_LogType.FieldName = "LogType";
            this.grdclm_LogType.Name = "grdclm_LogType";
            this.grdclm_LogType.Visible = true;
            this.grdclm_LogType.VisibleIndex = 2;
            // 
            // grdclm_TimeStamp
            // 
            this.grdclm_TimeStamp.Caption = "Time Stamp";
            this.grdclm_TimeStamp.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.grdclm_TimeStamp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.grdclm_TimeStamp.FieldName = "TimeStamp";
            this.grdclm_TimeStamp.Name = "grdclm_TimeStamp";
            this.grdclm_TimeStamp.Visible = true;
            this.grdclm_TimeStamp.VisibleIndex = 1;
            // 
            // panel_TotalAbsent
            // 
            this.panel_TotalAbsent.Appearance.BackColor = System.Drawing.Color.White;
            this.panel_TotalAbsent.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.panel_TotalAbsent.Appearance.Options.UseBackColor = true;
            this.panel_TotalAbsent.Appearance.Options.UseBorderColor = true;
            this.panel_TotalAbsent.Controls.Add(this.label_TotalAbsent);
            this.panel_TotalAbsent.Controls.Add(this.txt_TotalAbsent);
            this.panel_TotalAbsent.Location = new System.Drawing.Point(342, 106);
            this.panel_TotalAbsent.Name = "panel_TotalAbsent";
            this.panel_TotalAbsent.Size = new System.Drawing.Size(322, 154);
            this.panel_TotalAbsent.TabIndex = 6;
            // 
            // label_TotalAbsent
            // 
            this.label_TotalAbsent.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.label_TotalAbsent.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 12F);
            this.label_TotalAbsent.Appearance.Options.UseBackColor = true;
            this.label_TotalAbsent.Appearance.Options.UseFont = true;
            this.label_TotalAbsent.Location = new System.Drawing.Point(132, 95);
            this.label_TotalAbsent.Name = "label_TotalAbsent";
            this.label_TotalAbsent.Size = new System.Drawing.Size(58, 28);
            this.label_TotalAbsent.TabIndex = 2;
            this.label_TotalAbsent.Text = "Absent";
            // 
            // txt_TotalAbsent
            // 
            this.txt_TotalAbsent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_TotalAbsent.EditValue = "0";
            this.txt_TotalAbsent.Location = new System.Drawing.Point(2, 2);
            this.txt_TotalAbsent.Name = "txt_TotalAbsent";
            this.txt_TotalAbsent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.txt_TotalAbsent.Properties.Appearance.Font = new System.Drawing.Font("Poppins", 35.84F);
            this.txt_TotalAbsent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            this.txt_TotalAbsent.Properties.Appearance.Options.UseBackColor = true;
            this.txt_TotalAbsent.Properties.Appearance.Options.UseFont = true;
            this.txt_TotalAbsent.Properties.Appearance.Options.UseForeColor = true;
            this.txt_TotalAbsent.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_TotalAbsent.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_TotalAbsent.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            this.txt_TotalAbsent.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txt_TotalAbsent.Properties.AutoHeight = false;
            this.txt_TotalAbsent.Properties.ReadOnly = true;
            this.txt_TotalAbsent.Size = new System.Drawing.Size(318, 150);
            this.txt_TotalAbsent.TabIndex = 1;
            // 
            // panel_TotalPresent
            // 
            this.panel_TotalPresent.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.panel_TotalPresent.Appearance.Options.UseBackColor = true;
            this.panel_TotalPresent.Controls.Add(this.label_TotalPresent);
            this.panel_TotalPresent.Controls.Add(this.txt_TotalPresent);
            this.panel_TotalPresent.Location = new System.Drawing.Point(16, 106);
            this.panel_TotalPresent.Name = "panel_TotalPresent";
            this.panel_TotalPresent.Size = new System.Drawing.Size(320, 154);
            this.panel_TotalPresent.TabIndex = 5;
            // 
            // label_TotalPresent
            // 
            this.label_TotalPresent.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.label_TotalPresent.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 12F);
            this.label_TotalPresent.Appearance.Options.UseBackColor = true;
            this.label_TotalPresent.Appearance.Options.UseFont = true;
            this.label_TotalPresent.Location = new System.Drawing.Point(129, 95);
            this.label_TotalPresent.Name = "label_TotalPresent";
            this.label_TotalPresent.Size = new System.Drawing.Size(63, 28);
            this.label_TotalPresent.TabIndex = 1;
            this.label_TotalPresent.Text = "Present";
            // 
            // txt_TotalPresent
            // 
            this.txt_TotalPresent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_TotalPresent.EditValue = "0";
            this.txt_TotalPresent.Location = new System.Drawing.Point(2, 2);
            this.txt_TotalPresent.Name = "txt_TotalPresent";
            this.txt_TotalPresent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.txt_TotalPresent.Properties.Appearance.Font = new System.Drawing.Font("Poppins", 35.84F);
            this.txt_TotalPresent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(177)))), ((int)(((byte)(26)))));
            this.txt_TotalPresent.Properties.Appearance.Options.UseBackColor = true;
            this.txt_TotalPresent.Properties.Appearance.Options.UseFont = true;
            this.txt_TotalPresent.Properties.Appearance.Options.UseForeColor = true;
            this.txt_TotalPresent.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_TotalPresent.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_TotalPresent.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(177)))), ((int)(((byte)(26)))));
            this.txt_TotalPresent.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txt_TotalPresent.Properties.AutoHeight = false;
            this.txt_TotalPresent.Properties.ReadOnly = true;
            this.txt_TotalPresent.Size = new System.Drawing.Size(316, 150);
            this.txt_TotalPresent.TabIndex = 0;
            // 
            // panel_PageHeading
            // 
            this.panel_PageHeading.Controls.Add(this.icon_Student);
            this.panel_PageHeading.Controls.Add(this.btn_CloseForm);
            this.panel_PageHeading.Controls.Add(this.label_PageTitle);
            this.panel_PageHeading.Location = new System.Drawing.Point(16, 16);
            this.panel_PageHeading.Name = "panel_PageHeading";
            this.panel_PageHeading.Size = new System.Drawing.Size(648, 42);
            this.panel_PageHeading.TabIndex = 4;
            // 
            // icon_Student
            // 
            this.icon_Student.EditValue = ((object)(resources.GetObject("icon_Student.EditValue")));
            this.icon_Student.Location = new System.Drawing.Point(15, 8);
            this.icon_Student.Name = "icon_Student";
            this.icon_Student.Properties.AllowZoom = DevExpress.Utils.DefaultBoolean.True;
            this.icon_Student.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.icon_Student.Properties.Appearance.Options.UseBackColor = true;
            this.icon_Student.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.icon_Student.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.icon_Student.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.icon_Student.Properties.SvgImageSize = new System.Drawing.Size(14, 14);
            this.icon_Student.Size = new System.Drawing.Size(29, 28);
            this.icon_Student.TabIndex = 22;
            // 
            // btn_CloseForm
            // 
            this.btn_CloseForm.EditValue = ((object)(resources.GetObject("btn_CloseForm.EditValue")));
            this.btn_CloseForm.Location = new System.Drawing.Point(613, 7);
            this.btn_CloseForm.Name = "btn_CloseForm";
            this.btn_CloseForm.Properties.AllowZoom = DevExpress.Utils.DefaultBoolean.True;
            this.btn_CloseForm.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_CloseForm.Properties.Appearance.Options.UseBackColor = true;
            this.btn_CloseForm.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btn_CloseForm.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.btn_CloseForm.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.btn_CloseForm.Properties.SvgImageSize = new System.Drawing.Size(14, 14);
            this.btn_CloseForm.Size = new System.Drawing.Size(29, 28);
            this.btn_CloseForm.TabIndex = 21;
            this.btn_CloseForm.Click += new System.EventHandler(this.btn_CloseForm_Click);
            // 
            // label_PageTitle
            // 
            this.label_PageTitle.Appearance.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.label_PageTitle.Appearance.Options.UseFont = true;
            this.label_PageTitle.Location = new System.Drawing.Point(54, 8);
            this.label_PageTitle.Name = "label_PageTitle";
            this.label_PageTitle.Size = new System.Drawing.Size(231, 28);
            this.label_PageTitle.TabIndex = 0;
            this.label_PageTitle.Text = "Student Attendance Record";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_PageHeading,
            this.lci_TotalAbsent,
            this.lci_TotalPresent,
            this.lci_gridControl,
            this.emptySpaceItem,
            this.lci_ResetRecord,
            this.lci_StudentInfo});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(680, 640);
            this.Root.TextVisible = false;
            // 
            // lci_PageHeading
            // 
            this.lci_PageHeading.Control = this.panel_PageHeading;
            this.lci_PageHeading.Location = new System.Drawing.Point(0, 0);
            this.lci_PageHeading.Name = "lci_PageHeading";
            this.lci_PageHeading.Size = new System.Drawing.Size(654, 48);
            this.lci_PageHeading.TextSize = new System.Drawing.Size(0, 0);
            this.lci_PageHeading.TextVisible = false;
            // 
            // lci_TotalAbsent
            // 
            this.lci_TotalAbsent.Control = this.panel_TotalAbsent;
            this.lci_TotalAbsent.Location = new System.Drawing.Point(326, 90);
            this.lci_TotalAbsent.Name = "lci_TotalAbsent";
            this.lci_TotalAbsent.Size = new System.Drawing.Size(328, 160);
            this.lci_TotalAbsent.TextSize = new System.Drawing.Size(0, 0);
            this.lci_TotalAbsent.TextVisible = false;
            // 
            // lci_TotalPresent
            // 
            this.lci_TotalPresent.Control = this.panel_TotalPresent;
            this.lci_TotalPresent.Location = new System.Drawing.Point(0, 90);
            this.lci_TotalPresent.Name = "lci_TotalPresent";
            this.lci_TotalPresent.Size = new System.Drawing.Size(326, 160);
            this.lci_TotalPresent.TextSize = new System.Drawing.Size(0, 0);
            this.lci_TotalPresent.TextVisible = false;
            // 
            // lci_gridControl
            // 
            this.lci_gridControl.Control = this.gc_AttendanceRecord;
            this.lci_gridControl.Location = new System.Drawing.Point(0, 250);
            this.lci_gridControl.Name = "lci_gridControl";
            this.lci_gridControl.Size = new System.Drawing.Size(654, 316);
            this.lci_gridControl.TextSize = new System.Drawing.Size(0, 0);
            this.lci_gridControl.TextVisible = false;
            // 
            // emptySpaceItem
            // 
            this.emptySpaceItem.AllowHotTrack = false;
            this.emptySpaceItem.Location = new System.Drawing.Point(0, 566);
            this.emptySpaceItem.Name = "emptySpaceItem";
            this.emptySpaceItem.Size = new System.Drawing.Size(466, 48);
            this.emptySpaceItem.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lci_ResetRecord
            // 
            this.lci_ResetRecord.Control = this.panel_ResetRecord;
            this.lci_ResetRecord.Location = new System.Drawing.Point(466, 566);
            this.lci_ResetRecord.Name = "lci_ResetRecord";
            this.lci_ResetRecord.Size = new System.Drawing.Size(188, 48);
            this.lci_ResetRecord.TextSize = new System.Drawing.Size(0, 0);
            this.lci_ResetRecord.TextVisible = false;
            // 
            // lci_StudentInfo
            // 
            this.lci_StudentInfo.Control = this.panel_StudentInfo;
            this.lci_StudentInfo.Location = new System.Drawing.Point(0, 48);
            this.lci_StudentInfo.Name = "lci_StudentInfo";
            this.lci_StudentInfo.Size = new System.Drawing.Size(654, 42);
            this.lci_StudentInfo.TextSize = new System.Drawing.Size(0, 0);
            this.lci_StudentInfo.TextVisible = false;
            // 
            // StudentAttendanceRecord_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 640);
            this.Controls.Add(this.lc_StudentAttendanceRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentAttendanceRecord_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentAttendanceRecord_Form";
            this.Load += new System.EventHandler(this.StudentAttendanceRecord_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lc_StudentAttendanceRecord)).EndInit();
            this.lc_StudentAttendanceRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_StudentInfo)).EndInit();
            this.panel_StudentInfo.ResumeLayout(false);
            this.panel_StudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_ResetRecord)).EndInit();
            this.panel_ResetRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_AttendanceRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_AttendanceRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_TotalAbsent)).EndInit();
            this.panel_TotalAbsent.ResumeLayout(false);
            this.panel_TotalAbsent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TotalAbsent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_TotalPresent)).EndInit();
            this.panel_TotalPresent.ResumeLayout(false);
            this.panel_TotalPresent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TotalPresent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).EndInit();
            this.panel_PageHeading.ResumeLayout(false);
            this.panel_PageHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_Student.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseForm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_TotalAbsent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_TotalPresent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_ResetRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_StudentInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lc_StudentAttendanceRecord;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gc_AttendanceRecord;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_AttendanceRecord;
        private DevExpress.XtraEditors.PanelControl panel_TotalAbsent;
        private DevExpress.XtraEditors.PanelControl panel_TotalPresent;
        private DevExpress.XtraEditors.PanelControl panel_PageHeading;
        private DevExpress.XtraLayout.LayoutControlItem lci_PageHeading;
        private DevExpress.XtraLayout.LayoutControlItem lci_TotalAbsent;
        private DevExpress.XtraLayout.LayoutControlItem lci_TotalPresent;
        private DevExpress.XtraLayout.LayoutControlItem lci_gridControl;
        private DevExpress.XtraEditors.LabelControl label_PageTitle;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_AttendanceName;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_TimeStamp;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_LogType;
        private DevExpress.XtraEditors.PanelControl panel_ResetRecord;
        private DevExpress.XtraEditors.SimpleButton btn_ResetRecord;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem;
        private DevExpress.XtraLayout.LayoutControlItem lci_ResetRecord;
        private DevExpress.XtraEditors.TextEdit txt_TotalPresent;
        private DevExpress.XtraEditors.TextEdit txt_TotalAbsent;
        private DevExpress.XtraEditors.LabelControl label_TotalPresent;
        private DevExpress.XtraEditors.LabelControl label_TotalAbsent;
        private DevExpress.XtraEditors.PictureEdit btn_CloseForm;
        private DevExpress.XtraEditors.PictureEdit icon_Student;
        private DevExpress.XtraEditors.PanelControl panel_StudentInfo;
        private DevExpress.XtraLayout.LayoutControlItem lci_StudentInfo;
        private DevExpress.XtraEditors.LabelControl label_Name;
        private DevExpress.XtraEditors.LabelControl txt_Name;
        private DevExpress.XtraEditors.LabelControl txt_SchoolStudentId;
        private DevExpress.XtraEditors.LabelControl label_SchoolStudentId;
    }
}
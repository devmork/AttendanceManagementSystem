namespace AttendanceManagementSystem.Forms.Reports
{
    partial class AllAttendanceRecord_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllAttendanceRecord_Form));
            this.lci_AllAttendanceReport = new DevExpress.XtraLayout.LayoutControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Report = new DevExpress.XtraEditors.SimpleButton();
            this.panel_FilterYearLevel = new DevExpress.XtraEditors.PanelControl();
            this.cbe_FilterYearLevel = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panel_FilterCourse = new DevExpress.XtraEditors.PanelControl();
            this.cbe_FilterCourse = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panel_AllAttendanceReport = new DevExpress.XtraEditors.PanelControl();
            this.label_PageDescription = new DevExpress.XtraEditors.LabelControl();
            this.btn_CloseForm = new DevExpress.XtraEditors.PictureEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lci_FormHeader = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_FilterCourse = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_FilterYearLevel = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_ReportButton = new DevExpress.XtraLayout.LayoutControlItem();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lci_AllAttendanceReport)).BeginInit();
            this.lci_AllAttendanceReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_FilterYearLevel)).BeginInit();
            this.panel_FilterYearLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_FilterYearLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_FilterCourse)).BeginInit();
            this.panel_FilterCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_FilterCourse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_AllAttendanceReport)).BeginInit();
            this.panel_AllAttendanceReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseForm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_FormHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_FilterCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_FilterYearLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_ReportButton)).BeginInit();
            this.SuspendLayout();
            // 
            // lci_AllAttendanceReport
            // 
            this.lci_AllAttendanceReport.Controls.Add(this.panelControl4);
            this.lci_AllAttendanceReport.Controls.Add(this.panel_FilterYearLevel);
            this.lci_AllAttendanceReport.Controls.Add(this.panel_FilterCourse);
            this.lci_AllAttendanceReport.Controls.Add(this.panel_AllAttendanceReport);
            this.lci_AllAttendanceReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lci_AllAttendanceReport.Location = new System.Drawing.Point(0, 0);
            this.lci_AllAttendanceReport.Name = "lci_AllAttendanceReport";
            this.lci_AllAttendanceReport.Root = this.Root;
            this.lci_AllAttendanceReport.Size = new System.Drawing.Size(790, 226);
            this.lci_AllAttendanceReport.TabIndex = 0;
            this.lci_AllAttendanceReport.Text = "layoutControl1";
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.btn_Cancel);
            this.panelControl4.Controls.Add(this.btn_Report);
            this.panelControl4.Location = new System.Drawing.Point(16, 135);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(758, 75);
            this.panelControl4.TabIndex = 6;
            // 
            // btn_Report
            // 
            this.btn_Report.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Report.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(182)))), ((int)(((byte)(125)))));
            this.btn_Report.Appearance.Font = new System.Drawing.Font("Poppins", 12.08F);
            this.btn_Report.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_Report.Appearance.Options.UseBackColor = true;
            this.btn_Report.Appearance.Options.UseFont = true;
            this.btn_Report.Appearance.Options.UseForeColor = true;
            this.btn_Report.Appearance.Options.UseTextOptions = true;
            this.btn_Report.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_Report.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btn_Report.ImageOptions.SvgImageSize = new System.Drawing.Size(26, 26);
            this.btn_Report.Location = new System.Drawing.Point(509, 11);
            this.btn_Report.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btn_Report.Size = new System.Drawing.Size(234, 50);
            this.btn_Report.TabIndex = 14;
            this.btn_Report.Text = "Report";
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // panel_FilterYearLevel
            // 
            this.panel_FilterYearLevel.Controls.Add(this.cbe_FilterYearLevel);
            this.panel_FilterYearLevel.Location = new System.Drawing.Point(397, 75);
            this.panel_FilterYearLevel.Name = "panel_FilterYearLevel";
            this.panel_FilterYearLevel.Size = new System.Drawing.Size(377, 54);
            this.panel_FilterYearLevel.TabIndex = 0;
            // 
            // cbe_FilterYearLevel
            // 
            this.cbe_FilterYearLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbe_FilterYearLevel.Location = new System.Drawing.Point(2, 2);
            this.cbe_FilterYearLevel.Name = "cbe_FilterYearLevel";
            this.cbe_FilterYearLevel.Properties.AutoHeight = false;
            this.cbe_FilterYearLevel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbe_FilterYearLevel.Properties.Items.AddRange(new object[] {
            "All Year Level",
            "1",
            "2",
            "3",
            "4"});
            this.cbe_FilterYearLevel.Size = new System.Drawing.Size(373, 50);
            this.cbe_FilterYearLevel.TabIndex = 1;
            // 
            // panel_FilterCourse
            // 
            this.panel_FilterCourse.Controls.Add(this.cbe_FilterCourse);
            this.panel_FilterCourse.Location = new System.Drawing.Point(16, 75);
            this.panel_FilterCourse.Name = "panel_FilterCourse";
            this.panel_FilterCourse.Size = new System.Drawing.Size(375, 54);
            this.panel_FilterCourse.TabIndex = 5;
            // 
            // cbe_FilterCourse
            // 
            this.cbe_FilterCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbe_FilterCourse.Location = new System.Drawing.Point(2, 2);
            this.cbe_FilterCourse.Name = "cbe_FilterCourse";
            this.cbe_FilterCourse.Properties.AutoHeight = false;
            this.cbe_FilterCourse.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbe_FilterCourse.Properties.Items.AddRange(new object[] {
            "All Courses",
            "BSN",
            "BSMT",
            "BS-RADTECH",
            "BS-PHARMA",
            "BSPT",
            "BSIT",
            "BSHM",
            "BSBA",
            "BSED"});
            this.cbe_FilterCourse.Size = new System.Drawing.Size(371, 50);
            this.cbe_FilterCourse.TabIndex = 0;
            // 
            // panel_AllAttendanceReport
            // 
            this.panel_AllAttendanceReport.Controls.Add(this.label_PageDescription);
            this.panel_AllAttendanceReport.Controls.Add(this.btn_CloseForm);
            this.panel_AllAttendanceReport.Location = new System.Drawing.Point(16, 16);
            this.panel_AllAttendanceReport.Name = "panel_AllAttendanceReport";
            this.panel_AllAttendanceReport.Size = new System.Drawing.Size(758, 53);
            this.panel_AllAttendanceReport.TabIndex = 4;
            // 
            // label_PageDescription
            // 
            this.label_PageDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_PageDescription.Appearance.Font = new System.Drawing.Font("Poppins", 12F);
            this.label_PageDescription.Appearance.Options.UseFont = true;
            this.label_PageDescription.Location = new System.Drawing.Point(15, 12);
            this.label_PageDescription.Margin = new System.Windows.Forms.Padding(4);
            this.label_PageDescription.Name = "label_PageDescription";
            this.label_PageDescription.Size = new System.Drawing.Size(193, 28);
            this.label_PageDescription.TabIndex = 22;
            this.label_PageDescription.Text = "Filter attendnace report.";
            // 
            // btn_CloseForm
            // 
            this.btn_CloseForm.EditValue = ((object)(resources.GetObject("btn_CloseForm.EditValue")));
            this.btn_CloseForm.Location = new System.Drawing.Point(713, 5);
            this.btn_CloseForm.Name = "btn_CloseForm";
            this.btn_CloseForm.Properties.AllowZoom = DevExpress.Utils.DefaultBoolean.True;
            this.btn_CloseForm.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_CloseForm.Properties.Appearance.Options.UseBackColor = true;
            this.btn_CloseForm.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btn_CloseForm.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.btn_CloseForm.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.btn_CloseForm.Properties.SvgImageSize = new System.Drawing.Size(14, 14);
            this.btn_CloseForm.Size = new System.Drawing.Size(41, 35);
            this.btn_CloseForm.TabIndex = 21;
            this.btn_CloseForm.Click += new System.EventHandler(this.btn_CloseForm_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_FormHeader,
            this.lci_FilterCourse,
            this.lci_FilterYearLevel,
            this.lci_ReportButton});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(790, 226);
            this.Root.TextVisible = false;
            // 
            // lci_FormHeader
            // 
            this.lci_FormHeader.Control = this.panel_AllAttendanceReport;
            this.lci_FormHeader.Location = new System.Drawing.Point(0, 0);
            this.lci_FormHeader.Name = "lci_FormHeader";
            this.lci_FormHeader.Size = new System.Drawing.Size(764, 59);
            this.lci_FormHeader.TextSize = new System.Drawing.Size(0, 0);
            this.lci_FormHeader.TextVisible = false;
            // 
            // lci_FilterCourse
            // 
            this.lci_FilterCourse.Control = this.panel_FilterCourse;
            this.lci_FilterCourse.Location = new System.Drawing.Point(0, 59);
            this.lci_FilterCourse.Name = "lci_FilterCourse";
            this.lci_FilterCourse.Size = new System.Drawing.Size(381, 60);
            this.lci_FilterCourse.TextSize = new System.Drawing.Size(0, 0);
            this.lci_FilterCourse.TextVisible = false;
            // 
            // lci_FilterYearLevel
            // 
            this.lci_FilterYearLevel.Control = this.panel_FilterYearLevel;
            this.lci_FilterYearLevel.Location = new System.Drawing.Point(381, 59);
            this.lci_FilterYearLevel.Name = "lci_FilterYearLevel";
            this.lci_FilterYearLevel.Size = new System.Drawing.Size(383, 60);
            this.lci_FilterYearLevel.TextSize = new System.Drawing.Size(0, 0);
            this.lci_FilterYearLevel.TextVisible = false;
            // 
            // lci_ReportButton
            // 
            this.lci_ReportButton.Control = this.panelControl4;
            this.lci_ReportButton.Location = new System.Drawing.Point(0, 119);
            this.lci_ReportButton.Name = "lci_ReportButton";
            this.lci_ReportButton.Size = new System.Drawing.Size(764, 81);
            this.lci_ReportButton.TextSize = new System.Drawing.Size(0, 0);
            this.lci_ReportButton.TextVisible = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.Appearance.BackColor = System.Drawing.Color.White;
            this.btn_Cancel.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(182)))), ((int)(((byte)(125)))));
            this.btn_Cancel.Appearance.Font = new System.Drawing.Font("Poppins", 12.08F);
            this.btn_Cancel.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btn_Cancel.Appearance.Options.UseBackColor = true;
            this.btn_Cancel.Appearance.Options.UseBorderColor = true;
            this.btn_Cancel.Appearance.Options.UseFont = true;
            this.btn_Cancel.Appearance.Options.UseForeColor = true;
            this.btn_Cancel.Appearance.Options.UseTextOptions = true;
            this.btn_Cancel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_Cancel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btn_Cancel.ImageOptions.SvgImageSize = new System.Drawing.Size(26, 26);
            this.btn_Cancel.Location = new System.Drawing.Point(262, 11);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btn_Cancel.Size = new System.Drawing.Size(234, 50);
            this.btn_Cancel.TabIndex = 15;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // AllAttendanceRecord_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 226);
            this.Controls.Add(this.lci_AllAttendanceReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllAttendanceRecord_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllAttendanceRecord";
            ((System.ComponentModel.ISupportInitialize)(this.lci_AllAttendanceReport)).EndInit();
            this.lci_AllAttendanceReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_FilterYearLevel)).EndInit();
            this.panel_FilterYearLevel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbe_FilterYearLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_FilterCourse)).EndInit();
            this.panel_FilterCourse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbe_FilterCourse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_AllAttendanceReport)).EndInit();
            this.panel_AllAttendanceReport.ResumeLayout(false);
            this.panel_AllAttendanceReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseForm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_FormHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_FilterCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_FilterYearLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_ReportButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lci_AllAttendanceReport;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.PanelControl panel_FilterYearLevel;
        private DevExpress.XtraEditors.PanelControl panel_FilterCourse;
        private DevExpress.XtraEditors.ComboBoxEdit cbe_FilterCourse;
        private DevExpress.XtraEditors.PanelControl panel_AllAttendanceReport;
        private DevExpress.XtraLayout.LayoutControlItem lci_FormHeader;
        private DevExpress.XtraLayout.LayoutControlItem lci_FilterCourse;
        private DevExpress.XtraLayout.LayoutControlItem lci_FilterYearLevel;
        private DevExpress.XtraEditors.ComboBoxEdit cbe_FilterYearLevel;
        private DevExpress.XtraEditors.PictureEdit btn_CloseForm;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraLayout.LayoutControlItem lci_ReportButton;
        private DevExpress.XtraEditors.LabelControl label_PageDescription;
        private DevExpress.XtraEditors.SimpleButton btn_Report;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
    }
}
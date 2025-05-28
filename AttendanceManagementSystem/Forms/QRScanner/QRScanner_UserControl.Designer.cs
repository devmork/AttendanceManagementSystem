namespace AttendanceManagementSystem.Forms.QRScanner
{
    partial class QRScanner_UserControl
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
            this.lc_QRScanner = new DevExpress.XtraLayout.LayoutControl();
            this.panel_StartScan = new DevExpress.XtraEditors.PanelControl();
            this.btn_StartScan = new DevExpress.XtraEditors.SimpleButton();
            this.lci_RightPanel = new DevExpress.XtraLayout.LayoutControl();
            this.panel_QRCodeValue = new DevExpress.XtraEditors.PanelControl();
            this.txt_QRValue = new DevExpress.XtraEditors.LabelControl();
            this.cbe_ChooseAttendance = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lcg = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lci_AttendanceList = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_QRCodeValue = new DevExpress.XtraLayout.LayoutControlItem();
            this.panel_StopScan = new DevExpress.XtraEditors.PanelControl();
            this.btn_StopScan = new DevExpress.XtraEditors.SimpleButton();
            this.panel_Details = new DevExpress.XtraEditors.PanelControl();
            this.panel_Camera = new DevExpress.XtraEditors.PanelControl();
            this.pe_QRCamera = new DevExpress.XtraEditors.PictureEdit();
            this.panel_PageHeading = new DevExpress.XtraEditors.PanelControl();
            this.label_PageTitle = new DevExpress.XtraEditors.LabelControl();
            this.label_PageDescription = new DevExpress.XtraEditors.LabelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lci_PageHeading = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_Camera = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_Details = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_StopScan = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_StartScan = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lc_QRScanner)).BeginInit();
            this.lc_QRScanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_StartScan)).BeginInit();
            this.panel_StartScan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lci_RightPanel)).BeginInit();
            this.lci_RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_QRCodeValue)).BeginInit();
            this.panel_QRCodeValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_ChooseAttendance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_AttendanceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_QRCodeValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_StopScan)).BeginInit();
            this.panel_StopScan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Details)).BeginInit();
            this.panel_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Camera)).BeginInit();
            this.panel_Camera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pe_QRCamera.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).BeginInit();
            this.panel_PageHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_Camera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_StopScan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_StartScan)).BeginInit();
            this.SuspendLayout();
            // 
            // lc_QRScanner
            // 
            this.lc_QRScanner.Controls.Add(this.panel_StartScan);
            this.lc_QRScanner.Controls.Add(this.panel_StopScan);
            this.lc_QRScanner.Controls.Add(this.panel_Details);
            this.lc_QRScanner.Controls.Add(this.panel_Camera);
            this.lc_QRScanner.Controls.Add(this.panel_PageHeading);
            this.lc_QRScanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_QRScanner.Location = new System.Drawing.Point(0, 0);
            this.lc_QRScanner.Name = "lc_QRScanner";
            this.lc_QRScanner.Root = this.Root;
            this.lc_QRScanner.Size = new System.Drawing.Size(1440, 1024);
            this.lc_QRScanner.TabIndex = 0;
            this.lc_QRScanner.Text = "layoutControl1";
            // 
            // panel_StartScan
            // 
            this.panel_StartScan.Controls.Add(this.btn_StartScan);
            this.panel_StartScan.Location = new System.Drawing.Point(1097, 966);
            this.panel_StartScan.Name = "panel_StartScan";
            this.panel_StartScan.Size = new System.Drawing.Size(327, 42);
            this.panel_StartScan.TabIndex = 10;
            // 
            // btn_StartScan
            // 
            this.btn_StartScan.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(182)))), ((int)(((byte)(125)))));
            this.btn_StartScan.Appearance.Font = new System.Drawing.Font("Poppins", 13.5F);
            this.btn_StartScan.Appearance.Options.UseBackColor = true;
            this.btn_StartScan.Appearance.Options.UseFont = true;
            this.btn_StartScan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_StartScan.Location = new System.Drawing.Point(2, 2);
            this.btn_StartScan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_StartScan.Name = "btn_StartScan";
            this.btn_StartScan.Size = new System.Drawing.Size(323, 38);
            this.btn_StartScan.StyleController = this.lci_RightPanel;
            this.btn_StartScan.TabIndex = 9;
            this.btn_StartScan.Text = "Start Scan";
            this.btn_StartScan.Click += new System.EventHandler(this.btn_StartScan_Click);
            // 
            // lci_RightPanel
            // 
            this.lci_RightPanel.Controls.Add(this.panel_QRCodeValue);
            this.lci_RightPanel.Controls.Add(this.cbe_ChooseAttendance);
            this.lci_RightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lci_RightPanel.Location = new System.Drawing.Point(2, 2);
            this.lci_RightPanel.Name = "lci_RightPanel";
            this.lci_RightPanel.Root = this.lcg;
            this.lci_RightPanel.Size = new System.Drawing.Size(633, 832);
            this.lci_RightPanel.TabIndex = 0;
            this.lci_RightPanel.Text = "layoutControl1";
            // 
            // panel_QRCodeValue
            // 
            this.panel_QRCodeValue.Controls.Add(this.txt_QRValue);
            this.panel_QRCodeValue.Location = new System.Drawing.Point(3, 43);
            this.panel_QRCodeValue.Name = "panel_QRCodeValue";
            this.panel_QRCodeValue.Size = new System.Drawing.Size(627, 786);
            this.panel_QRCodeValue.TabIndex = 6;
            // 
            // txt_QRValue
            // 
            this.txt_QRValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_QRValue.Appearance.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_QRValue.Appearance.Options.UseFont = true;
            this.txt_QRValue.Appearance.Options.UseTextOptions = true;
            this.txt_QRValue.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_QRValue.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txt_QRValue.Location = new System.Drawing.Point(191, 375);
            this.txt_QRValue.Name = "txt_QRValue";
            this.txt_QRValue.Size = new System.Drawing.Size(155, 37);
            this.txt_QRValue.TabIndex = 0;
            this.txt_QRValue.Text = "Start Scanning";
            // 
            // cbe_ChooseAttendance
            // 
            this.cbe_ChooseAttendance.EditValue = "Choose Attendance";
            this.cbe_ChooseAttendance.Location = new System.Drawing.Point(3, 3);
            this.cbe_ChooseAttendance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbe_ChooseAttendance.Name = "cbe_ChooseAttendance";
            this.cbe_ChooseAttendance.Properties.Appearance.Options.UseTextOptions = true;
            this.cbe_ChooseAttendance.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbe_ChooseAttendance.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbe_ChooseAttendance.Size = new System.Drawing.Size(627, 34);
            this.cbe_ChooseAttendance.StyleController = this.lci_RightPanel;
            this.cbe_ChooseAttendance.TabIndex = 5;
            this.cbe_ChooseAttendance.SelectedIndexChanged += new System.EventHandler(this.cbe_ChooseAttendance_SelectedIndexChanged);
            // 
            // lcg
            // 
            this.lcg.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcg.GroupBordersVisible = false;
            this.lcg.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_AttendanceList,
            this.lci_QRCodeValue});
            this.lcg.Name = "lcg";
            this.lcg.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcg.Size = new System.Drawing.Size(633, 832);
            this.lcg.TextVisible = false;
            // 
            // lci_AttendanceList
            // 
            this.lci_AttendanceList.Control = this.cbe_ChooseAttendance;
            this.lci_AttendanceList.Location = new System.Drawing.Point(0, 0);
            this.lci_AttendanceList.Name = "lci_AttendanceList";
            this.lci_AttendanceList.Size = new System.Drawing.Size(633, 40);
            this.lci_AttendanceList.TextSize = new System.Drawing.Size(0, 0);
            this.lci_AttendanceList.TextVisible = false;
            // 
            // lci_QRCodeValue
            // 
            this.lci_QRCodeValue.Control = this.panel_QRCodeValue;
            this.lci_QRCodeValue.Location = new System.Drawing.Point(0, 40);
            this.lci_QRCodeValue.Name = "lci_QRCodeValue";
            this.lci_QRCodeValue.Size = new System.Drawing.Size(633, 792);
            this.lci_QRCodeValue.TextSize = new System.Drawing.Size(0, 0);
            this.lci_QRCodeValue.TextVisible = false;
            // 
            // panel_StopScan
            // 
            this.panel_StopScan.Controls.Add(this.btn_StopScan);
            this.panel_StopScan.Location = new System.Drawing.Point(787, 966);
            this.panel_StopScan.Name = "panel_StopScan";
            this.panel_StopScan.Size = new System.Drawing.Size(304, 42);
            this.panel_StopScan.TabIndex = 9;
            // 
            // btn_StopScan
            // 
            this.btn_StopScan.Appearance.BackColor = System.Drawing.Color.Red;
            this.btn_StopScan.Appearance.Font = new System.Drawing.Font("Poppins", 13.5F);
            this.btn_StopScan.Appearance.Options.UseBackColor = true;
            this.btn_StopScan.Appearance.Options.UseFont = true;
            this.btn_StopScan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_StopScan.Location = new System.Drawing.Point(2, 2);
            this.btn_StopScan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_StopScan.Name = "btn_StopScan";
            this.btn_StopScan.Size = new System.Drawing.Size(300, 38);
            this.btn_StopScan.StyleController = this.lci_RightPanel;
            this.btn_StopScan.TabIndex = 7;
            this.btn_StopScan.Text = "Stop Scan";
            this.btn_StopScan.Click += new System.EventHandler(this.btn_StopScan_Click);
            // 
            // panel_Details
            // 
            this.panel_Details.Controls.Add(this.lci_RightPanel);
            this.panel_Details.Location = new System.Drawing.Point(787, 124);
            this.panel_Details.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Details.Name = "panel_Details";
            this.panel_Details.Size = new System.Drawing.Size(637, 836);
            this.panel_Details.TabIndex = 0;
            // 
            // panel_Camera
            // 
            this.panel_Camera.Controls.Add(this.pe_QRCamera);
            this.panel_Camera.Location = new System.Drawing.Point(16, 124);
            this.panel_Camera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Camera.Name = "panel_Camera";
            this.panel_Camera.Size = new System.Drawing.Size(765, 884);
            this.panel_Camera.TabIndex = 8;
            // 
            // pe_QRCamera
            // 
            this.pe_QRCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pe_QRCamera.Location = new System.Drawing.Point(2, 2);
            this.pe_QRCamera.Name = "pe_QRCamera";
            this.pe_QRCamera.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pe_QRCamera.Size = new System.Drawing.Size(761, 880);
            this.pe_QRCamera.TabIndex = 2;
            // 
            // panel_PageHeading
            // 
            this.panel_PageHeading.Controls.Add(this.label_PageTitle);
            this.panel_PageHeading.Controls.Add(this.label_PageDescription);
            this.panel_PageHeading.Location = new System.Drawing.Point(16, 16);
            this.panel_PageHeading.Name = "panel_PageHeading";
            this.panel_PageHeading.Size = new System.Drawing.Size(1408, 102);
            this.panel_PageHeading.TabIndex = 7;
            // 
            // label_PageTitle
            // 
            this.label_PageTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_PageTitle.Appearance.Font = new System.Drawing.Font("Poppins", 17.71F, System.Drawing.FontStyle.Bold);
            this.label_PageTitle.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.label_PageTitle.Appearance.Options.UseFont = true;
            this.label_PageTitle.Location = new System.Drawing.Point(31, 19);
            this.label_PageTitle.Margin = new System.Windows.Forms.Padding(4);
            this.label_PageTitle.Name = "label_PageTitle";
            this.label_PageTitle.Size = new System.Drawing.Size(142, 42);
            this.label_PageTitle.TabIndex = 0;
            this.label_PageTitle.Text = "QR Scanner";
            // 
            // label_PageDescription
            // 
            this.label_PageDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_PageDescription.Appearance.Font = new System.Drawing.Font("Poppins", 12F);
            this.label_PageDescription.Appearance.Options.UseFont = true;
            this.label_PageDescription.Location = new System.Drawing.Point(31, 55);
            this.label_PageDescription.Margin = new System.Windows.Forms.Padding(4);
            this.label_PageDescription.Name = "label_PageDescription";
            this.label_PageDescription.Size = new System.Drawing.Size(469, 28);
            this.label_PageDescription.TabIndex = 1;
            this.label_PageDescription.Text = "Record student attendance by scanning student QR codes.";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_PageHeading,
            this.lci_Camera,
            this.lci_Details,
            this.lci_StopScan,
            this.lci_StartScan});
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
            this.lci_PageHeading.Size = new System.Drawing.Size(1414, 108);
            this.lci_PageHeading.Text = "layoutControlItem1";
            this.lci_PageHeading.TextSize = new System.Drawing.Size(0, 0);
            this.lci_PageHeading.TextVisible = false;
            // 
            // lci_Camera
            // 
            this.lci_Camera.Control = this.panel_Camera;
            this.lci_Camera.Location = new System.Drawing.Point(0, 108);
            this.lci_Camera.Name = "lci_Camera";
            this.lci_Camera.Size = new System.Drawing.Size(771, 890);
            this.lci_Camera.TextSize = new System.Drawing.Size(0, 0);
            this.lci_Camera.TextVisible = false;
            // 
            // lci_Details
            // 
            this.lci_Details.Control = this.panel_Details;
            this.lci_Details.Location = new System.Drawing.Point(771, 108);
            this.lci_Details.Name = "lci_Details";
            this.lci_Details.Size = new System.Drawing.Size(643, 842);
            this.lci_Details.TextSize = new System.Drawing.Size(0, 0);
            this.lci_Details.TextVisible = false;
            // 
            // lci_StopScan
            // 
            this.lci_StopScan.Control = this.panel_StopScan;
            this.lci_StopScan.Location = new System.Drawing.Point(771, 950);
            this.lci_StopScan.Name = "lci_StopScan";
            this.lci_StopScan.Size = new System.Drawing.Size(310, 48);
            this.lci_StopScan.TextSize = new System.Drawing.Size(0, 0);
            this.lci_StopScan.TextVisible = false;
            // 
            // lci_StartScan
            // 
            this.lci_StartScan.Control = this.panel_StartScan;
            this.lci_StartScan.Location = new System.Drawing.Point(1081, 950);
            this.lci_StartScan.Name = "lci_StartScan";
            this.lci_StartScan.Size = new System.Drawing.Size(333, 48);
            this.lci_StartScan.TextSize = new System.Drawing.Size(0, 0);
            this.lci_StartScan.TextVisible = false;
            // 
            // QRScanner_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lc_QRScanner);
            this.Name = "QRScanner_UserControl";
            this.Size = new System.Drawing.Size(1440, 1024);
            this.Load += new System.EventHandler(this.QRScanner_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lc_QRScanner)).EndInit();
            this.lc_QRScanner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_StartScan)).EndInit();
            this.panel_StartScan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lci_RightPanel)).EndInit();
            this.lci_RightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_QRCodeValue)).EndInit();
            this.panel_QRCodeValue.ResumeLayout(false);
            this.panel_QRCodeValue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_ChooseAttendance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_AttendanceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_QRCodeValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_StopScan)).EndInit();
            this.panel_StopScan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_Details)).EndInit();
            this.panel_Details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_Camera)).EndInit();
            this.panel_Camera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pe_QRCamera.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).EndInit();
            this.panel_PageHeading.ResumeLayout(false);
            this.panel_PageHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_Camera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_StopScan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_StartScan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lc_QRScanner;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.PanelControl panel_PageHeading;
        private DevExpress.XtraEditors.LabelControl label_PageTitle;
        private DevExpress.XtraEditors.LabelControl label_PageDescription;
        private DevExpress.XtraLayout.LayoutControlItem lci_PageHeading;
        private DevExpress.XtraEditors.PanelControl panel_StartScan;
        private DevExpress.XtraEditors.SimpleButton btn_StartScan;
        private DevExpress.XtraEditors.PanelControl panel_StopScan;
        private DevExpress.XtraEditors.SimpleButton btn_StopScan;
        private DevExpress.XtraLayout.LayoutControlItem lci_StopScan;
        private DevExpress.XtraLayout.LayoutControlItem lci_StartScan;
        private DevExpress.XtraEditors.LabelControl txt_QRValue;
        private DevExpress.XtraEditors.PanelControl panel_Camera;
        private DevExpress.XtraEditors.PictureEdit pe_QRCamera;
        private DevExpress.XtraLayout.LayoutControlItem lci_Camera;
        private DevExpress.XtraEditors.ComboBoxEdit cbe_ChooseAttendance;
        private DevExpress.XtraLayout.LayoutControl lci_RightPanel;
        private DevExpress.XtraLayout.LayoutControlGroup lcg;
        private DevExpress.XtraLayout.LayoutControlItem lci_AttendanceList;
        private DevExpress.XtraEditors.PanelControl panel_Details;
        private DevExpress.XtraLayout.LayoutControlItem lci_Details;
        private DevExpress.XtraEditors.PanelControl panel_QRCodeValue;
        private DevExpress.XtraLayout.LayoutControlItem lci_QRCodeValue;
    }
}

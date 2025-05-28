namespace AttendanceManagementSystem.Forms.Events
{
    partial class Attendance_UserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendance_UserControl));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.lc_Attendance = new DevExpress.XtraLayout.LayoutControl();
            this.panel_PageHeading = new DevExpress.XtraEditors.PanelControl();
            this.btn_AddAttendance = new DevExpress.XtraEditors.SimpleButton();
            this.label_PageTitle = new DevExpress.XtraEditors.LabelControl();
            this.label_PageDescription = new DevExpress.XtraEditors.LabelControl();
            this.gc_Attendance = new DevExpress.XtraGrid.GridControl();
            this.gv_Attendance = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdclm_AttendanceId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_AttendanceName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_AttendanceLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_LogType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_AttendanceDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_StartTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_EndTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit_Status = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.grdclm_Action = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItem_ActionButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lci_PageHeading = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_PanelBody = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lc_Attendance)).BeginInit();
            this.lc_Attendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).BeginInit();
            this.panel_PageHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Attendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Attendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit_Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItem_ActionButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PanelBody)).BeginInit();
            this.SuspendLayout();
            // 
            // lc_Attendance
            // 
            this.lc_Attendance.Controls.Add(this.panel_PageHeading);
            this.lc_Attendance.Controls.Add(this.gc_Attendance);
            this.lc_Attendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_Attendance.Location = new System.Drawing.Point(0, 0);
            this.lc_Attendance.Name = "lc_Attendance";
            this.lc_Attendance.Root = this.Root;
            this.lc_Attendance.Size = new System.Drawing.Size(1440, 1024);
            this.lc_Attendance.TabIndex = 0;
            this.lc_Attendance.Text = "layoutControl1";
            // 
            // panel_PageHeading
            // 
            this.panel_PageHeading.Controls.Add(this.btn_AddAttendance);
            this.panel_PageHeading.Controls.Add(this.label_PageTitle);
            this.panel_PageHeading.Controls.Add(this.label_PageDescription);
            this.panel_PageHeading.Location = new System.Drawing.Point(16, 16);
            this.panel_PageHeading.Name = "panel_PageHeading";
            this.panel_PageHeading.Size = new System.Drawing.Size(1408, 102);
            this.panel_PageHeading.TabIndex = 7;
            // 
            // btn_AddAttendance
            // 
            this.btn_AddAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddAttendance.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(182)))), ((int)(((byte)(125)))));
            this.btn_AddAttendance.Appearance.Font = new System.Drawing.Font("Poppins", 12.08F);
            this.btn_AddAttendance.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_AddAttendance.Appearance.Options.UseBackColor = true;
            this.btn_AddAttendance.Appearance.Options.UseFont = true;
            this.btn_AddAttendance.Appearance.Options.UseForeColor = true;
            this.btn_AddAttendance.Appearance.Options.UseTextOptions = true;
            this.btn_AddAttendance.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_AddAttendance.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btn_AddAttendance.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_AddAttendance.ImageOptions.SvgImage")));
            this.btn_AddAttendance.ImageOptions.SvgImageSize = new System.Drawing.Size(26, 26);
            this.btn_AddAttendance.Location = new System.Drawing.Point(1156, 26);
            this.btn_AddAttendance.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AddAttendance.Name = "btn_AddAttendance";
            this.btn_AddAttendance.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btn_AddAttendance.Size = new System.Drawing.Size(236, 56);
            this.btn_AddAttendance.TabIndex = 3;
            this.btn_AddAttendance.Text = "Add Attendance";
            this.btn_AddAttendance.Click += new System.EventHandler(this.btn_AddAttendance_Click);
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
            this.label_PageTitle.Size = new System.Drawing.Size(147, 42);
            this.label_PageTitle.TabIndex = 0;
            this.label_PageTitle.Text = "Attendance";
            // 
            // label_PageDescription
            // 
            this.label_PageDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_PageDescription.Appearance.Font = new System.Drawing.Font("Poppins", 12F);
            this.label_PageDescription.Appearance.Options.UseFont = true;
            this.label_PageDescription.Location = new System.Drawing.Point(31, 58);
            this.label_PageDescription.Margin = new System.Windows.Forms.Padding(4);
            this.label_PageDescription.Name = "label_PageDescription";
            this.label_PageDescription.Size = new System.Drawing.Size(305, 28);
            this.label_PageDescription.TabIndex = 1;
            this.label_PageDescription.Text = "View and manage school attendance.";
            // 
            // gc_Attendance
            // 
            this.gc_Attendance.Location = new System.Drawing.Point(16, 124);
            this.gc_Attendance.MainView = this.gv_Attendance;
            this.gc_Attendance.Name = "gc_Attendance";
            this.gc_Attendance.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItem_ActionButton,
            this.repositoryItemTextEdit_Status});
            this.gc_Attendance.Size = new System.Drawing.Size(1408, 884);
            this.gc_Attendance.TabIndex = 8;
            this.gc_Attendance.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Attendance});
            this.gc_Attendance.Load += new System.EventHandler(this.gc_Attendance_Load);
            // 
            // gv_Attendance
            // 
            this.gv_Attendance.Appearance.HeaderPanel.Font = new System.Drawing.Font("Poppins SemiBold", 9.23F);
            this.gv_Attendance.Appearance.HeaderPanel.Options.UseFont = true;
            this.gv_Attendance.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdclm_AttendanceId,
            this.grdclm_AttendanceName,
            this.grdclm_AttendanceLocation,
            this.grdclm_LogType,
            this.grdclm_AttendanceDate,
            this.grdclm_StartTime,
            this.grdclm_EndTime,
            this.grdclm_Status,
            this.grdclm_Action});
            this.gv_Attendance.GridControl = this.gc_Attendance;
            this.gv_Attendance.Name = "gv_Attendance";
            this.gv_Attendance.OptionsCustomization.AllowColumnMoving = false;
            this.gv_Attendance.OptionsCustomization.AllowColumnResizing = false;
            this.gv_Attendance.OptionsCustomization.AllowFilter = false;
            this.gv_Attendance.OptionsCustomization.AllowGroup = false;
            this.gv_Attendance.OptionsCustomization.AllowSort = false;
            this.gv_Attendance.OptionsMenu.EnableColumnMenu = false;
            this.gv_Attendance.OptionsView.ShowGroupPanel = false;
            this.gv_Attendance.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gv_Attendance.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gv_Attendance_CustomColumnDisplayText);
            // 
            // grdclm_AttendanceId
            // 
            this.grdclm_AttendanceId.Caption = "ID";
            this.grdclm_AttendanceId.FieldName = "AttendanceId";
            this.grdclm_AttendanceId.Name = "grdclm_AttendanceId";
            // 
            // grdclm_AttendanceName
            // 
            this.grdclm_AttendanceName.Caption = "Name";
            this.grdclm_AttendanceName.FieldName = "AttendanceName";
            this.grdclm_AttendanceName.Name = "grdclm_AttendanceName";
            this.grdclm_AttendanceName.OptionsColumn.AllowEdit = false;
            this.grdclm_AttendanceName.OptionsColumn.ReadOnly = true;
            this.grdclm_AttendanceName.Visible = true;
            this.grdclm_AttendanceName.VisibleIndex = 0;
            this.grdclm_AttendanceName.Width = 124;
            // 
            // grdclm_AttendanceLocation
            // 
            this.grdclm_AttendanceLocation.Caption = "Location";
            this.grdclm_AttendanceLocation.FieldName = "AttendanceLocation";
            this.grdclm_AttendanceLocation.Name = "grdclm_AttendanceLocation";
            this.grdclm_AttendanceLocation.OptionsColumn.AllowEdit = false;
            this.grdclm_AttendanceLocation.OptionsColumn.ReadOnly = true;
            this.grdclm_AttendanceLocation.Visible = true;
            this.grdclm_AttendanceLocation.VisibleIndex = 1;
            this.grdclm_AttendanceLocation.Width = 218;
            // 
            // grdclm_LogType
            // 
            this.grdclm_LogType.Caption = "Log Type";
            this.grdclm_LogType.FieldName = "LogType";
            this.grdclm_LogType.Name = "grdclm_LogType";
            this.grdclm_LogType.OptionsColumn.AllowEdit = false;
            this.grdclm_LogType.OptionsColumn.ReadOnly = true;
            this.grdclm_LogType.Visible = true;
            this.grdclm_LogType.VisibleIndex = 2;
            this.grdclm_LogType.Width = 145;
            // 
            // grdclm_AttendanceDate
            // 
            this.grdclm_AttendanceDate.Caption = "Date";
            this.grdclm_AttendanceDate.FieldName = "Date";
            this.grdclm_AttendanceDate.Name = "grdclm_AttendanceDate";
            this.grdclm_AttendanceDate.OptionsColumn.AllowEdit = false;
            this.grdclm_AttendanceDate.OptionsColumn.ReadOnly = true;
            this.grdclm_AttendanceDate.Visible = true;
            this.grdclm_AttendanceDate.VisibleIndex = 3;
            this.grdclm_AttendanceDate.Width = 119;
            // 
            // grdclm_StartTime
            // 
            this.grdclm_StartTime.Caption = "Start Time";
            this.grdclm_StartTime.DisplayFormat.FormatString = "hh:mm tt";
            this.grdclm_StartTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.grdclm_StartTime.FieldName = "StartTime";
            this.grdclm_StartTime.Name = "grdclm_StartTime";
            this.grdclm_StartTime.OptionsColumn.AllowEdit = false;
            this.grdclm_StartTime.OptionsColumn.ReadOnly = true;
            this.grdclm_StartTime.Visible = true;
            this.grdclm_StartTime.VisibleIndex = 4;
            this.grdclm_StartTime.Width = 121;
            // 
            // grdclm_EndTime
            // 
            this.grdclm_EndTime.Caption = "End Time";
            this.grdclm_EndTime.DisplayFormat.FormatString = "hh:mm tt";
            this.grdclm_EndTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.grdclm_EndTime.FieldName = "EndTime";
            this.grdclm_EndTime.Name = "grdclm_EndTime";
            this.grdclm_EndTime.OptionsColumn.AllowEdit = false;
            this.grdclm_EndTime.OptionsColumn.ReadOnly = true;
            this.grdclm_EndTime.Visible = true;
            this.grdclm_EndTime.VisibleIndex = 5;
            this.grdclm_EndTime.Width = 181;
            // 
            // grdclm_Status
            // 
            this.grdclm_Status.Caption = "Status";
            this.grdclm_Status.ColumnEdit = this.repositoryItemTextEdit_Status;
            this.grdclm_Status.DisplayFormat.FormatString = "[True] = ACTIVE; [False] = INACTIVE";
            this.grdclm_Status.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.grdclm_Status.FieldName = "Status";
            this.grdclm_Status.Name = "grdclm_Status";
            this.grdclm_Status.ShowUnboundExpressionMenu = true;
            this.grdclm_Status.UnboundDataType = typeof(string);
            this.grdclm_Status.UnboundExpression = "Iif([Status], \'ACTIVE\', \'INACTIVE\')";
            this.grdclm_Status.Visible = true;
            this.grdclm_Status.VisibleIndex = 6;
            // 
            // repositoryItemTextEdit_Status
            // 
            this.repositoryItemTextEdit_Status.AutoHeight = false;
            this.repositoryItemTextEdit_Status.DisplayFormat.FormatString = "[True] = ACTIVE; [False] = INACTIVE";
            this.repositoryItemTextEdit_Status.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.repositoryItemTextEdit_Status.Name = "repositoryItemTextEdit_Status";
            this.repositoryItemTextEdit_Status.ReadOnly = true;
            // 
            // grdclm_Action
            // 
            this.grdclm_Action.AppearanceCell.Options.UseTextOptions = true;
            this.grdclm_Action.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdclm_Action.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.grdclm_Action.AppearanceHeader.Options.UseTextOptions = true;
            this.grdclm_Action.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdclm_Action.Caption = "Action";
            this.grdclm_Action.ColumnEdit = this.repositoryItem_ActionButton;
            this.grdclm_Action.Name = "grdclm_Action";
            this.grdclm_Action.OptionsColumn.ReadOnly = true;
            this.grdclm_Action.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.grdclm_Action.Visible = true;
            this.grdclm_Action.VisibleIndex = 7;
            this.grdclm_Action.Width = 66;
            // 
            // repositoryItem_ActionButton
            // 
            this.repositoryItem_ActionButton.Appearance.Options.UseTextOptions = true;
            this.repositoryItem_ActionButton.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            editorButtonImageOptions1.SvgImageSize = new System.Drawing.Size(16, 16);
            serializableAppearanceObject1.Options.UseTextOptions = true;
            serializableAppearanceObject1.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            editorButtonImageOptions2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions2.SvgImage")));
            editorButtonImageOptions2.SvgImageSize = new System.Drawing.Size(16, 16);
            serializableAppearanceObject5.Options.UseTextOptions = true;
            serializableAppearanceObject5.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItem_ActionButton.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", "Edit", null, DevExpress.Utils.ToolTipAnchor.Default),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", "Delete", null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItem_ActionButton.Name = "repositoryItem_ActionButton";
            this.repositoryItem_ActionButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItem_ActionButton.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItem_ActionButton_ButtonClick);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_PageHeading,
            this.lci_PanelBody});
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
            // lci_PanelBody
            // 
            this.lci_PanelBody.Control = this.gc_Attendance;
            this.lci_PanelBody.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_PanelBody.CustomizationFormText = "layoutControlItem2";
            this.lci_PanelBody.Location = new System.Drawing.Point(0, 108);
            this.lci_PanelBody.Name = "lci_PanelBody";
            this.lci_PanelBody.Size = new System.Drawing.Size(1414, 890);
            this.lci_PanelBody.Text = "layoutControlItem2";
            this.lci_PanelBody.TextSize = new System.Drawing.Size(0, 0);
            this.lci_PanelBody.TextVisible = false;
            // 
            // Attendance_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lc_Attendance);
            this.Name = "Attendance_UserControl";
            this.Size = new System.Drawing.Size(1440, 1024);
            ((System.ComponentModel.ISupportInitialize)(this.lc_Attendance)).EndInit();
            this.lc_Attendance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).EndInit();
            this.panel_PageHeading.ResumeLayout(false);
            this.panel_PageHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Attendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Attendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit_Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItem_ActionButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PanelBody)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lc_Attendance;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.PanelControl panel_PageHeading;
        private DevExpress.XtraEditors.LabelControl label_PageTitle;
        private DevExpress.XtraEditors.LabelControl label_PageDescription;
        private DevExpress.XtraLayout.LayoutControlItem lci_PageHeading;
        private DevExpress.XtraGrid.GridControl gc_Attendance;
        private DevExpress.XtraLayout.LayoutControlItem lci_PanelBody;
        private DevExpress.XtraEditors.SimpleButton btn_AddAttendance;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Attendance;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_AttendanceDate;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_StartTime;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_EndTime;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_LogType;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_AttendanceLocation;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_AttendanceName;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_Action;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItem_ActionButton;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_Status;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_AttendanceId;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit_Status;
    }
}

namespace AttendanceManagementSystem.Forms.Students
{
    partial class Students_UserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students_UserControl));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.lc_Students = new DevExpress.XtraLayout.LayoutControl();
            this.panel_YearLevelFilter = new DevExpress.XtraEditors.PanelControl();
            this.cbe_YearLevel = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panel_CourseFilter = new DevExpress.XtraEditors.PanelControl();
            this.cbe_Course = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panel_SearchBar = new DevExpress.XtraEditors.PanelControl();
            this.findPanel = new DevExpress.XtraEditors.SearchControl();
            this.panel_PageHeading = new DevExpress.XtraEditors.PanelControl();
            this.label_PageTitle = new DevExpress.XtraEditors.LabelControl();
            this.btn_AddStudent = new DevExpress.XtraEditors.SimpleButton();
            this.label_PageDescription = new DevExpress.XtraEditors.LabelControl();
            this.gc_Students = new DevExpress.XtraGrid.GridControl();
            this.gv_Students = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdclm_Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_StudentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_Course = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_YearLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_Action = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItem_ActionButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lci_PageHeading = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_GridControlStudents = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_FindPanel = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_FilterPanel = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_YearLevel = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lc_Students)).BeginInit();
            this.lc_Students.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_YearLevelFilter)).BeginInit();
            this.panel_YearLevelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_YearLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_CourseFilter)).BeginInit();
            this.panel_CourseFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_Course.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_SearchBar)).BeginInit();
            this.panel_SearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.findPanel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).BeginInit();
            this.panel_PageHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItem_ActionButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_GridControlStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_FindPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_FilterPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_YearLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // lc_Students
            // 
            this.lc_Students.Controls.Add(this.panel_YearLevelFilter);
            this.lc_Students.Controls.Add(this.panel_CourseFilter);
            this.lc_Students.Controls.Add(this.panel_SearchBar);
            this.lc_Students.Controls.Add(this.panel_PageHeading);
            this.lc_Students.Controls.Add(this.gc_Students);
            this.lc_Students.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_Students.Location = new System.Drawing.Point(0, 0);
            this.lc_Students.Name = "lc_Students";
            this.lc_Students.Root = this.Root;
            this.lc_Students.Size = new System.Drawing.Size(1440, 1024);
            this.lc_Students.TabIndex = 0;
            this.lc_Students.Text = "layoutControl1";
            // 
            // panel_YearLevelFilter
            // 
            this.panel_YearLevelFilter.Controls.Add(this.cbe_YearLevel);
            this.panel_YearLevelFilter.Location = new System.Drawing.Point(1214, 126);
            this.panel_YearLevelFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_YearLevelFilter.Name = "panel_YearLevelFilter";
            this.panel_YearLevelFilter.Size = new System.Drawing.Size(210, 38);
            this.panel_YearLevelFilter.TabIndex = 0;
            // 
            // cbe_YearLevel
            // 
            this.cbe_YearLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbe_YearLevel.EditValue = "Year Level";
            this.cbe_YearLevel.Location = new System.Drawing.Point(2, 2);
            this.cbe_YearLevel.Name = "cbe_YearLevel";
            this.cbe_YearLevel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbe_YearLevel.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbe_YearLevel.Size = new System.Drawing.Size(206, 34);
            this.cbe_YearLevel.TabIndex = 2;
            this.cbe_YearLevel.SelectedValueChanged += new System.EventHandler(this.cbe_YearLevel_SelectedValueChanged);
            // 
            // panel_CourseFilter
            // 
            this.panel_CourseFilter.Controls.Add(this.cbe_Course);
            this.panel_CourseFilter.Location = new System.Drawing.Point(1000, 126);
            this.panel_CourseFilter.Name = "panel_CourseFilter";
            this.panel_CourseFilter.Size = new System.Drawing.Size(208, 38);
            this.panel_CourseFilter.TabIndex = 10;
            // 
            // cbe_Course
            // 
            this.cbe_Course.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbe_Course.EditValue = "Course";
            this.cbe_Course.Location = new System.Drawing.Point(2, 2);
            this.cbe_Course.Name = "cbe_Course";
            this.cbe_Course.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbe_Course.Properties.Items.AddRange(new object[] {
            "BSN",
            "BSMT",
            "BS-RADTECH",
            "BS-PHARMA",
            "BSPT",
            "BSIT",
            "BSHM",
            "BSBA",
            "BSED"});
            this.cbe_Course.Size = new System.Drawing.Size(204, 34);
            this.cbe_Course.TabIndex = 0;
            this.cbe_Course.SelectedValueChanged += new System.EventHandler(this.cbe_Course_SelectedValueChanged);
            // 
            // panel_SearchBar
            // 
            this.panel_SearchBar.Controls.Add(this.findPanel);
            this.panel_SearchBar.Location = new System.Drawing.Point(16, 126);
            this.panel_SearchBar.Name = "panel_SearchBar";
            this.panel_SearchBar.Size = new System.Drawing.Size(978, 38);
            this.panel_SearchBar.TabIndex = 9;
            // 
            // findPanel
            // 
            this.findPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.findPanel.Location = new System.Drawing.Point(2, 2);
            this.findPanel.Name = "findPanel";
            this.findPanel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.findPanel.Size = new System.Drawing.Size(974, 34);
            this.findPanel.TabIndex = 0;
            this.findPanel.TextChanged += new System.EventHandler(this.findPanel_TextChanged);
            // 
            // panel_PageHeading
            // 
            this.panel_PageHeading.Controls.Add(this.label_PageTitle);
            this.panel_PageHeading.Controls.Add(this.btn_AddStudent);
            this.panel_PageHeading.Controls.Add(this.label_PageDescription);
            this.panel_PageHeading.Location = new System.Drawing.Point(16, 16);
            this.panel_PageHeading.Name = "panel_PageHeading";
            this.panel_PageHeading.Size = new System.Drawing.Size(1408, 104);
            this.panel_PageHeading.TabIndex = 7;
            // 
            // label_PageTitle
            // 
            this.label_PageTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_PageTitle.Appearance.Font = new System.Drawing.Font("Poppins", 17.71F, System.Drawing.FontStyle.Bold);
            this.label_PageTitle.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.label_PageTitle.Appearance.Options.UseFont = true;
            this.label_PageTitle.Location = new System.Drawing.Point(31, 20);
            this.label_PageTitle.Margin = new System.Windows.Forms.Padding(4);
            this.label_PageTitle.Name = "label_PageTitle";
            this.label_PageTitle.Size = new System.Drawing.Size(110, 42);
            this.label_PageTitle.TabIndex = 0;
            this.label_PageTitle.Text = "Students";
            // 
            // btn_AddStudent
            // 
            this.btn_AddStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddStudent.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(182)))), ((int)(((byte)(125)))));
            this.btn_AddStudent.Appearance.Font = new System.Drawing.Font("Poppins", 12.08F);
            this.btn_AddStudent.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_AddStudent.Appearance.Options.UseBackColor = true;
            this.btn_AddStudent.Appearance.Options.UseFont = true;
            this.btn_AddStudent.Appearance.Options.UseForeColor = true;
            this.btn_AddStudent.Appearance.Options.UseTextOptions = true;
            this.btn_AddStudent.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_AddStudent.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btn_AddStudent.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_AddStudent.ImageOptions.SvgImage")));
            this.btn_AddStudent.ImageOptions.SvgImageSize = new System.Drawing.Size(26, 26);
            this.btn_AddStudent.Location = new System.Drawing.Point(1159, 25);
            this.btn_AddStudent.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AddStudent.Name = "btn_AddStudent";
            this.btn_AddStudent.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btn_AddStudent.Size = new System.Drawing.Size(236, 56);
            this.btn_AddStudent.TabIndex = 2;
            this.btn_AddStudent.Text = "Add Student";
            this.btn_AddStudent.Click += new System.EventHandler(this.btn_AddStudent_Click);
            // 
            // label_PageDescription
            // 
            this.label_PageDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_PageDescription.Appearance.Font = new System.Drawing.Font("Poppins", 12F);
            this.label_PageDescription.Appearance.Options.UseFont = true;
            this.label_PageDescription.Location = new System.Drawing.Point(31, 56);
            this.label_PageDescription.Margin = new System.Windows.Forms.Padding(4);
            this.label_PageDescription.Name = "label_PageDescription";
            this.label_PageDescription.Size = new System.Drawing.Size(319, 28);
            this.label_PageDescription.TabIndex = 1;
            this.label_PageDescription.Text = "View and manage students information.";
            // 
            // gc_Students
            // 
            this.gc_Students.Location = new System.Drawing.Point(16, 170);
            this.gc_Students.MainView = this.gv_Students;
            this.gc_Students.Name = "gc_Students";
            this.gc_Students.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItem_ActionButton});
            this.gc_Students.Size = new System.Drawing.Size(1408, 838);
            this.gc_Students.TabIndex = 8;
            this.gc_Students.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Students});
            // 
            // gv_Students
            // 
            this.gv_Students.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdclm_Id,
            this.grdclm_StudentId,
            this.grdclm_Name,
            this.grdclm_Course,
            this.grdclm_YearLevel,
            this.grdclm_Email,
            this.grdclm_Action});
            this.gv_Students.GridControl = this.gc_Students;
            this.gv_Students.Name = "gv_Students";
            this.gv_Students.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gv_Students.OptionsView.ShowGroupPanel = false;
            // 
            // grdclm_Id
            // 
            this.grdclm_Id.Caption = "Id";
            this.grdclm_Id.FieldName = "Id";
            this.grdclm_Id.Name = "grdclm_Id";
            // 
            // grdclm_StudentId
            // 
            this.grdclm_StudentId.Caption = "ID #";
            this.grdclm_StudentId.FieldName = "SchoolStudentId";
            this.grdclm_StudentId.MinWidth = 22;
            this.grdclm_StudentId.Name = "grdclm_StudentId";
            this.grdclm_StudentId.OptionsColumn.AllowEdit = false;
            this.grdclm_StudentId.Visible = true;
            this.grdclm_StudentId.VisibleIndex = 0;
            // 
            // grdclm_Name
            // 
            this.grdclm_Name.Caption = "Name";
            this.grdclm_Name.FieldName = "FullName";
            this.grdclm_Name.MinWidth = 22;
            this.grdclm_Name.Name = "grdclm_Name";
            this.grdclm_Name.OptionsColumn.AllowEdit = false;
            this.grdclm_Name.Visible = true;
            this.grdclm_Name.VisibleIndex = 1;
            // 
            // grdclm_Course
            // 
            this.grdclm_Course.Caption = "Course";
            this.grdclm_Course.FieldName = "Course";
            this.grdclm_Course.MinWidth = 22;
            this.grdclm_Course.Name = "grdclm_Course";
            this.grdclm_Course.OptionsColumn.AllowEdit = false;
            this.grdclm_Course.Visible = true;
            this.grdclm_Course.VisibleIndex = 2;
            // 
            // grdclm_YearLevel
            // 
            this.grdclm_YearLevel.AppearanceCell.Options.UseTextOptions = true;
            this.grdclm_YearLevel.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.grdclm_YearLevel.Caption = "Year Level";
            this.grdclm_YearLevel.FieldName = "YearLevel";
            this.grdclm_YearLevel.MinWidth = 22;
            this.grdclm_YearLevel.Name = "grdclm_YearLevel";
            this.grdclm_YearLevel.OptionsColumn.AllowEdit = false;
            this.grdclm_YearLevel.Visible = true;
            this.grdclm_YearLevel.VisibleIndex = 3;
            // 
            // grdclm_Email
            // 
            this.grdclm_Email.Caption = "Email";
            this.grdclm_Email.FieldName = "Email";
            this.grdclm_Email.MinWidth = 22;
            this.grdclm_Email.Name = "grdclm_Email";
            this.grdclm_Email.OptionsColumn.AllowEdit = false;
            this.grdclm_Email.Visible = true;
            this.grdclm_Email.VisibleIndex = 4;
            // 
            // grdclm_Action
            // 
            this.grdclm_Action.AppearanceCell.Options.UseTextOptions = true;
            this.grdclm_Action.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdclm_Action.AppearanceHeader.Options.UseTextOptions = true;
            this.grdclm_Action.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdclm_Action.Caption = "Action";
            this.grdclm_Action.ColumnEdit = this.repositoryItem_ActionButton;
            this.grdclm_Action.MinWidth = 22;
            this.grdclm_Action.Name = "grdclm_Action";
            this.grdclm_Action.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.grdclm_Action.Visible = true;
            this.grdclm_Action.VisibleIndex = 5;
            // 
            // repositoryItem_ActionButton
            // 
            this.repositoryItem_ActionButton.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            editorButtonImageOptions1.SvgImageSize = new System.Drawing.Size(16, 16);
            serializableAppearanceObject1.Options.UseTextOptions = true;
            serializableAppearanceObject1.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            serializableAppearanceObject1.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.repositoryItem_ActionButton.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItem_ActionButton.Name = "repositoryItem_ActionButton";
            this.repositoryItem_ActionButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItem_ActionButton.Click += new System.EventHandler(this.repositoryItem_ActionButton_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_PageHeading,
            this.lci_GridControlStudents,
            this.lci_FindPanel,
            this.lci_FilterPanel,
            this.lci_YearLevel});
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
            // lci_GridControlStudents
            // 
            this.lci_GridControlStudents.Control = this.gc_Students;
            this.lci_GridControlStudents.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_GridControlStudents.CustomizationFormText = "lci_GridControlStudents";
            this.lci_GridControlStudents.Location = new System.Drawing.Point(0, 154);
            this.lci_GridControlStudents.Name = "lci_GridControlStudents";
            this.lci_GridControlStudents.Size = new System.Drawing.Size(1414, 844);
            this.lci_GridControlStudents.TextSize = new System.Drawing.Size(0, 0);
            this.lci_GridControlStudents.TextVisible = false;
            // 
            // lci_FindPanel
            // 
            this.lci_FindPanel.Control = this.panel_SearchBar;
            this.lci_FindPanel.Location = new System.Drawing.Point(0, 110);
            this.lci_FindPanel.Name = "lci_FindPanel";
            this.lci_FindPanel.Size = new System.Drawing.Size(984, 44);
            this.lci_FindPanel.TextSize = new System.Drawing.Size(0, 0);
            this.lci_FindPanel.TextVisible = false;
            // 
            // lci_FilterPanel
            // 
            this.lci_FilterPanel.Control = this.panel_CourseFilter;
            this.lci_FilterPanel.Location = new System.Drawing.Point(984, 110);
            this.lci_FilterPanel.Name = "lci_FilterPanel";
            this.lci_FilterPanel.Size = new System.Drawing.Size(214, 44);
            this.lci_FilterPanel.TextSize = new System.Drawing.Size(0, 0);
            this.lci_FilterPanel.TextVisible = false;
            // 
            // lci_YearLevel
            // 
            this.lci_YearLevel.Control = this.panel_YearLevelFilter;
            this.lci_YearLevel.Location = new System.Drawing.Point(1198, 110);
            this.lci_YearLevel.Name = "lci_YearLevel";
            this.lci_YearLevel.Size = new System.Drawing.Size(216, 44);
            this.lci_YearLevel.TextSize = new System.Drawing.Size(0, 0);
            this.lci_YearLevel.TextVisible = false;
            // 
            // Students_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lc_Students);
            this.Name = "Students_UserControl";
            this.Size = new System.Drawing.Size(1440, 1024);
            ((System.ComponentModel.ISupportInitialize)(this.lc_Students)).EndInit();
            this.lc_Students.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_YearLevelFilter)).EndInit();
            this.panel_YearLevelFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbe_YearLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_CourseFilter)).EndInit();
            this.panel_CourseFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbe_Course.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_SearchBar)).EndInit();
            this.panel_SearchBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.findPanel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).EndInit();
            this.panel_PageHeading.ResumeLayout(false);
            this.panel_PageHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItem_ActionButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_GridControlStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_FindPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_FilterPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_YearLevel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lc_Students;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.PanelControl panel_PageHeading;
        private DevExpress.XtraEditors.LabelControl label_PageTitle;
        private DevExpress.XtraEditors.SimpleButton btn_AddStudent;
        private DevExpress.XtraEditors.LabelControl label_PageDescription;
        private DevExpress.XtraLayout.LayoutControlItem lci_PageHeading;
        private DevExpress.XtraGrid.GridControl gc_Students;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Students;
        private DevExpress.XtraLayout.LayoutControlItem lci_GridControlStudents;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_Name;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_StudentId;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_Course;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_YearLevel;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_Email;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_Action;
        private DevExpress.XtraEditors.PanelControl panel_CourseFilter;
        private DevExpress.XtraEditors.PanelControl panel_SearchBar;
        private DevExpress.XtraEditors.SearchControl findPanel;
        private DevExpress.XtraLayout.LayoutControlItem lci_FindPanel;
        private DevExpress.XtraLayout.LayoutControlItem lci_FilterPanel;
        private DevExpress.XtraEditors.ComboBoxEdit cbe_Course;
        private DevExpress.XtraEditors.ComboBoxEdit cbe_YearLevel;
        private DevExpress.XtraEditors.PanelControl panel_YearLevelFilter;
        private DevExpress.XtraLayout.LayoutControlItem lci_YearLevel;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItem_ActionButton;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_Id;
    }
}

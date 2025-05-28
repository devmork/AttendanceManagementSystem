namespace AttendanceManagementSystem.Forms.Events
{
    partial class AddAttendance_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAttendance_Form));
            this.lc_AddEventForm = new DevExpress.XtraLayout.LayoutControl();
            this.gc_EventDetails = new DevExpress.XtraEditors.GroupControl();
            this.label_AttendanceLocation = new DevExpress.XtraEditors.LabelControl();
            this.txt_AttendanceLocation = new DevExpress.XtraEditors.TextEdit();
            this.cbe_LogType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_CreateAttendance = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.te_EndTime = new DevExpress.XtraEditors.TimeEdit();
            this.te_StartTime = new DevExpress.XtraEditors.TimeEdit();
            this.de_Date = new DevExpress.XtraEditors.DateEdit();
            this.label_EventEndTime = new DevExpress.XtraEditors.LabelControl();
            this.label_EventStartTime = new DevExpress.XtraEditors.LabelControl();
            this.label_EventDate = new DevExpress.XtraEditors.LabelControl();
            this.label_AttendanceName = new DevExpress.XtraEditors.LabelControl();
            this.txt_AttendanceName = new DevExpress.XtraEditors.TextEdit();
            this.label_Instruction = new DevExpress.XtraEditors.LabelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lci_EventDetails = new DevExpress.XtraLayout.LayoutControlItem();
            this.btn_CloseForm = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lc_AddEventForm)).BeginInit();
            this.lc_AddEventForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_EventDetails)).BeginInit();
            this.gc_EventDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AttendanceLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_LogType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_EndTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_StartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AttendanceName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_EventDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseForm.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lc_AddEventForm
            // 
            this.lc_AddEventForm.Controls.Add(this.gc_EventDetails);
            this.lc_AddEventForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_AddEventForm.Location = new System.Drawing.Point(0, 0);
            this.lc_AddEventForm.Name = "lc_AddEventForm";
            this.lc_AddEventForm.Root = this.Root;
            this.lc_AddEventForm.Size = new System.Drawing.Size(558, 450);
            this.lc_AddEventForm.TabIndex = 0;
            this.lc_AddEventForm.Text = "layoutControl1";
            // 
            // gc_EventDetails
            // 
            this.gc_EventDetails.AppearanceCaption.Font = new System.Drawing.Font("Poppins", 12.8F, System.Drawing.FontStyle.Bold);
            this.gc_EventDetails.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gc_EventDetails.AppearanceCaption.Options.UseFont = true;
            this.gc_EventDetails.Controls.Add(this.btn_CloseForm);
            this.gc_EventDetails.Controls.Add(this.label_AttendanceLocation);
            this.gc_EventDetails.Controls.Add(this.txt_AttendanceLocation);
            this.gc_EventDetails.Controls.Add(this.cbe_LogType);
            this.gc_EventDetails.Controls.Add(this.labelControl1);
            this.gc_EventDetails.Controls.Add(this.btn_CreateAttendance);
            this.gc_EventDetails.Controls.Add(this.btn_Cancel);
            this.gc_EventDetails.Controls.Add(this.te_EndTime);
            this.gc_EventDetails.Controls.Add(this.te_StartTime);
            this.gc_EventDetails.Controls.Add(this.de_Date);
            this.gc_EventDetails.Controls.Add(this.label_EventEndTime);
            this.gc_EventDetails.Controls.Add(this.label_EventStartTime);
            this.gc_EventDetails.Controls.Add(this.label_EventDate);
            this.gc_EventDetails.Controls.Add(this.label_AttendanceName);
            this.gc_EventDetails.Controls.Add(this.txt_AttendanceName);
            this.gc_EventDetails.Controls.Add(this.label_Instruction);
            this.gc_EventDetails.Location = new System.Drawing.Point(13, 13);
            this.gc_EventDetails.Margin = new System.Windows.Forms.Padding(0);
            this.gc_EventDetails.Name = "gc_EventDetails";
            this.gc_EventDetails.Size = new System.Drawing.Size(532, 424);
            this.gc_EventDetails.TabIndex = 4;
            this.gc_EventDetails.Text = "Create New Attendance";
            // 
            // label_AttendanceLocation
            // 
            this.label_AttendanceLocation.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 10.54F);
            this.label_AttendanceLocation.Appearance.Options.UseFont = true;
            this.label_AttendanceLocation.Location = new System.Drawing.Point(20, 143);
            this.label_AttendanceLocation.Name = "label_AttendanceLocation";
            this.label_AttendanceLocation.Size = new System.Drawing.Size(61, 25);
            this.label_AttendanceLocation.TabIndex = 9;
            this.label_AttendanceLocation.Text = "Location";
            // 
            // txt_AttendanceLocation
            // 
            this.txt_AttendanceLocation.Location = new System.Drawing.Point(20, 174);
            this.txt_AttendanceLocation.Name = "txt_AttendanceLocation";
            this.txt_AttendanceLocation.Properties.AutoHeight = false;
            this.txt_AttendanceLocation.Size = new System.Drawing.Size(492, 37);
            this.txt_AttendanceLocation.TabIndex = 8;
            // 
            // cbe_LogType
            // 
            this.cbe_LogType.Location = new System.Drawing.Point(269, 251);
            this.cbe_LogType.Name = "cbe_LogType";
            this.cbe_LogType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbe_LogType.Properties.Items.AddRange(new object[] {
            "Sign In",
            "Sign Out"});
            this.cbe_LogType.Size = new System.Drawing.Size(243, 34);
            this.cbe_LogType.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 10.54F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(269, 220);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 25);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Log Type";
            // 
            // btn_CreateAttendance
            // 
            this.btn_CreateAttendance.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(182)))), ((int)(((byte)(125)))));
            this.btn_CreateAttendance.Appearance.Font = new System.Drawing.Font("Poppins", 9.25F);
            this.btn_CreateAttendance.Appearance.Options.UseBackColor = true;
            this.btn_CreateAttendance.Appearance.Options.UseFont = true;
            this.btn_CreateAttendance.Location = new System.Drawing.Point(324, 374);
            this.btn_CreateAttendance.Name = "btn_CreateAttendance";
            this.btn_CreateAttendance.Size = new System.Drawing.Size(185, 41);
            this.btn_CreateAttendance.TabIndex = 5;
            this.btn_CreateAttendance.Text = "Create Attendance";
            this.btn_CreateAttendance.Click += new System.EventHandler(this.btn_CreateAttendance_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Appearance.Font = new System.Drawing.Font("Poppins", 9.25F);
            this.btn_Cancel.Appearance.Options.UseFont = true;
            this.btn_Cancel.Location = new System.Drawing.Point(191, 374);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(127, 41);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // te_EndTime
            // 
            this.te_EndTime.EditValue = new System.DateTime(2025, 4, 6, 0, 0, 0, 0);
            this.te_EndTime.Location = new System.Drawing.Point(269, 322);
            this.te_EndTime.Name = "te_EndTime";
            this.te_EndTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.te_EndTime.Properties.MaskSettings.Set("mask", "t");
            this.te_EndTime.Size = new System.Drawing.Size(243, 34);
            this.te_EndTime.TabIndex = 4;
            // 
            // te_StartTime
            // 
            this.te_StartTime.EditValue = new System.DateTime(2025, 4, 6, 0, 0, 0, 0);
            this.te_StartTime.Location = new System.Drawing.Point(20, 322);
            this.te_StartTime.Name = "te_StartTime";
            this.te_StartTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.te_StartTime.Properties.MaskSettings.Set("mask", "t");
            this.te_StartTime.Size = new System.Drawing.Size(240, 34);
            this.te_StartTime.TabIndex = 4;
            // 
            // de_Date
            // 
            this.de_Date.EditValue = null;
            this.de_Date.Location = new System.Drawing.Point(20, 251);
            this.de_Date.Name = "de_Date";
            this.de_Date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_Date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_Date.Properties.MaskSettings.Set("mask", "D");
            this.de_Date.Size = new System.Drawing.Size(240, 34);
            this.de_Date.TabIndex = 3;
            // 
            // label_EventEndTime
            // 
            this.label_EventEndTime.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 10.54F);
            this.label_EventEndTime.Appearance.Options.UseFont = true;
            this.label_EventEndTime.Location = new System.Drawing.Point(269, 291);
            this.label_EventEndTime.Name = "label_EventEndTime";
            this.label_EventEndTime.Size = new System.Drawing.Size(64, 25);
            this.label_EventEndTime.TabIndex = 2;
            this.label_EventEndTime.Text = "End Time";
            // 
            // label_EventStartTime
            // 
            this.label_EventStartTime.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 10.54F);
            this.label_EventStartTime.Appearance.Options.UseFont = true;
            this.label_EventStartTime.Location = new System.Drawing.Point(20, 291);
            this.label_EventStartTime.Name = "label_EventStartTime";
            this.label_EventStartTime.Size = new System.Drawing.Size(74, 25);
            this.label_EventStartTime.TabIndex = 2;
            this.label_EventStartTime.Text = "Start Time";
            // 
            // label_EventDate
            // 
            this.label_EventDate.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 10.54F);
            this.label_EventDate.Appearance.Options.UseFont = true;
            this.label_EventDate.Location = new System.Drawing.Point(20, 220);
            this.label_EventDate.Name = "label_EventDate";
            this.label_EventDate.Size = new System.Drawing.Size(34, 25);
            this.label_EventDate.TabIndex = 2;
            this.label_EventDate.Text = "Date";
            // 
            // label_AttendanceName
            // 
            this.label_AttendanceName.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 10.54F);
            this.label_AttendanceName.Appearance.Options.UseFont = true;
            this.label_AttendanceName.Location = new System.Drawing.Point(20, 70);
            this.label_AttendanceName.Name = "label_AttendanceName";
            this.label_AttendanceName.Size = new System.Drawing.Size(43, 25);
            this.label_AttendanceName.TabIndex = 2;
            this.label_AttendanceName.Text = "Name";
            // 
            // txt_AttendanceName
            // 
            this.txt_AttendanceName.Location = new System.Drawing.Point(20, 101);
            this.txt_AttendanceName.Name = "txt_AttendanceName";
            this.txt_AttendanceName.Properties.AutoHeight = false;
            this.txt_AttendanceName.Size = new System.Drawing.Size(492, 34);
            this.txt_AttendanceName.TabIndex = 1;
            // 
            // label_Instruction
            // 
            this.label_Instruction.Appearance.Font = new System.Drawing.Font("Poppins", 10.54F);
            this.label_Instruction.Appearance.Options.UseFont = true;
            this.label_Instruction.Location = new System.Drawing.Point(20, 38);
            this.label_Instruction.Name = "label_Instruction";
            this.label_Instruction.Size = new System.Drawing.Size(348, 25);
            this.label_Instruction.TabIndex = 0;
            this.label_Instruction.Text = "Fill in the details below to create a new attendance.";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_EventDetails});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(558, 450);
            this.Root.TextVisible = false;
            // 
            // lci_EventDetails
            // 
            this.lci_EventDetails.Control = this.gc_EventDetails;
            this.lci_EventDetails.Location = new System.Drawing.Point(0, 0);
            this.lci_EventDetails.Name = "lci_EventDetails";
            this.lci_EventDetails.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lci_EventDetails.Size = new System.Drawing.Size(532, 424);
            this.lci_EventDetails.TextSize = new System.Drawing.Size(0, 0);
            this.lci_EventDetails.TextVisible = false;
            // 
            // btn_CloseForm
            // 
            this.btn_CloseForm.EditValue = ((object)(resources.GetObject("btn_CloseForm.EditValue")));
            this.btn_CloseForm.Location = new System.Drawing.Point(500, 4);
            this.btn_CloseForm.Name = "btn_CloseForm";
            this.btn_CloseForm.Properties.AllowZoom = DevExpress.Utils.DefaultBoolean.True;
            this.btn_CloseForm.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_CloseForm.Properties.Appearance.Options.UseBackColor = true;
            this.btn_CloseForm.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btn_CloseForm.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.btn_CloseForm.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.btn_CloseForm.Properties.SvgImageSize = new System.Drawing.Size(14, 14);
            this.btn_CloseForm.Size = new System.Drawing.Size(26, 28);
            this.btn_CloseForm.TabIndex = 21;
            this.btn_CloseForm.Click += new System.EventHandler(this.btn_CloseForm_Click);
            // 
            // AddAttendance_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.Controls.Add(this.lc_AddEventForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAttendance_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.lc_AddEventForm)).EndInit();
            this.lc_AddEventForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_EventDetails)).EndInit();
            this.gc_EventDetails.ResumeLayout(false);
            this.gc_EventDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AttendanceLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_LogType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_EndTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_StartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AttendanceName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_EventDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseForm.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lc_AddEventForm;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.GroupControl gc_EventDetails;
        private DevExpress.XtraLayout.LayoutControlItem lci_EventDetails;
        private DevExpress.XtraEditors.LabelControl label_Instruction;
        private DevExpress.XtraEditors.TextEdit txt_AttendanceName;
        private DevExpress.XtraEditors.TimeEdit te_EndTime;
        private DevExpress.XtraEditors.TimeEdit te_StartTime;
        private DevExpress.XtraEditors.DateEdit de_Date;
        private DevExpress.XtraEditors.LabelControl label_EventEndTime;
        private DevExpress.XtraEditors.LabelControl label_EventStartTime;
        private DevExpress.XtraEditors.LabelControl label_EventDate;
        private DevExpress.XtraEditors.LabelControl label_AttendanceName;
        private DevExpress.XtraEditors.SimpleButton btn_CreateAttendance;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.ComboBoxEdit cbe_LogType;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl label_AttendanceLocation;
        private DevExpress.XtraEditors.TextEdit txt_AttendanceLocation;
        private DevExpress.XtraEditors.PictureEdit btn_CloseForm;
    }
}
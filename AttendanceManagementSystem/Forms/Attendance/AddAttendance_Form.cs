using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using AttendanceManagementSystem.Models.Base;
using System.Data.SQLite;
using Dapper;
using AttendanceManagementSystem.Interfaces.Repositories;
using AttendanceManagementSystem.Data.Repositories;
using DevExpress.XtraEditors.Filtering.Templates;

namespace AttendanceManagementSystem.Forms.Events
{
	public partial class AddAttendance_Form: DevExpress.XtraEditors.XtraForm
	{
        private readonly IAttendanceRepository _attendanceRepository;
        public AddAttendance_Form()
		{
            InitializeComponent();
            _attendanceRepository = new AttendanceRepository();
            te_StartTime.EditValue = DateTime.Now;
            te_EndTime.EditValue = DateTime.Now;
        }
        private void btn_CreateAttendance_Click(object sender, EventArgs e)
        {
            string attendanceName = txt_AttendanceName.Text;
            string attendanceLocation = txt_AttendanceLocation.Text;
            string logType = cbe_LogType.Text;
            DateTime date = de_Date.DateTime.Date;
            DateTime startTime = date + te_StartTime.Time.TimeOfDay; 
            DateTime endTime = date + te_EndTime.Time.TimeOfDay;

            if (string.IsNullOrWhiteSpace(attendanceName) || string.IsNullOrWhiteSpace(attendanceLocation) || string.IsNullOrWhiteSpace(logType))
            {
                XtraMessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (startTime >= endTime)
            {
                XtraMessageBox.Show("Start time must be before end time.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            var attendance = new Attendance
            {
                AttendanceId = 0,
                AttendanceName = attendanceName,
                AttendanceLocation = attendanceLocation,
                LogType = logType,
                Date = date,
                StartTime = startTime,
                EndTime = endTime,
            };

            _attendanceRepository.AddAttendance(attendance);
            ClearFields();
            XtraMessageBox.Show("Attendance created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ClearFields()
        {
            txt_AttendanceName.Text = string.Empty;
            txt_AttendanceLocation.Text = string.Empty;
            cbe_LogType.SelectedIndex = -1;
            de_Date.Text = string.Empty;
            te_StartTime.Text = string.Empty;
            te_EndTime.Text = string.Empty;
        }

        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
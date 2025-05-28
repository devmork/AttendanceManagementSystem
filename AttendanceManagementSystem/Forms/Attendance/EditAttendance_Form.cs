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
using AttendanceManagementSystem.Data.Repositories;
using AttendanceManagementSystem.Interfaces.Repositories;
using AttendanceManagementSystem.Models.Base;

namespace AttendanceManagementSystem.Forms.Events
{
	public partial class EditAttendance_Form: DevExpress.XtraEditors.XtraForm
	{
        private readonly IAttendanceRepository _attendanceRepository;
        private Attendance _attendance;
        public EditAttendance_Form(Attendance attendance)
        {
            InitializeComponent();
            _attendanceRepository = new AttendanceRepository();
            _attendance = attendance;
            LoadAttendanceData();
        }
        private void LoadAttendanceData()
        {
            txt_AttendanceName.Text = _attendance.AttendanceName;
            txt_AttedanceLocation.Text = _attendance.AttendanceLocation;
            cbe_LogType.Text = _attendance.LogType;
            de_AttendanceDate.DateTime = _attendance.Date;
            te_StartTime.Time = _attendance.StartTime;
            te_EndTime.Time = _attendance.EndTime;
        }
        private void btn_SaveChanges_Click(object sender, EventArgs e)
        {
            string attendanceName = txt_AttendanceName.Text;
            string attendanceLocation = txt_AttedanceLocation.Text;
            string logType = cbe_LogType.Text;
            DateTime date = de_AttendanceDate.DateTime.Date;
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

            _attendance.AttendanceName = attendanceName;
            _attendance.AttendanceLocation = attendanceLocation;
            _attendance.LogType = logType;
            _attendance.Date = date;
            _attendance.StartTime = startTime;
            _attendance.EndTime = endTime;

            _attendanceRepository.UpdateAttendance(_attendance);
            XtraMessageBox.Show("Attendance updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

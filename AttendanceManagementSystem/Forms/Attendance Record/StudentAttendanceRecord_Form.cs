using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;
using AttendanceManagementSystem.DTO;
using AttendanceManagementSystem.Interfaces.Services;
using AttendanceManagementSystem.Models.Base;
using AttendanceManagementSystem.Services;
using Dapper;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraEditors;

namespace AttendanceManagementSystem.Forms.Attendance_Report
{
	public partial class StudentAttendanceRecord_Form: DevExpress.XtraEditors.XtraForm
	{
        private string _connectionStrng = "Data Source=SEAMS.db;Version=3;Mode=ReadWrite;";
        private readonly IAttendanceService _attendanceService;
        private Student _student;
        public StudentAttendanceRecord_Form(Student student)
		{
            InitializeComponent();
            _attendanceService = new AttendanceService();
            _student = student;
		}
        private void StudentAttendanceRecord_Form_Load(object sender, EventArgs e)
        {
            // POPULATE FIELDS
            txt_SchoolStudentId.Text = _student.SchoolStudentId;
            txt_Name.Text = _student.FullName;

            //LOAD RECORD ON TXTEDIT
            int totalPresent = _attendanceService.GetTotalPresent(_student.SchoolStudentId);
            txt_TotalPresent.EditValue = totalPresent.ToString();


            if (IsAttendanceReset(_student.SchoolStudentId))
            {
                txt_TotalAbsent.EditValue = "0"; // Records successfully reset
            }
            else
            {
                int totalAbsent = _attendanceService.GetTotalAbsent(_student.SchoolStudentId);
                txt_TotalAbsent.EditValue = totalAbsent.ToString();
            }

        }
        private void gc_AttendanceRecord_Load(object sender, EventArgs e)
        {
            gc_AttendanceRecord.DataSource = GetAttendanceRecords(_student.SchoolStudentId);
        }
        private List<AttendanceRecordsDTO> GetAttendanceRecords(string schoolStudentId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionStrng))
            {
                connection.Open();
                string sql = @"SELECT AttendanceName, LogType, TimeStamp FROM AttendanceRecords WHERE SchoolStudentId = @SchoolStudentId AND IsPaid = 0";
                var parameters = new DynamicParameters();
                parameters.Add("SchoolStudentId", schoolStudentId);
                var records = connection.Query<AttendanceRecordsDTO>(sql, parameters).ToList();
                return records;
            }
        }
        private void btn_ResetRecord_Click(object sender, EventArgs e)
        {
            RecordLogs(_student.SchoolStudentId);
            ResetRecord(_student.SchoolStudentId);

            DialogResult result = XtraMessageBox.Show("Attendance record reset successfully.", "Success", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                RefreshForm();
            }
        }
        public void ResetRecord(string schoolStudentId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionStrng))
            {
                connection.Open();

                string sql = @"UPDATE AttendanceRecords
                               SET IsPaid = 1
                               WHERE SchoolStudentId = @SchoolStudentId AND IsPaid = 0";

                var paramaters = new DynamicParameters();
                paramaters.Add("SchoolStudentId", schoolStudentId);

                connection.Execute(sql, paramaters);
            }
        }
        public void RecordLogs(string schoolStudentId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionStrng))
            {
                connection.Open();
                // GET STUDENT ALL ATTENDANCE RECORDS
                string getRecordsSQL = @"SELECT AttendanceId, AttendanceName, LogType, SchoolStudentId, Name, Course, YearLevel, TimeStamp
                                        FROM AttendanceRecords
    q                                   WHERE SchoolStudentId = @SchoolStudentId AND IsPaid = 0";

                var parameters = new DynamicParameters();
                parameters.Add("SchoolStudentId", schoolStudentId);
                var records = connection.Query(getRecordsSQL, parameters).ToList();

                // INSERT TO LOGS TABLE
                string insertToLogSQL = @"INSERT INTO Logs
                                        (AttendanceId, AttendanceName, LogType, SchoolStudentId, Name, Course, YearLevel, TimeStamp)
                                        VALUES 
                                        (@AttendanceId, @AttendanceName, @LogType, @SchoolStudentId, @Name, @Course, @YearLevel, @TimeStamp)";

                foreach (var record in records)
                {
                    var logParameters = new DynamicParameters();
                    logParameters.Add("AttendanceId", record.AttendanceId);
                    logParameters.Add("AttendanceName", record.AttendanceName);
                    logParameters.Add("LogType", record.LogType);
                    logParameters.Add("SchoolStudentId", record.SchoolStudentId);
                    logParameters.Add("Name", record.Name);
                    logParameters.Add("Course", record.Course);
                    logParameters.Add("YearLevel", record.YearLevel);
                    logParameters.Add("TimeStamp", record.TimeStamp);
                    connection.Execute(insertToLogSQL, logParameters);
                }
            }
        }
        private bool IsAttendanceReset(string schoolStudentId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionStrng))
            {
                connection.Open();

                string sql = @"SELECT COUNT(*) FROM AttendanceRecords 
                       WHERE SchoolStudentId = @SchoolStudentId AND IsPaid = 0";

                var parameters = new DynamicParameters();
                parameters.Add("SchoolStudentId", schoolStudentId);

                int unpaidCount = connection.ExecuteScalar<int>(sql, parameters);

                return unpaidCount == 0; // If no unpaid records remain, reset is successful
            }
        }
        private void RefreshForm()
        {
            gc_AttendanceRecord.DataSource = GetAttendanceRecords(_student.SchoolStudentId);
            gc_AttendanceRecord.RefreshDataSource();

            int totalPresent = _attendanceService.GetTotalPresent(_student.SchoolStudentId);
            txt_TotalPresent.EditValue = totalPresent.ToString();
            if (IsAttendanceReset(_student.SchoolStudentId))
            {
                txt_TotalAbsent.EditValue = "0"; // Records successfully reset
            }
            else
            {
                int totalAbsent = _attendanceService.GetTotalAbsent(_student.SchoolStudentId);
                txt_TotalAbsent.EditValue = totalAbsent.ToString();
            }
        }
        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
    }
}
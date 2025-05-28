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
using AttendanceManagementSystem.Forms.Events;
using AttendanceManagementSystem.Forms.Dashboard;
using AttendanceManagementSystem.Forms.Students;
using AttendanceManagementSystem.Forms.QRScanner;
using AttendanceManagementSystem.Forms.Attendance_Report;
using AttendanceManagementSystem.Forms.Attendance_Record;
using AttendanceManagementSystem.Forms.Auth;
using DevExpress.XtraBars.Navigation;
using AttendanceManagementSystem.Interfaces.Repositories;
using AttendanceManagementSystem.Data.Repositories;
using AttendanceManagementSystem.Forms.Reports;
using AttendanceManagementSystem.DTO;
using AttendanceManagementSystem.Interfaces.Services;
using AttendanceManagementSystem.Services;
using DevExpress.XtraReports.UI;

namespace AttendanceManagementSystem.Forms
{
	public partial class MainForm: DevExpress.XtraEditors.XtraForm
	{
        private readonly IStudentsRepository _studentsRepository;
        private readonly IAttendanceService _attendanceService;

        public MainForm()
		{
            InitializeComponent();
            _studentsRepository = new StudentsRepository();
            _attendanceService = new AttendanceService();

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Dashboard_UserControl dashboard_UserControl = new Dashboard_UserControl();
            dashboard_UserControl.Dock = DockStyle.Fill;
            panel_Body.Controls.Clear();
            panel_Body.Controls.Add(dashboard_UserControl);
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            Dashboard_UserControl dashboard_UserControl = new Dashboard_UserControl();
            dashboard_UserControl.Dock = DockStyle.Fill;
            panel_Body.Controls.Clear();
            panel_Body.Controls.Add(dashboard_UserControl);
        }
        private void btn_Attendance_Click(object sender, EventArgs e)
        {
            Attendance_UserControl attendance_UserControl = new Attendance_UserControl();
            attendance_UserControl.Dock = DockStyle.Fill;
            panel_Body.Controls.Clear();
            panel_Body.Controls.Add(attendance_UserControl);
        }
        private void btn_Students_Click(object sender, EventArgs e)
        {
            Students_UserControl students_UserControl = new Students_UserControl();
            students_UserControl.Dock = DockStyle.Fill;
            panel_Body.Controls.Clear();
            panel_Body.Controls.Add(students_UserControl);
        }
        private void btn_AttendanceRecord_Click(object sender, EventArgs e)
        {
            AttendanceRecords_UserControl attendanceRecords_UserControl = new AttendanceRecords_UserControl();
            attendanceRecords_UserControl.Dock = DockStyle.Fill;
            panel_Body.Controls.Clear();
            panel_Body.Controls.Add(attendanceRecords_UserControl);
        }
        private void btn_QRScanner_Click(object sender, EventArgs e)
        {
            QRScanner_UserControl qrScanner_UserControl = new QRScanner_UserControl();
            qrScanner_UserControl.Dock = DockStyle.Fill;
            panel_Body.Controls.Clear();
            panel_Body.Controls.Add(qrScanner_UserControl);
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn_Form logIn_Form = new LogIn_Form();
            logIn_Form.ShowDialog();
        }
        private void btn_AllAttendanceReport_Click(object sender, EventArgs e)
        {
            AllAttendanceRecord_Form allAttendanceRecord_Form = new AllAttendanceRecord_Form();
            allAttendanceRecord_Form.ShowDialog();
        }
        private void btn_AllQRCodes_Click(object sender, EventArgs e)
        {
            AllQRCodes allQRCodes = new AllQRCodes();
            allQRCodes.ShowDialog();
        }

        private void btn_StudentsAttendance_Click(object sender, EventArgs e)
        {
            StudentsAttendance_Report studentsAttendance_Report = new StudentsAttendance_Report();
            studentsAttendance_Report.DataSource = GetStudentsAttendanceSummary();
            studentsAttendance_Report.ShowPreviewDialog();
        }

        public List<StudentsAttendanceDTO> GetStudentsAttendanceSummary()
        {
            var students = _studentsRepository.GetAllStudent();
            var result = new List<StudentsAttendanceDTO>();

            foreach (var student in students)
            {
                var attendanceSummary = new StudentsAttendanceDTO
                {
                    SchoolStudentId = student.SchoolStudentId,
                    Name = student.FullName,
                    Course = student.Course,
                    YearLevel = student.YearLevel,
                    TotalAbsent = _attendanceService.GetTotalAbsent(student.SchoolStudentId),
                };

                result.Add(attendanceSummary);
            }
            return result;
        }
    }
}
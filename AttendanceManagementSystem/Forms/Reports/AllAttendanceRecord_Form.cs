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
using DevExpress.XtraReports.UI;
using AttendanceManagementSystem.DTO;
using AttendanceManagementSystem.Interfaces.Repositories;
using AttendanceManagementSystem.Interfaces.Services;
using AttendanceManagementSystem.Data.Repositories;
using AttendanceManagementSystem.Services;

namespace AttendanceManagementSystem.Forms.Reports
{
	public partial class AllAttendanceRecord_Form: DevExpress.XtraEditors.XtraForm
	{
        private readonly IStudentsRepository _studentsRepository;
        private readonly IAttendanceService _attendanceService;
        public AllAttendanceRecord_Form()
		{
            InitializeComponent();
            _studentsRepository = new StudentsRepository();
            _attendanceService = new AttendanceService();
		}
        private void btn_Report_Click(object sender, EventArgs e)
        {
            StudentsAttendance_Report allAttendance_Report = new StudentsAttendance_Report();
            allAttendance_Report.DataSource = GetStudentsAttendanceSummary();
            allAttendance_Report.ShowPreviewDialog();
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
        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
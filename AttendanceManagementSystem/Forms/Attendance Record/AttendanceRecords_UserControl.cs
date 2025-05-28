using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using AttendanceManagementSystem.Interfaces.Repositories;
using AttendanceManagementSystem.Data.Repositories;
using AttendanceManagementSystem.Forms.Attendance_Report;
using System.Data.SqlTypes;
using System.IO;
using AttendanceManagementSystem.Models.Base;
using System.Web.UI.WebControls;
using AttendanceManagementSystem.Forms.Students;

namespace AttendanceManagementSystem.Forms.Attendance_Record
{
	public partial class AttendanceRecords_UserControl: DevExpress.XtraEditors.XtraUserControl
	{
		private readonly IStudentsRepository _studentsRepository;
        public AttendanceRecords_UserControl()
		{
            InitializeComponent();
			_studentsRepository = new StudentsRepository();
        }
        private void AttendanceRecords_UserControl_Load(object sender, EventArgs e)
        {
            gc_Students.DataSource = _studentsRepository.GetAllStudent();
        }
        private void repositoryItemButton_View_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Student selectedRow = gv_Students.GetFocusedRow() as Student;

            StudentAttendanceRecord_Form attendanceForm = new StudentAttendanceRecord_Form(selectedRow);
            attendanceForm.ShowDialog();
        }
        private void gv_Students_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txt_SchoolStudentId.Text = gv_Students.GetFocusedRowCellValue("SchoolStudentId").ToString();
            txt_Name.Text = gv_Students.GetFocusedRowCellValue("FullName").ToString();
            txt_Email.Text = gv_Students.GetFocusedRowCellValue("Email").ToString();
            txt_Course.Text = gv_Students.GetFocusedRowCellValue("Course").ToString();
            txt_YearLevel.Text = gv_Students.GetFocusedRowCellValue("YearLevel").ToString();
            var qrCodeValue = gv_Students.GetFocusedRowCellValue("QRCode");

            if (qrCodeValue != null && qrCodeValue is byte[] qrBytes)
            {
                using (MemoryStream ms = new MemoryStream(qrBytes))
                {
                    pe_QRCode.Image = System.Drawing.Image.FromStream(ms);
                }
            }
        }
        private void cbe_Course_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedCourse = cbe_FilterCourse.SelectedItem.ToString();
            gv_Students.ActiveFilterString = $"[Course] = '{selectedCourse}'";
        }
        private void cbe_YearLevel_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedYearLevel = cbe_FilterYearLevel.SelectedItem.ToString();
            gv_Students.ActiveFilterString = $"[YearLevel] = '{selectedYearLevel}'";
        }        
    }
}

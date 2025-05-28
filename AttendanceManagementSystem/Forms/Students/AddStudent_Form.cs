using System;
using DevExpress.XtraEditors;
using System.Data.SQLite;
using AttendanceManagementSystem.Models.Base;
using Dapper;
using AttendanceManagementSystem.Interfaces.Repositories;
using AttendanceManagementSystem.Data.Repositories;
using System.IO;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace AttendanceManagementSystem.Forms.Students
{
    public partial class AddStudent_Form : DevExpress.XtraEditors.XtraForm
    {
        private readonly IStudentsRepository _studentsRepository;
        private readonly IQRCodeService _qrCodeService;
        private Student student;
        public AddStudent_Form()
        {
            InitializeComponent();
            _studentsRepository = new StudentsRepository();
            _qrCodeService = new QRCodeService();

        }
        private void btn_Generate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_FirstName.Text) ||
                string.IsNullOrWhiteSpace(txt_LastName.Text) ||
                string.IsNullOrWhiteSpace(txt_SchoolStudentId.Text) ||
                string.IsNullOrWhiteSpace(se_YearLevel.Value.ToString()) ||
                string.IsNullOrWhiteSpace(cbe_Course.Text) ||
                string.IsNullOrWhiteSpace(txt_EmailAddress.Text))
            {
                XtraMessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                student = new Student
                (
                    firstName: txt_FirstName.Text,
                    middleName: txt_MiddleName.Text,
                    lastName: txt_LastName.Text,
                    schoolStudentId: txt_SchoolStudentId.Text,
                    yearLevel: (int)se_YearLevel.Value,
                    course: cbe_Course.Text,
                    email: txt_EmailAddress.Text
                );
                _qrCodeService.GenerateQRCode(student.SchoolStudentId);
                pe_QRCode.Image = _qrCodeService.GetQRCodeImage();
                student.QRCode = _qrCodeService.GetQRCodeByteArray();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error generating QR code: {ex.Message}");
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (student.QRCode == null)
            {
                XtraMessageBox.Show("Please generate a QR code before saving.");
                return;
            }
            try
            {
                _studentsRepository.AddStudent(student);
                XtraMessageBox.Show("Student saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error saving student: {ex.Message}");
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ClearFields()
        {
            txt_FirstName.Text = string.Empty;
            txt_MiddleName.Text = string.Empty;
            txt_LastName.Text = string.Empty;
            txt_SchoolStudentId.Text = string.Empty;
            se_YearLevel.Value = 1;
            cbe_Course.SelectedIndex = -1;
            txt_EmailAddress.Text = string.Empty;
            pe_QRCode.Image = null;
        }
    }
}
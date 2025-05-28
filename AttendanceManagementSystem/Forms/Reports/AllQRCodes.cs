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
using System.IO.Compression;
using System.IO;
using ZXing.QrCode;
using ZXing;
using AttendanceManagementSystem.Forms.Students;
using System.Data.SqlClient;
using AttendanceManagementSystem.Interfaces.Repositories;
using Dapper;
using System.Data.SQLite;
using AttendanceManagementSystem.Data.Repositories;

namespace AttendanceManagementSystem.Forms.Reports
{
    public partial class AllQRCodes : DevExpress.XtraEditors.XtraForm
    {
        private string _connectionStrng = "Data Source=SEAMS.db;Version=3;Mode=ReadWrite;";
        private IQRCodeService _qrCodeService;

        public AllQRCodes()
        {
            InitializeComponent();
            _qrCodeService = new QRCodeService();
        }

        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(out string selectedCourse, out string selectedYearLevel))
                return;

            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string downloadFolder = folderDialog.SelectedPath;
                    try
                    {
                        var students = GetStudents(selectedCourse, selectedYearLevel);
                        if (students.Count == 0)
                        {
                            XtraMessageBox.Show("No students found for the selected criteria.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        string sanitizedCourse = SanitizeName(selectedCourse).Replace(" ", "_");
                        string zipFilePath = Path.Combine(downloadFolder, $"QRCodes_of_{sanitizedCourse}_Course.zip");
                        GenerateZipFile(students, zipFilePath);

                        XtraMessageBox.Show($"{students.Count} QR Code/s have been successfully downloaded to {zipFilePath}.",
                            "Download Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show($"Error creating ZIP file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private bool ValidateInputs(out string course, out string yearLevel)
        {
            course = cbe_FilterCourse.SelectedItem?.ToString();
            yearLevel = cbe_FilterYearLevel.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(course))
            {
                XtraMessageBox.Show("Please select a course.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(yearLevel))
            {
                XtraMessageBox.Show("Please select a year level.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private List<Student> GetStudents(string course, string yearLevel)
        {
            using (var connection = new SQLiteConnection(_connectionStrng))
            {
                connection.Open();
                string sql = @"
                    SELECT SchoolStudentId, LastName, FirstName 
                    FROM Student 
                    WHERE (Course = @Course OR @Course IS NULL) 
                    AND (YearLevel = @YearLevel OR @YearLevel IS NULL)";
                var parameters = new DynamicParameters();
                parameters.Add("@Course", course == "All Courses" ? (object)DBNull.Value : course);
                parameters.Add("@YearLevel", yearLevel == "All Year Level" ? (object)DBNull.Value : yearLevel);
                return connection.Query<Student>(sql, parameters).ToList();
            }
        }
        private void GenerateZipFile(List<Student> students, string zipFilePath)
        {
            using (var zipStream = new FileStream(zipFilePath, FileMode.Create))
            using (var zipArchive = new ZipArchive(zipStream, ZipArchiveMode.Create))
            {
                foreach (var student in students)
                {
                    _qrCodeService.GenerateQRCode(student.SchoolStudentId);
                    using (var qrCodeImage = _qrCodeService.GetQRCodeImage())
                    {
                        if (qrCodeImage == null) continue;
                        string entryName = $"{SanitizeName(student.LastName)}_{SanitizeName(student.FirstName)}.png";
                        var zipEntry = zipArchive.CreateEntry(entryName);
                        using (var entryStream = zipEntry.Open())
                        {
                            qrCodeImage.Save(entryStream, System.Drawing.Imaging.ImageFormat.Png);
                        }
                    }
                }
            }
        }
        private void AllQRCodes_Load(object sender, EventArgs e)
        {
            PopulateComboBoxes();
        }
        private void PopulateComboBoxes()
        {
            try
            {
                using (var connection = new SQLiteConnection(_connectionStrng))
                {
                    connection.Open();
                    var courses = connection.Query<string>("SELECT DISTINCT Course FROM Student").ToList();
                    cbe_FilterCourse.Properties.Items.AddRange(courses);
                    var yearLevels = connection.Query<string>("SELECT DISTINCT YearLevel FROM Student").ToList();
                    cbe_FilterYearLevel.Properties.Items.AddRange(yearLevels);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error loading combo boxes: {ex.Message}");
            }
        }
        // Helper method to sanitize names for filenames
        private string SanitizeName(string name)
        {
            var invalidChars = Path.GetInvalidFileNameChars();
            return new string(name.Select(c => invalidChars.Contains(c) ? '_' : c).ToArray());
        }
    }
}
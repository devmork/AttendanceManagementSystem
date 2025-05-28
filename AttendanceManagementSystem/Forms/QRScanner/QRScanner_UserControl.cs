using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using AttendanceManagementSystem.Interfaces.Repositories;
using AttendanceManagementSystem.Data.Repositories;
using AttendanceManagementSystem.Models.Base;
using DevExpress.Utils.MVVM;
using ZXing;
using OpenCvSharp.Extensions;
using OpenCvSharp;
using AttendanceManagementSystem.Utilities;
using AttendanceManagementSystem.Interfaces.Utilities;
using AttendanceManagementSystem.Interfaces.Services;
using AttendanceManagementSystem.Services;

namespace AttendanceManagementSystem.Forms.QRScanner
{
    public partial class QRScanner_UserControl : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly IAttendanceService _attendanceService;
        private readonly IAttendanceRepository _attendanceRepository;
        private readonly IQRScannerHelper _qrScannerHelper;
        private readonly IStudentsRepository _studentsRepository;

        private List<Attendance> allAttendance;
        private int selectedAttendanceId = -1;
        private bool isScanning;
        private VideoCapture videoCapture; // WEBCAM CAPTURE OBJECT
        private Timer timer = new Timer(); // CAPTURE FRAME AND PROCESS FRAME\
        public QRScanner_UserControl()
        {
            InitializeComponent();
            _attendanceService = new AttendanceService();
            _attendanceRepository = new AttendanceRepository();
            _qrScannerHelper = new QRScannerHelper();
            _studentsRepository = new StudentsRepository();
            timer.Interval = 30;
            timer.Tick += FrameScanner;
            LoadActiveAttendance();


        }
        private void QRScanner_UserControl_Load(object sender, EventArgs e)
        {
            

        }
        private void LoadActiveAttendance()
        {
            allAttendance = _attendanceRepository.GetAllAttendance();
            cbe_ChooseAttendance.Properties.Items.Clear();

            DateTime now = DateTime.Now;
            foreach (var attendance in allAttendance)
            {
                if (now >= attendance.StartTime && now <= attendance.EndTime)
                {
                    cbe_ChooseAttendance.Properties.Items.Add($"{attendance.AttendanceId} - {attendance.AttendanceName} - {attendance.LogType}");
                }
            }
            if (cbe_ChooseAttendance.Properties.Items.Count == 0)
            {
                cbe_ChooseAttendance.Enabled = false;
            }
            else
            {
                cbe_ChooseAttendance.Enabled = true;
            }
        }
        private void cbe_ChooseAttendance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbe_ChooseAttendance.SelectedIndex >= 0)
            {
                string selectedItem = cbe_ChooseAttendance.SelectedItem.ToString();
                foreach (var attendance in allAttendance)
                {
                    string itemValue = $"{attendance.AttendanceId} - {attendance.AttendanceName} - {attendance.LogType}";
                    if (itemValue == selectedItem)
                    {
                        selectedAttendanceId = attendance.AttendanceId;
                        break;
                    }
                }
            }
            else
            {
                selectedAttendanceId = -1;
            }
        }

        private void btn_StartScan_Click(object sender, EventArgs e)
        {
            if (selectedAttendanceId == -1)
            {
                XtraMessageBox.Show("Please select an attendance first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (isScanning)
            {
                XtraMessageBox.Show("Scanning is already in progress.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txt_QRValue.Text = "Scanning....";
            videoCapture = new VideoCapture(0);
            if (!videoCapture.IsOpened())
            {
                XtraMessageBox.Show("Unable to access the webcam.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                videoCapture = null;
                isScanning = false;
                txt_QRValue.Text = "Start Scanning";
                return;
            }
            isScanning = true;
            timer.Start();
        }
        private void FrameScanner(object sender, EventArgs e)
        {
            if (!isScanning || !videoCapture.IsOpened())
            {
                return;
            }

            using (Mat frame = new Mat())
            {
                if (videoCapture.Read(frame) && !frame.Empty())
                {
                    Cv2.Resize(frame, frame, new OpenCvSharp.Size(pe_QRCamera.Width, pe_QRCamera.Height));

                    // Convert and dispose Bitmap properly
                    using (Bitmap bitmap = BitmapConverter.ToBitmap(frame))
                    {
                        // Update UI thread safely
                        if (pe_QRCamera.InvokeRequired)
                        {
                            pe_QRCamera.Invoke(new Action(() => pe_QRCamera.Image = (Bitmap)bitmap.Clone()));
                        }
                        else
                        {
                            pe_QRCamera.Image = (Bitmap)bitmap.Clone();
                        }

                        try
                        {
                            string qrCodeText = _qrScannerHelper.DecodeQRCode(bitmap);
                            if (!string.IsNullOrEmpty(qrCodeText))
                            {
                                string schoolStudentId = qrCodeText; // QR code contains only SchoolStudentId
                                var student = _studentsRepository.GetStudentById(schoolStudentId);
                                if (student == null)
                                {
                                    XtraMessageBox.Show("Student not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                var selectedAttendance = allAttendance.FirstOrDefault(a => a.AttendanceId == selectedAttendanceId);
                                if (selectedAttendance == null)
                                {
                                    XtraMessageBox.Show("Selected attendance not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                _attendanceService.RecordAttendance(
                                    selectedAttendanceId,
                                    selectedAttendance.AttendanceName,
                                    selectedAttendance.LogType,
                                    schoolStudentId,
                                    student.FullName,
                                    student.Course,
                                    student.YearLevel
                                );

                                txt_QRValue.Text = $"Scanned: {student.FirstName} {student.LastName}";
                                XtraMessageBox.Show("Attendance recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txt_QRValue.Text = "Scanning..."; // Reset to indicate continuous scanning
                            }
                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show($"Error processing QR code: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btn_StopScan_Click(object sender, EventArgs e)
        {
            if (!isScanning) return;
            isScanning = false;
            timer.Stop();
            if (videoCapture != null)
            {
                videoCapture.Release();
                videoCapture.Dispose();
                videoCapture = null;
            }
            pe_QRCamera.Image = null;
            txt_QRValue.Text = "Start Scanning";
        }
    }
}
﻿using System;
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
namespace AttendanceManagementSystem.Forms.QRScanner
{
	public partial class QRScanner_UserControl: DevExpress.XtraEditors.XtraUserControl
	{
        private readonly IAttendanceRepository _attendanceRepository;
        private readonly IQRScannerHelper _qrScannerHelper;
        private readonly IStudentsRepository _studentsRepository;
        private VideoCapture capture;
        private Timer frameTimer = new Timer();
        private List<Attendance> attendances; // Store attendance list for mapping
        private int selectedAttendanceId = -1; // Track selected AttendanceId
        public QRScanner_UserControl()
		{
            InitializeComponent();
            _attendanceRepository = new AttendanceRepository();
            _qrScannerHelper = new QRScannerHelper();
            _studentsRepository = new StudenstRepository();
            frameTimer.Interval = 30;
            frameTimer.Tick += FrameTimer_Tick;
        }
        private void QRScanner_UserControl_Load(object sender, EventArgs e)
        {
            attendances = _attendanceRepository.GetAllAttendance();
            foreach (var attendance in attendances)
            {
                cbe_ChooseAttendance.Properties.Items.Add($"{attendance.AttendanceId} - {attendance.AttendanceName} - {attendance.LogType}");
            }
        }
        private void cbe_ChooseAttendance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbe_ChooseAttendance.SelectedIndex >= 0 && attendances != null)
            {
                string selectedItem = cbe_ChooseAttendance.SelectedItem.ToString();
                var selectedAttendance = attendances.FirstOrDefault(a => $"{a.AttendanceId} - {a.AttendanceName} - {a.LogType}" == selectedItem);
                selectedAttendanceId = selectedAttendance?.AttendanceId ?? -1;
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
                XtraMessageBox.Show("Please select an attendance event.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txt_QRValue.Text = "Scanning...";
            capture = new VideoCapture(0);
            if (!capture.IsOpened())
            {
                XtraMessageBox.Show("Unable to access the webcam.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frameTimer.Start();
        }
        private void FrameTimer_Tick(object sender, EventArgs e)
        {
            using (Mat frame = new Mat())
            {
                if (capture.Read(frame) && !frame.Empty())
                {
                    // Resize the frame to fit the PictureEdit control
                    Cv2.Resize(frame, frame, new OpenCvSharp.Size(pe_QRCamera.Width, pe_QRCamera.Height));

                    // Convert the OpenCvSharp Mat to a Bitmap for display and scanning
                    Bitmap bitmap = BitmapConverter.ToBitmap(frame);
                    pe_QRCamera.Image = bitmap;
                     
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

                            if (selectedAttendanceId == -1 || attendances == null)
                            {
                                XtraMessageBox.Show("Please select an attendance event.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            var selectedAttendance = attendances.FirstOrDefault(a => a.AttendanceId == selectedAttendanceId);
                            if (selectedAttendance == null)
                            {
                                XtraMessageBox.Show("Selected attendance not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            _attendanceRepository.RecordAttendance(
                                selectedAttendanceId,
                                selectedAttendance.AttendanceName,
                                selectedAttendance.LogType,
                                schoolStudentId
                            );

                            frameTimer.Stop();
                            txt_QRValue.Text = $"Attendance Recorded: {student.FirstName} {student.LastName}";
                            XtraMessageBox.Show("Attendance recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show($"Error processing QR code: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btn_StopScan_Click(object sender, EventArgs e)
        {
            StopCamera();
        }
        private void StopCamera()
        {
            frameTimer.Stop();
            if (capture != null && capture.IsOpened())
            {
                capture.Release();
                capture.Dispose();
            }
            pe_QRCamera.Image = null;
        }

        
    }
}

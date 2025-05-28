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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using AttendanceManagementSystem.Models.Base;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace AttendanceManagementSystem.Forms.Events
{
    public partial class Attendance_UserControl : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly IAttendanceRepository _attendanceRepository;
        public Attendance_UserControl()
        {
            InitializeComponent();
            _attendanceRepository = new AttendanceRepository();
        }
        private void gc_Attendance_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btn_AddAttendance_Click(object sender, EventArgs e)
        {
            AddAttendance_Form addAttendance_Form = new AddAttendance_Form();

            if (addAttendance_Form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }   
        private void repositoryItem_ActionButton_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
            {
                Attendance selectedRow = gv_Attendance.GetFocusedRow() as Attendance;
                EditAttendance_Form editAttendance_Form = new EditAttendance_Form(selectedRow);
                if (editAttendance_Form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
            else if (e.Button.Index == 1)
            {
                if (XtraMessageBox.Show("Are you sure you want to delete this attendance?", "Delete Attendance", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Attendance selectedRow = gv_Attendance.GetFocusedRow() as Attendance;

                    _attendanceRepository.DeleteAttendance(selectedRow.AttendanceId);
                    XtraMessageBox.Show("Attendance deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
        }
        private void gv_Attendance_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "Status")
            {
                var row = gv_Attendance.GetRow(e.ListSourceRowIndex) as Attendance;

                bool isActive = DateTime.Now >= row.StartTime && DateTime.Now <= row.EndTime;
                e.DisplayText = isActive ? "ACTIVE" : "INACTIVE";
            }
        }
        private void LoadData()
        {
            gc_Attendance.DataSource = _attendanceRepository.GetAllAttendance();
        }  
    }
}

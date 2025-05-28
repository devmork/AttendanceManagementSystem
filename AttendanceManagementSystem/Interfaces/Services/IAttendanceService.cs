using AttendanceManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.Interfaces.Services
{
    public interface IAttendanceService
    {
        void RecordAttendance(int attendanceId, string attendanceName, string logType, string schoolStudentId, string name, string course, int yearLevel);
        int GetTotalAbsent(string schoolStudentId);
        int GetTotalPresent(string schoolStudentId);
    }
}

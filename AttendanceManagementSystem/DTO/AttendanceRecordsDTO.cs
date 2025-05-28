using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.DTO
{
    public class AttendanceRecordsDTO
    {
        public string AttendanceName { get; set; }
        public string LogType { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}

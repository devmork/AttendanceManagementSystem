using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.DTO
{
    public class StudentsAttendanceDTO
    {
        public string SchoolStudentId { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public int YearLevel { get; set; }
        public int TotalAbsent { get; set; }
    }
}

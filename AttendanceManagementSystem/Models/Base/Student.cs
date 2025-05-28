using AttendanceManagementSystem.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing.QrCode.Internal;

namespace AttendanceManagementSystem.Models.Base
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SchoolStudentId { get; set; }
        public int YearLevel { get; set; }
        public string Course { get; set; }
        public string Email { get; set; }
        public byte[] QRCode { get; set; }
        public Student(string firstName, string middleName, string lastName, string schoolStudentId, int yearLevel, string course, string email)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            SchoolStudentId = schoolStudentId;
            YearLevel = yearLevel;
            Course = course;
            Email = email;
        }
        public string FullName
        {
            get
            {
                return $"{FirstName} {MiddleName} {LastName}";
            }
        }
        public Student() { }
        
    }
}

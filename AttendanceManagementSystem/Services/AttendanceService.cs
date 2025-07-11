﻿using AttendanceManagementSystem.DTO;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.Services
{
    public class AttendanceService
    {
        private static string _connectionString = "Data Source=SEAMS.db;Version=3;Mode=ReadWrite;";
        public static void RecordAttendance(int attendanceId, string attendanceName, string logType, string schoolStudentId, string name, string course, string yearLevel)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                var parameters = new DynamicParameters();
                parameters.Add("AttendanceId", attendanceId);
                parameters.Add("SchoolStudentId", schoolStudentId);

                // Check if attendance id exist
                string checkAttendanceSql = "SELECT COUNT(AttendanceId) FROM Attendance WHERE AttendanceId = @AttendanceId";
                if (connection.ExecuteScalar<int>(checkAttendanceSql, parameters) == 0)
                {
                    throw new Exception("Invalid AttendanceId.");
                }

                // Check if student id exist
                string checkStudentIdSql = "SELECT COUNT(SchoolStudentId) FROM Student WHERE SchoolStudentId = @SchoolStudentId";
                if (connection.ExecuteScalar<int>(checkStudentIdSql, parameters) == 0)
                {
                    throw new Exception("Invalid school student id.");
                }
                  
                // Check for duplicate attendance record
                string checkDuplicateSql = "SELECT COUNT(*) FROM AttendanceRecords WHERE AttendanceId = @AttendanceId AND SchoolStudentId = @SchoolStudentId AND DATE(Timestamp) = DATE('now')";
                if (connection.ExecuteScalar<int>(checkDuplicateSql, parameters) > 0)
                {
                    throw new Exception("Attendance already recorded for this student today.");
                }

                string sql = @"INSERT INTO AttendanceRecords (AttendanceId, AttendanceName, LogType, SchoolStudentId, Name, Course, YearLevel, Timestamp, IsPaid) 
                               VALUES (@AttendanceId, @AttendanceName, @LogType, @SchoolStudentId, @Name, @Course, @YearLevel, @Timestamp, @IsPaid)";

                parameters.Add("AttendanceName", attendanceName);
                parameters.Add("LogType", logType);
                parameters.Add("Name", name);
                parameters.Add("Course", course); ;
                parameters.Add("YearLevel", yearLevel);
                parameters.Add("Timestamp", DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
                parameters.Add("IsPaid", 0);
                connection.Execute(sql, parameters);
            }   
        }
        
        public static int GetTotalAbsent(string schoolStudentId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                int allAttendanceId = GetAttendanceCount();
                string presentAttendanceIdSQL = @"SELECT COUNT(*) FROM AttendanceRecords 
                                                WHERE SchoolStudentId = @SchoolStudentId AND IsPaid = 0";

                var parameters = new DynamicParameters();
                parameters.Add("SchoolStudentId", schoolStudentId);
                int presentAttendanceIdCount = connection.ExecuteScalar<int>(presentAttendanceIdSQL, parameters);

                return allAttendanceId - presentAttendanceIdCount;
            }
        }
        public static int GetTotalPresent(string schoolStudentId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string sql = @"SELECT COUNT (AttendanceId) FROM AttendanceRecords WHERE SchoolStudentId = @SchoolStudentId AND IsPaid = 0";

                var parameters = new DynamicParameters();
                parameters.Add("SchoolStudentId", schoolStudentId);
                return connection.ExecuteScalar<int>(sql, parameters);
            }
        }
        public static int GetAttendanceCount()
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string getAttendaceCountSQL = @"SELECT COUNT(AttendanceId) FROM Attendance";
                return connection.ExecuteScalar<int>(getAttendaceCountSQL);
            }
        }
    }
}

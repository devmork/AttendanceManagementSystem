﻿using AttendanceManagementSystem.Interfaces.Repositories;
using AttendanceManagementSystem.Models.Base;
using Dapper;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.IO;
using System.Linq;
using ZXing.QrCode.Internal;

namespace AttendanceManagementSystem.Data.Repositories
{
    public class AttendanceRepository : IAttendanceRepository
    {
        private string _connectionStrng = "Data Source=SEAMS.db;Version=3;Mode=ReadWrite;";
        public void AddAttendance(Attendance attendance)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionStrng))
            {
                connection.Open();
                string sql = 
                     @"INSERT INTO Attendance
                     (AttendanceName, AttendanceLocation, LogType, Date, StartTime, EndTime)
                     VALUES (@AttendanceName, @AttendanceLocation, @LogType, @Date, @StartTime, @EndTime)";

                var parameters = new DynamicParameters();
                parameters.Add("AttendanceName", attendance.AttendanceName);
                parameters.Add("AttendanceLocation", attendance.AttendanceLocation);
                parameters.Add("LogType", attendance.LogType);
                parameters.Add("Date", attendance.Date.ToString("yyyy-MM-dd"));
                parameters.Add("StartTime", attendance.StartTime.ToString("hh:mm tt"));
                parameters.Add("EndTime", attendance.EndTime.ToString("hh:mm tt"));
                connection.Execute(sql, parameters);
            }
        }
        public List<Attendance> GetAllAttendance()
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionStrng))
            {
                connection.Open();
                string sql =
                    @"SELECT AttendanceId, AttendanceName, AttendanceLocation, LogType, Date, StartTime, EndTime
                    FROM Attendance";
                var attendance = connection.Query<Attendance>(sql).ToList();
                return attendance;
            }
        }
        public void DeleteAttendance(int attendanceId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionStrng))
            {
                connection.Open();
                string sql = "DELETE FROM Attendance WHERE AttendanceId = @AttendanceId";
                var parameters = new DynamicParameters();
                parameters.Add("AttendanceId", attendanceId);  // 'attendanceId' matches the parameter name
                connection.Execute(sql, parameters);
            }
        }
        public void UpdateAttendance(Attendance attendance)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionStrng))
            {
                connection.Open();
                string sql =
                       @"UPDATE Attendance 
                       SET AttendanceName = @AttendanceName, 
                           AttendanceLocation = @AttendanceLocation, 
                           LogType = @LogType, 
                           Date = @Date, 
                           StartTime = @StartTime, 
                           EndTime = @EndTime
                       WHERE AttendanceId = @AttendanceId";

                var parameters = new DynamicParameters();
                parameters.Add("AttendanceId", attendance.AttendanceId);
                parameters.Add("AttendanceName", attendance.AttendanceName);
                parameters.Add("AttendanceLocation", attendance.AttendanceLocation);
                parameters.Add("LogType", attendance.LogType);
                parameters.Add("Date", attendance.Date.ToString("yyyy-MM-dd"));
                parameters.Add("StartTime", attendance.StartTime.ToString("hh:mm tt"));
                parameters.Add("EndTime", attendance.EndTime.ToString("hh:mm tt"));
                connection.Execute(sql, parameters);
            }
        }
        public int GetTotalAttendance()
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionStrng))
            {
                connection.Open();
                string sql = @"SELECT COUNT(AttendanceName) FROM Attendance";
                return connection.ExecuteScalar<int>(sql);
            }
        }

        public void RecordAttendance(int attendanceId, string attendanceName, string logType, string schoolStudentId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionStrng))
            {
                connection.Open();
                var parameters = new DynamicParameters();

                // Validate AttendanceId exists
                string checkAttendanceSql = "SELECT COUNT(AttendanceId) FROM Attendance WHERE AttendanceId = @AttendanceId";
                parameters.Add("AttendanceId", attendanceId);
                if (connection.ExecuteScalar<int>(checkAttendanceSql, parameters) == 0)
                {
                    throw new Exception("Invalid AttendanceId.");
                }

                // Validate StudentId and QRCode match
                string checkStudentIdSql = "SELECT COUNT(SchoolStudentId) FROM Student WHERE SchoolStudentId = @SchoolStudentId";
                parameters.Add("SchoolStudentId", schoolStudentId);
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

                string sql =
                      @"INSERT INTO AttendanceRecords (AttendanceId, AttendanceName, LogType, SchoolStudentId, Timestamp, Remarks) 
                      VALUES (@AttendanceId, @AttendanceName, @LogType, @SchoolStudentId, @Timestamp, @Remarks)";

                parameters.Add("AttendanceId", attendanceId);
                parameters.Add("AttendanceName", attendanceName);
                parameters.Add("LogType", logType);
                parameters.Add("SchoolStudentId", schoolStudentId);
                parameters.Add("Timestamp", DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
                parameters.Add("Remarks", "Present");
                connection.Execute(sql, parameters);
            }
        }
    }
}


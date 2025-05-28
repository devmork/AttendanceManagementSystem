using AttendanceManagementSystem.Interfaces.Repositories;
using AttendanceManagementSystem.Models.Derived;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private string _connectionStrng = "Data Source=SEAMS.db;Version=3;Mode=ReadWrite;";
        public void AddUser(User user)
        {
            using (var connection = new SQLiteConnection(_connectionStrng))
            {
                connection.Open();
                string sql = @"INSERT INTO Users (UserName, Email, Password)
                             VALUES (@UserName, @Email, @Password);";
                
                var parameters = new DynamicParameters();
                parameters.Add("@UserName", user.UserName);
                parameters.Add("@Email", user.Email);
                parameters.Add("@Password", user.Password);
                connection.Execute(sql, parameters);
            }
        }
        public User GetUserByEmail(string email)
        {
            using (var connection = new SQLiteConnection(_connectionStrng))
            {
                connection.Open();
                string sql = "SELECT Email FROM Users WHERE Email = @Email;";
                return connection.QueryFirstOrDefault<User>(sql, new { Email = email });
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using AttendanceManagementSystem.Interfaces.Repositories;
using AttendanceManagementSystem.Data.Repositories;
using AttendanceManagementSystem.Models.Derived;

namespace AttendanceManagementSystem.Forms.Auth
{
	public partial class SignUp_Form: DevExpress.XtraEditors.XtraForm
	{
        private readonly IUserRepository _userRepository;
        private User user;
        public SignUp_Form()
		{
            InitializeComponent();
            _userRepository = new UserRepository(); 
        }
        private void btn_CreateAccount_Click(object sender, EventArgs e)
        {
            string userName = txt_UserName.Text;
            string email = txt_Email.Text;
            string password = txt_Password.Text;

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                XtraMessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var existingUser = _userRepository.GetUserByEmail(email);
                if (existingUser != null)
                {
                    XtraMessageBox.Show("Email is already registered.", "Sign Up Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var newUser = new User
                {
                    UserName = userName,
                    Email = email,
                    Password = password
                };

                _userRepository.AddUser(newUser);
                XtraMessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFilds();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error during sign up: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label_LogInNow_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn_Form logInForm = new LogIn_Form();
            logInForm.Show();
        }
        private void ClearFilds()
        {
            txt_UserName.Text = string.Empty;
            txt_Email.Text = string.Empty;
            txt_Password.Text = string.Empty;
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
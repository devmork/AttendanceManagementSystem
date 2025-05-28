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

namespace AttendanceManagementSystem.Forms.Auth
{
	public partial class LogIn_Form: DevExpress.XtraEditors.XtraForm
	{
        private readonly IUserRepository _userRepository;
        public LogIn_Form()
		{
            InitializeComponent();
            _userRepository = new UserRepository(); 
        }
        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            string email = txt_Email.Text;
            string password = txt_Password.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                XtraMessageBox.Show("Please enter both email and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var user = _userRepository.GetUserByEmail(email);
                if (user != null && user.Password == password) 
                {
                    XtraMessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var mainForm = new MainForm();
                    mainForm.Show();
                    this.Close();
                }
                else
                {
                    ClearFilds();
                    XtraMessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error during login: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label_SignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp_Form signUpForm = new SignUp_Form();
            signUpForm.ShowDialog();
        }
        private void ClearFilds()
        {
            txt_Email.Text = string.Empty;
            txt_Password.Text = string.Empty;
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
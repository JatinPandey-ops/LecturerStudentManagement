using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace LecturerStudentManagement
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string fullName = txtFullName.Text;
            bool isLecturer = rbtnLecturer.Checked;
            bool isStudent = rbtnStudent.Checked;

            string connectionString = ConfigurationManager.ConnectionStrings["LecturerStudentDB"]?.ConnectionString;

            if (string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("Connection string is not found.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = isLecturer ?
                    "INSERT INTO Lecturers (Username, Password, FullName) VALUES (@Username, @Password, @FullName)" :
                    "INSERT INTO Students (Username, Password, FullName, PhoneNumber) VALUES (@Username, @Password, @FullName, @PhoneNumber)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    if (isStudent)
                    {
                        cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                    }

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration successful.");
                }
            }
        }
    }
}

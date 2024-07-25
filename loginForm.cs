using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace LecturerStudentManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
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
                    "SELECT * FROM Lecturers WHERE Username = @Username AND Password = @Password" :
                    "SELECT * FROM Students WHERE Username = @Username AND Password = @Password";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        string fullName = reader["FullName"].ToString();
                        if (isLecturer)
                        {
                            CurrentLecturer.Username = username;
                            CurrentLecturer.FullName = fullName;
                            MainForm mainForm = new MainForm(fullName);
                            mainForm.Show();
                        }
                        else
                        {
                            CurrentStudent.Username = username;
                            CurrentStudent.FullName = fullName;
                            StudentModuleForm studentModuleForm = new StudentModuleForm(fullName);
                            studentModuleForm.Show();
                        }
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}

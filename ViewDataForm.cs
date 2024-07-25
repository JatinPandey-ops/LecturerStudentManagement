using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace LecturerStudentManagement
{
    public partial class ViewDataForm : Form
    {
        public ViewDataForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["LecturerStudentDB"]?.ConnectionString;

            if (string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("Connection string is not found.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Students WHERE StudentID IN (SELECT StudentID FROM StudentCourses WHERE CourseID IN (SELECT CourseID FROM LecturerCourses WHERE LecturerID = (SELECT LecturerID FROM Lecturers WHERE Username = @Username)))", con))
                    {
                        cmd.Parameters.AddWithValue("@Username", CurrentLecturer.Username);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"An error occurred while connecting to the database: {ex.Message}");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}

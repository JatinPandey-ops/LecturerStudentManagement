using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace LecturerStudentManagement
{
    public partial class DropCourseForm : Form
    {
        public DropCourseForm()
        {
            InitializeComponent();
            LoadCourses();
        }

        private void LoadCourses()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["LecturerStudentDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT c.CourseCode FROM Courses c INNER JOIN LecturerCourses lc ON c.CourseID = lc.CourseID WHERE lc.LecturerID = @LecturerID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@LecturerID", CurrentLecturer.LecturerID);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cmbCourses.Items.Add(reader["CourseCode"].ToString());
                    }
                }
            }
        }

        private void btnDropCourse_Click(object sender, EventArgs e)
        {
            string courseCode = cmbCourses.SelectedItem.ToString();

            string connectionString = ConfigurationManager.ConnectionStrings["LecturerStudentDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "DELETE FROM Courses WHERE CourseCode = @CourseCode";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CourseCode", courseCode);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Course dropped successfully.");
                    this.Close();
                }
            }
        }
    }
}

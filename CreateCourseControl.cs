using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace LecturerStudentManagement
{
    public partial class CreateCourseControl : UserControl
    {
        public CreateCourseControl()
        {
            InitializeComponent();
        }

        private void btnCreateCourse_Click(object sender, EventArgs e)
        {
            string courseCode = txtCourseCode.Text;
            string courseName = txtCourseName.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["LecturerStudentDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO Courses (CourseCode, CourseName) VALUES (@CourseCode, @CourseName)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CourseCode", courseCode);
                    cmd.Parameters.AddWithValue("@CourseName", courseName);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Course created successfully.");
                }

                string linkQuery = "INSERT INTO LecturerCourses (LecturerID, CourseID) SELECT @LecturerID, CourseID FROM Courses WHERE CourseCode = @CourseCode";
                using (SqlCommand cmd = new SqlCommand(linkQuery, con))
                {
                    cmd.Parameters.AddWithValue("@LecturerID", CurrentLecturer.LecturerID);
                    cmd.Parameters.AddWithValue("@CourseCode", courseCode);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

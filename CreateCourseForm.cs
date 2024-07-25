using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace LecturerStudentManagement
{
    public partial class CreateCourseForm : Form
    {
        public CreateCourseForm()
        {
            InitializeComponent();
        }

        private void btnCreateCourse_Click(object sender, EventArgs e)
        {
            string courseCode = txtCourseCode.Text;
            string courseName = txtCourseName.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["LecturerStudentDB"]?.ConnectionString;

            if (string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("Connection string is not found.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Courses (CourseCode, CourseName) VALUES (@CourseCode, @CourseName); INSERT INTO LecturerCourses (LecturerID, CourseID) VALUES ((SELECT LecturerID FROM Lecturers WHERE Username = @Username), SCOPE_IDENTITY())", con))
                {
                    cmd.Parameters.AddWithValue("@CourseCode", courseCode);
                    cmd.Parameters.AddWithValue("@CourseName", courseName);
                    cmd.Parameters.AddWithValue("@Username", CurrentLecturer.Username);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Course created successfully.");
                }
            }
        }
    }
}

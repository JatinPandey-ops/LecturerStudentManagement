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
        }

        private void btnDropCourse_Click(object sender, EventArgs e)
        {
            string courseCode = txtCourseCode.Text;

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LecturerStudentDB"].ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Courses WHERE CourseCode = @CourseCode AND LecturerID = (SELECT LecturerID FROM Lecturers WHERE Username = @Username)", con))
                {
                    cmd.Parameters.AddWithValue("@CourseCode", courseCode);
                    cmd.Parameters.AddWithValue("@Username", CurrentLecturer.Username);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Course dropped successfully.");
                }
            }
        }
    }
}

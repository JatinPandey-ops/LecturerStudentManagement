using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace LecturerStudentManagement
{
    public partial class AssignStudentToCourseControl : UserControl
    {
        public AssignStudentToCourseControl()
        {
            InitializeComponent();
            LoadCourses();
            LoadStudents();
        }

        private void LoadCourses()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LecturerStudentDB"].ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT CourseID, CourseName FROM Courses", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        cmbCourses.DataSource = dt;
                        cmbCourses.DisplayMember = "CourseName";
                        cmbCourses.ValueMember = "CourseID";
                    }
                }
            }
        }

        private void LoadStudents()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LecturerStudentDB"].ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT MatricNumber, FullName FROM Students", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        cmbStudents.DataSource = dt;
                        cmbStudents.DisplayMember = "FullName";
                        cmbStudents.ValueMember = "MatricNumber";
                    }
                }
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            int courseId = Convert.ToInt32(cmbCourses.SelectedValue);
            string matricNumber = cmbStudents.SelectedValue.ToString();

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LecturerStudentDB"].ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO StudentCourses (MatricNumber, CourseID) VALUES (@MatricNumber, @CourseID)", con))
                {
                    cmd.Parameters.AddWithValue("@MatricNumber", matricNumber);
                    cmd.Parameters.AddWithValue("@CourseID", courseId);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Student assigned to course successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }
    }
}

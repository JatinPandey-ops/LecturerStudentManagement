using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace LecturerStudentManagement
{
    public partial class SearchByPhoneNumberForm : Form
    {
        public SearchByPhoneNumberForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string phoneNumber = txtPhoneNumber.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["LecturerStudentDB"]?.ConnectionString;

            if (string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("Connection string is not found.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Students WHERE PhoneNumber LIKE @PhoneNumber AND StudentID IN (SELECT StudentID FROM StudentCourses WHERE CourseID IN (SELECT CourseID FROM LecturerCourses WHERE LecturerID = (SELECT LecturerID FROM Lecturers WHERE Username = @Username)))", con))
                {
                    cmd.Parameters.AddWithValue("@PhoneNumber", $"%{phoneNumber}%");
                    cmd.Parameters.AddWithValue("@Username", CurrentLecturer.Username);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }
    }
}

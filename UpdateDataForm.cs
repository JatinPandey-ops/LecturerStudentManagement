using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace LecturerStudentManagement
{
    public partial class UpdateDataForm : Form
    {
        public UpdateDataForm()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string matricNo = txtMatricNo.Text;
            string fullName = txtFullName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string programCode = txtProgramCode.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["LecturerStudentDB"]?.ConnectionString;

            if (string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("Connection string is not found.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE Students SET FullName = @FullName, PhoneNumber = @PhoneNumber, ProgramCode = @ProgramCode WHERE MatricNo = @MatricNo AND StudentID IN (SELECT StudentID FROM StudentCourses WHERE CourseID IN (SELECT CourseID FROM LecturerCourses WHERE LecturerID = (SELECT LecturerID FROM Lecturers WHERE Username = @Username)))", con))
                {
                    cmd.Parameters.AddWithValue("@MatricNo", matricNo);
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    cmd.Parameters.AddWithValue("@ProgramCode", programCode);
                    cmd.Parameters.AddWithValue("@Username", CurrentLecturer.Username);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student data updated successfully.");
                }
            }
        }
    }
}

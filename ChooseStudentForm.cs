using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace LecturerStudentManagement
{
    public partial class ChooseStudentForm : Form
    {
        public ChooseStudentForm()
        {
            InitializeComponent();
            LoadRandomStudent();
        }

        private void LoadRandomStudent()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["LecturerStudentDB"]?.ConnectionString;

            if (string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("Connection string is not found.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM Students WHERE StudentID IN (SELECT StudentID FROM StudentCourses WHERE CourseID IN (SELECT CourseID FROM LecturerCourses WHERE LecturerID = (SELECT LecturerID FROM Lecturers WHERE Username = @Username))) ORDER BY NEWID()", con))
                {
                    cmd.Parameters.AddWithValue("@Username", CurrentLecturer.Username);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        lblStudentDetails.Text = $"Matric No: {reader["MatricNo"]}, Name: {reader["FullName"]}, Phone: {reader["PhoneNumber"]}, Program: {reader["ProgramCode"]}";
                    }
                }
            }
        }

        private void btnLoadStudent_Click(object sender, EventArgs e)
        {
            LoadRandomStudent();
        }
    }
}

using System;
using System.Data;
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
            LoadCourses();
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

        private void cmbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            if (cmbCourses.SelectedItem is DataRowView selectedRow)
            {
                int courseId = Convert.ToInt32(selectedRow["CourseID"]);

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LecturerStudentDB"].ConnectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT s.MatricNumber, s.FullName FROM Students s INNER JOIN StudentCourses sc ON s.MatricNumber = sc.MatricNumber WHERE sc.CourseID = @CourseID", con))
                    {
                        cmd.Parameters.AddWithValue("@CourseID", courseId);

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
        }

        private void cmbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStudentDetails();
        }

        private void LoadStudentDetails()
        {
            if (cmbStudents.SelectedItem is DataRowView selectedRow)
            {
                string matricNumber = selectedRow["MatricNumber"].ToString();

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LecturerStudentDB"].ConnectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Students WHERE MatricNumber = @MatricNumber", con))
                    {
                        cmd.Parameters.AddWithValue("@MatricNumber", matricNumber);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtMatricNumber.Text = reader["MatricNumber"].ToString();
                                txtFullName.Text = reader["FullName"].ToString();
                                txtPhoneNumber.Text = reader["PhoneNumber"].ToString();
                                txtProgramCode.Text = reader["ProgramCode"].ToString();
                            }
                        }
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string matricNumber = txtMatricNumber.Text;
            string fullName = txtFullName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string programCode = txtProgramCode.Text;

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LecturerStudentDB"].ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE Students SET FullName = @FullName, PhoneNumber = @PhoneNumber, ProgramCode = @ProgramCode WHERE MatricNumber = @MatricNumber", con))
                {
                    cmd.Parameters.AddWithValue("@MatricNumber", matricNumber);
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    cmd.Parameters.AddWithValue("@ProgramCode", programCode);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student details updated successfully.");
                }
            }
        }
    }
}

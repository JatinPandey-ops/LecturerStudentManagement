using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Data;

namespace LecturerStudentManagement
{
    public partial class StudentModuleForm : Form
    {
        public StudentModuleForm()
        {
            InitializeComponent();
            LoadPrograms();
        }

        private void LoadPrograms()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LecturerStudentDB"].ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT ProgramCode, ProgramName FROM Programs", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        cmbProgramCode.DataSource = dt;
                        cmbProgramCode.DisplayMember = "ProgramName";
                        cmbProgramCode.ValueMember = "ProgramCode";
                    }
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string matricNumber = txtMatricNumber.Text;
            string fullName = txtFullName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string programCode = cmbProgramCode.SelectedValue.ToString();

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LecturerStudentDB"].ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Students (MatricNumber, FullName, PhoneNumber, ProgramCode) VALUES (@MatricNumber, @FullName, @PhoneNumber, @ProgramCode)", con))
                {
                    cmd.Parameters.AddWithValue("@MatricNumber", matricNumber);
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    cmd.Parameters.AddWithValue("@ProgramCode", programCode);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student information submitted successfully.");
                }
            }
        }
    }
}

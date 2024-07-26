using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace LecturerStudentManagement
{
    public partial class SearchByPhoneNumberControl : UserControl
    {
        public SearchByPhoneNumberControl()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string phoneNumber = txtPhoneNumber.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["LecturerStudentDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT s.FullName, s.MatricNumber, s.PhoneNumber, s.ProgramCode FROM Students s WHERE s.PhoneNumber LIKE @PhoneNumber";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@PhoneNumber", "%" + phoneNumber + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }
    }
}

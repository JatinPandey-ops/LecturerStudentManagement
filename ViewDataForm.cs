﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace LecturerStudentManagement
{
    public partial class ViewDataForm : Form
    {
        public ViewDataForm()
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

        private void btnViewData_Click(object sender, EventArgs e)
        {
            int courseId = Convert.ToInt32(cmbCourses.SelectedValue);

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LecturerStudentDB"].ConnectionString))
            {
                con.Open();
                string query = "SELECT s.MatricNumber, s.FullName, s.PhoneNumber, s.ProgramCode " +
                               "FROM Students s " +
                               "INNER JOIN StudentCourses sc ON s.MatricNumber = sc.MatricNumber " +
                               "WHERE sc.CourseID = @CourseID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CourseID", courseId);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }
    }
}

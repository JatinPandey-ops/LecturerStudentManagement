using System;
using System.Windows.Forms;

namespace LecturerStudentManagement
{
    public partial class MainForm : Form
    {
        public MainForm(string fullName)
        {
            InitializeComponent();
            CurrentLecturer.FullName = fullName;
            lblFullName.Text = $"Welcome, {CurrentLecturer.FullName}";
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display home content
        }

        private void viewDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewDataForm viewDataForm = new ViewDataForm();
            viewDataForm.Show();
        }

        private void updateDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDataForm updateDataForm = new UpdateDataForm();
            updateDataForm.Show();
        }

        private void chooseStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseStudentForm chooseStudentForm = new ChooseStudentForm();
            chooseStudentForm.Show();
        }

        private void searchByPhoneNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchByPhoneNumberForm searchByPhoneNumberForm = new SearchByPhoneNumberForm();
            searchByPhoneNumberForm.Show();
        }

        private void createCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateCourseForm createCourseForm = new CreateCourseForm();
            createCourseForm.Show();
        }

        private void dropCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DropCourseForm dropCourseForm = new DropCourseForm();
            dropCourseForm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}

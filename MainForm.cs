using System;
using System.Windows.Forms;

namespace LecturerStudentManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblFullName.Text = CurrentLecturer.FullName;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Code to navigate to Home page
        }

        private void viewDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewDataForm viewDataForm = new ViewDataForm();
            viewDataForm.ShowDialog();
        }

        private void updateDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDataForm updateDataForm = new UpdateDataForm();
            updateDataForm.ShowDialog();
        }

        private void chooseStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseStudentForm chooseStudentForm = new ChooseStudentForm();
            chooseStudentForm.ShowDialog();
        }

        private void searchByPhoneNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchByPhoneNumberForm searchByPhoneNumberForm = new SearchByPhoneNumberForm();
            searchByPhoneNumberForm.ShowDialog();
        }

        private void createCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateCourseForm createCourseForm = new CreateCourseForm();
            createCourseForm.ShowDialog();
        }

        private void dropCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DropCourseForm dropCourseForm = new DropCourseForm();
            dropCourseForm.ShowDialog();
        }

        private void assignStudentToCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssignStudentToCourseForm assignStudentForm = new AssignStudentToCourseForm();
            assignStudentForm.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Code to logout and return to the login page
            this.Close();
        }
    }
}

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
            // Clear the panel and add home content if necessary
            panelMain.Controls.Clear();
        }

        private void viewDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadControl(new ViewDataControl());
        }

        private void updateDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadControl(new UpdateDataControl());
        }

        private void chooseStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadControl(new ChooseStudentControl());
        }

        private void searchByPhoneNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadControl(new SearchByPhoneNumberControl());
        }

        private void createCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadControl(new CreateCourseControl());
        }

        private void dropCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadControl(new DropCourseControl());
        }

        private void assignStudentToCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadControl(new AssignStudentToCourseControl());
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Code to logout and return to the login page
            this.Close();
        }

        private void LoadControl(UserControl userControl)
        {
            panelMain.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panelMain.Controls.Add(userControl);
        }
    }
}

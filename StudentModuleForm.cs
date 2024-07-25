using System;
using System.Windows.Forms;

namespace LecturerStudentManagement
{
    public partial class StudentModuleForm : Form
    {
        public StudentModuleForm(string fullName)
        {
            InitializeComponent();
            lblFullName.Text = $"Welcome, {fullName}";
        }
    }
}

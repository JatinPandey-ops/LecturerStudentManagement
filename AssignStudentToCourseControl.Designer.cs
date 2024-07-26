using System.Windows.Forms;
namespace LecturerStudentManagement
{
    partial class AssignStudentToCourseControl
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox cmbCourses;
        private ComboBox cmbStudents;
        private Button btnAssign;
        private Label lblCourses;
        private Label lblStudents;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbCourses = new System.Windows.Forms.ComboBox();
            this.cmbStudents = new System.Windows.Forms.ComboBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.lblCourses = new System.Windows.Forms.Label();
            this.lblStudents = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCourses
            // 
            this.cmbCourses.FormattingEnabled = true;
            this.cmbCourses.Location = new System.Drawing.Point(150, 30);
            this.cmbCourses.Name = "cmbCourses";
            this.cmbCourses.Size = new System.Drawing.Size(200, 24);
            this.cmbCourses.TabIndex = 0;
            // 
            // cmbStudents
            // 
            this.cmbStudents.FormattingEnabled = true;
            this.cmbStudents.Location = new System.Drawing.Point(150, 70);
            this.cmbStudents.Name = "cmbStudents";
            this.cmbStudents.Size = new System.Drawing.Size(200, 24);
            this.cmbStudents.TabIndex = 1;
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(150, 110);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(100, 30);
            this.btnAssign.TabIndex = 2;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Location = new System.Drawing.Point(50, 30);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(58, 17);
            this.lblCourses.TabIndex = 3;
            this.lblCourses.Text = "Courses";
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Location = new System.Drawing.Point(50, 70);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(65, 17);
            this.lblStudents.TabIndex = 4;
            this.lblStudents.Text = "Students";
            // 
            // AssignStudentToCourseForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.lblCourses);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.cmbStudents);
            this.Controls.Add(this.cmbCourses);
            this.Name = "AssignStudentToCourseForm";
            this.Text = "Assign Student To Course";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

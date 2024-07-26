using System.Windows.Forms;
namespace LecturerStudentManagement
{
    partial class DropCourseForm
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox cmbCourses;
        private Button btnDropCourse;
        private Label lblCourse;

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
            this.btnDropCourse = new System.Windows.Forms.Button();
            this.lblCourse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCourses
            // 
            this.cmbCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourses.FormattingEnabled = true;
            this.cmbCourses.Location = new System.Drawing.Point(150, 30);
            this.cmbCourses.Name = "cmbCourses";
            this.cmbCourses.Size = new System.Drawing.Size(200, 24);
            this.cmbCourses.TabIndex = 0;
            // 
            // btnDropCourse
            // 
            this.btnDropCourse.Location = new System.Drawing.Point(275, 70);
            this.btnDropCourse.Name = "btnDropCourse";
            this.btnDropCourse.Size = new System.Drawing.Size(75, 30);
            this.btnDropCourse.TabIndex = 1;
            this.btnDropCourse.Text = "Drop";
            this.btnDropCourse.UseVisualStyleBackColor = true;
            this.btnDropCourse.Click += new System.EventHandler(this.btnDropCourse_Click);
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(30, 33);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(58, 17);
            this.lblCourse.TabIndex = 2;
            this.lblCourse.Text = "Course:";
            // 
            // DropCourseForm
            // 
            this.ClientSize = new System.Drawing.Size(382, 113);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.btnDropCourse);
            this.Controls.Add(this.cmbCourses);
            this.Name = "DropCourseForm";
            this.Text = "Drop Course";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

using System.Windows.Forms;
namespace LecturerStudentManagement
{
    partial class CreateCourseForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtCourseCode;
        private TextBox txtCourseName;
        private Button btnCreateCourse;
        private Label lblCourseCode;
        private Label lblCourseName;

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
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.btnCreateCourse = new System.Windows.Forms.Button();
            this.lblCourseCode = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.Location = new System.Drawing.Point(150, 30);
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(200, 22);
            this.txtCourseCode.TabIndex = 0;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(150, 70);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(200, 22);
            this.txtCourseName.TabIndex = 1;
            // 
            // btnCreateCourse
            // 
            this.btnCreateCourse.Location = new System.Drawing.Point(275, 110);
            this.btnCreateCourse.Name = "btnCreateCourse";
            this.btnCreateCourse.Size = new System.Drawing.Size(75, 30);
            this.btnCreateCourse.TabIndex = 2;
            this.btnCreateCourse.Text = "Create";
            this.btnCreateCourse.UseVisualStyleBackColor = true;
            this.btnCreateCourse.Click += new System.EventHandler(this.btnCreateCourse_Click);
            // 
            // lblCourseCode
            // 
            this.lblCourseCode.AutoSize = true;
            this.lblCourseCode.Location = new System.Drawing.Point(30, 33);
            this.lblCourseCode.Name = "lblCourseCode";
            this.lblCourseCode.Size = new System.Drawing.Size(94, 17);
            this.lblCourseCode.TabIndex = 3;
            this.lblCourseCode.Text = "Course Code:";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(30, 73);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(98, 17);
            this.lblCourseName.TabIndex = 4;
            this.lblCourseName.Text = "Course Name:";
            // 
            // CreateCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 153);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.lblCourseCode);
            this.Controls.Add(this.btnCreateCourse);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.txtCourseCode);
            this.Name = "CreateCourseForm";
            this.Text = "Create Course";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

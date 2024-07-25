using System.Windows.Forms;
namespace LecturerStudentManagement
{
    partial class DropCourseForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtCourseCode;
        private Button btnDropCourse;
        private Label lblCourseCode;

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
            this.btnDropCourse = new System.Windows.Forms.Button();
            this.lblCourseCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.Location = new System.Drawing.Point(150, 30);
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(200, 22);
            this.txtCourseCode.TabIndex = 0;
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
            // lblCourseCode
            // 
            this.lblCourseCode.AutoSize = true;
            this.lblCourseCode.Location = new System.Drawing.Point(30, 33);
            this.lblCourseCode.Name = "lblCourseCode";
            this.lblCourseCode.Size = new System.Drawing.Size(94, 17);
            this.lblCourseCode.TabIndex = 2;
            this.lblCourseCode.Text = "Course Code:";
            // 
            // DropCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 113);
            this.Controls.Add(this.lblCourseCode);
            this.Controls.Add(this.btnDropCourse);
            this.Controls.Add(this.txtCourseCode);
            this.Name = "DropCourseForm";
            this.Text = "Drop Course";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

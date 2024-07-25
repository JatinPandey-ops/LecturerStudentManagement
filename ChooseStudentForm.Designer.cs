using System.Windows.Forms;
namespace LecturerStudentManagement
{
    partial class ChooseStudentForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblStudentDetails;
        private Button btnLoadStudent;

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
            this.lblStudentDetails = new System.Windows.Forms.Label();
            this.btnLoadStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStudentDetails
            // 
            this.lblStudentDetails.AutoSize = true;
            this.lblStudentDetails.Location = new System.Drawing.Point(30, 30);
            this.lblStudentDetails.Name = "lblStudentDetails";
            this.lblStudentDetails.Size = new System.Drawing.Size(103, 17);
            this.lblStudentDetails.TabIndex = 0;
            this.lblStudentDetails.Text = "Student Details";
            // 
            // btnLoadStudent
            // 
            this.btnLoadStudent.Location = new System.Drawing.Point(33, 70);
            this.btnLoadStudent.Name = "btnLoadStudent";
            this.btnLoadStudent.Size = new System.Drawing.Size(200, 30);
            this.btnLoadStudent.TabIndex = 1;
            this.btnLoadStudent.Text = "Load Random Student";
            this.btnLoadStudent.UseVisualStyleBackColor = true;
            this.btnLoadStudent.Click += new System.EventHandler(this.btnLoadStudent_Click);
            // 
            // ChooseStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btnLoadStudent);
            this.Controls.Add(this.lblStudentDetails);
            this.Name = "ChooseStudentForm";
            this.Text = "Choose Student";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

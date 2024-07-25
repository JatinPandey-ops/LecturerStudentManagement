using System.Windows.Forms;
namespace LecturerStudentManagement
{
    partial class StudentModuleForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblFullName;

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
            this.lblFullName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(30, 30);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(0, 17);
            this.lblFullName.TabIndex = 0;
            // 
            // StudentModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFullName);
            this.Name = "StudentModuleForm";
            this.Text = "Student Module";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

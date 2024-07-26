using System.Windows.Forms;
namespace LecturerStudentManagement
{
    partial class ChooseStudentForm
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox cmbCourses;
        private Button btnLoadStudent;
        private TextBox txtMatricNumber;
        private TextBox txtFullName;
        private TextBox txtPhoneNumber;
        private TextBox txtProgramCode;
        private Label lblCourses;
        private Label lblMatricNumber;
        private Label lblFullName;
        private Label lblPhoneNumber;
        private Label lblProgramCode;

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
            this.btnLoadStudent = new System.Windows.Forms.Button();
            this.txtMatricNumber = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtProgramCode = new System.Windows.Forms.TextBox();
            this.lblCourses = new System.Windows.Forms.Label();
            this.lblMatricNumber = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblProgramCode = new System.Windows.Forms.Label();
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
            // btnLoadStudent
            // 
            this.btnLoadStudent.Location = new System.Drawing.Point(150, 70);
            this.btnLoadStudent.Name = "btnLoadStudent";
            this.btnLoadStudent.Size = new System.Drawing.Size(100, 30);
            this.btnLoadStudent.TabIndex = 1;
            this.btnLoadStudent.Text = "Load Student";
            this.btnLoadStudent.UseVisualStyleBackColor = true;
            this.btnLoadStudent.Click += new System.EventHandler(this.btnLoadStudent_Click);
            // 
            // txtMatricNumber
            // 
            this.txtMatricNumber.Location = new System.Drawing.Point(150, 110);
            this.txtMatricNumber.Name = "txtMatricNumber";
            this.txtMatricNumber.ReadOnly = true;
            this.txtMatricNumber.Size = new System.Drawing.Size(200, 22);
            this.txtMatricNumber.TabIndex = 2;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(150, 140);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(200, 22);
            this.txtFullName.TabIndex = 3;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(150, 170);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.ReadOnly = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(200, 22);
            this.txtPhoneNumber.TabIndex = 4;
            // 
            // txtProgramCode
            // 
            this.txtProgramCode.Location = new System.Drawing.Point(150, 200);
            this.txtProgramCode.Name = "txtProgramCode";
            this.txtProgramCode.ReadOnly = true;
            this.txtProgramCode.Size = new System.Drawing.Size(200, 22);
            this.txtProgramCode.TabIndex = 5;
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Location = new System.Drawing.Point(50, 30);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(58, 17);
            this.lblCourses.TabIndex = 6;
            this.lblCourses.Text = "Courses";
            // 
            // lblMatricNumber
            // 
            this.lblMatricNumber.AutoSize = true;
            this.lblMatricNumber.Location = new System.Drawing.Point(50, 110);
            this.lblMatricNumber.Name = "lblMatricNumber";
            this.lblMatricNumber.Size = new System.Drawing.Size(96, 17);
            this.lblMatricNumber.TabIndex = 7;
            this.lblMatricNumber.Text = "Matric Number";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(50, 140);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(71, 17);
            this.lblFullName.TabIndex = 8;
            this.lblFullName.Text = "Full Name";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(50, 170);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(103, 17);
            this.lblPhoneNumber.TabIndex = 9;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // lblProgramCode
            // 
            this.lblProgramCode.AutoSize = true;
            this.lblProgramCode.Location = new System.Drawing.Point(50, 200);
            this.lblProgramCode.Name = "lblProgramCode";
            this.lblProgramCode.Size = new System.Drawing.Size(98, 17);
            this.lblProgramCode.TabIndex = 10;
            this.lblProgramCode.Text = "Program Code";
            // 
            // ChooseStudentForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.lblProgramCode);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblMatricNumber);
            this.Controls.Add(this.lblCourses);
            this.Controls.Add(this.txtProgramCode);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtMatricNumber);
            this.Controls.Add(this.btnLoadStudent);
            this.Controls.Add(this.cmbCourses);
            this.Name = "ChooseStudentForm";
            this.Text = "Choose Student";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

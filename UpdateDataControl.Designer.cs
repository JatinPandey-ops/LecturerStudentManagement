using System.Windows.Forms;
namespace LecturerStudentManagement
{
    partial class UpdateDataControl
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox cmbCourses;
        private ComboBox cmbStudents;
        private TextBox txtMatricNumber;
        private TextBox txtFullName;
        private TextBox txtPhoneNumber;
        private TextBox txtProgramCode;
        private Button btnUpdate;
        private Label lblCourses;
        private Label lblStudents;
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
            this.cmbStudents = new System.Windows.Forms.ComboBox();
            this.txtMatricNumber = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtProgramCode = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblCourses = new System.Windows.Forms.Label();
            this.lblStudents = new System.Windows.Forms.Label();
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
            this.cmbCourses.SelectedIndexChanged += new System.EventHandler(this.cmbCourses_SelectedIndexChanged);
            // 
            // cmbStudents
            // 
            this.cmbStudents.FormattingEnabled = true;
            this.cmbStudents.Location = new System.Drawing.Point(150, 70);
            this.cmbStudents.Name = "cmbStudents";
            this.cmbStudents.Size = new System.Drawing.Size(200, 24);
            this.cmbStudents.TabIndex = 1;
            this.cmbStudents.SelectedIndexChanged += new System.EventHandler(this.cmbStudents_SelectedIndexChanged);
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
            this.txtFullName.Size = new System.Drawing.Size(200, 22);
            this.txtFullName.TabIndex = 3;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(150, 170);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(200, 22);
            this.txtPhoneNumber.TabIndex = 4;
            // 
            // txtProgramCode
            // 
            this.txtProgramCode.Location = new System.Drawing.Point(150, 200);
            this.txtProgramCode.Name = "txtProgramCode";
            this.txtProgramCode.Size = new System.Drawing.Size(200, 22);
            this.txtProgramCode.TabIndex = 5;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(150, 240);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 30);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Location = new System.Drawing.Point(50, 30);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(58, 17);
            this.lblCourses.TabIndex = 7;
            this.lblCourses.Text = "Courses";
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Location = new System.Drawing.Point(50, 70);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(64, 17);
            this.lblStudents.TabIndex = 8;
            this.lblStudents.Text = "Students";
            // 
            // lblMatricNumber
            // 
            this.lblMatricNumber.AutoSize = true;
            this.lblMatricNumber.Location = new System.Drawing.Point(50, 110);
            this.lblMatricNumber.Name = "lblMatricNumber";
            this.lblMatricNumber.Size = new System.Drawing.Size(96, 17);
            this.lblMatricNumber.TabIndex = 9;
            this.lblMatricNumber.Text = "Matric Number";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(50, 140);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(71, 17);
            this.lblFullName.TabIndex = 10;
            this.lblFullName.Text = "Full Name";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(50, 170);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(103, 17);
            this.lblPhoneNumber.TabIndex = 11;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // lblProgramCode
            // 
            this.lblProgramCode.AutoSize = true;
            this.lblProgramCode.Location = new System.Drawing.Point(50, 200);
            this.lblProgramCode.Name = "lblProgramCode";
            this.lblProgramCode.Size = new System.Drawing.Size(98, 17);
            this.lblProgramCode.TabIndex = 12;
            this.lblProgramCode.Text = "Program Code";
            // 
            // UpdateDataForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.lblProgramCode);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblMatricNumber);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.lblCourses);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtProgramCode);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtMatricNumber);
            this.Controls.Add(this.cmbStudents);
            this.Controls.Add(this.cmbCourses);
            this.Name = "UpdateDataForm";
            this.Text = "Update Student Data";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

using System;
using System.Windows.Forms;


namespace LecturerStudentManagement
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtFullName;
        private TextBox txtPhoneNumber;
        private Button btnRegister;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblFullName;
        private Label lblPhoneNumber;
        private RadioButton rbtnLecturer;
        private RadioButton rbtnStudent;

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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.rbtnLecturer = new System.Windows.Forms.RadioButton();
            this.rbtnStudent = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(150, 30);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 22);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(150, 70);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(200, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(150, 110);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(200, 22);
            this.txtFullName.TabIndex = 2;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(150, 150);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(200, 22);
            this.txtPhoneNumber.TabIndex = 3;
            this.txtPhoneNumber.Visible = false; // Initially hidden
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(275, 190);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 30);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(30, 33);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(77, 17);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(30, 73);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 17);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(30, 113);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(71, 17);
            this.lblFullName.TabIndex = 7;
            this.lblFullName.Text = "Full Name:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(30, 153);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(109, 17);
            this.lblPhoneNumber.TabIndex = 8;
            this.lblPhoneNumber.Text = "Phone Number:";
            this.lblPhoneNumber.Visible = false; // Initially hidden
            // 
            // rbtnLecturer
            // 
            this.rbtnLecturer.AutoSize = true;
            this.rbtnLecturer.Location = new System.Drawing.Point(150, 190);
            this.rbtnLecturer.Name = "rbtnLecturer";
            this.rbtnLecturer.Size = new System.Drawing.Size(78, 21);
            this.rbtnLecturer.TabIndex = 9;
            this.rbtnLecturer.TabStop = true;
            this.rbtnLecturer.Text = "Lecturer";
            this.rbtnLecturer.UseVisualStyleBackColor = true;
            this.rbtnLecturer.CheckedChanged += new System.EventHandler(this.rbtnLecturer_CheckedChanged);
            // 
            // rbtnStudent
            // 
            this.rbtnStudent.AutoSize = true;
            this.rbtnStudent.Location = new System.Drawing.Point(275, 190);
            this.rbtnStudent.Name = "rbtnStudent";
            this.rbtnStudent.Size = new System.Drawing.Size(76, 21);
            this.rbtnStudent.TabIndex = 10;
            this.rbtnStudent.TabStop = true;
            this.rbtnStudent.Text = "Student";
            this.rbtnStudent.UseVisualStyleBackColor = true;
            this.rbtnStudent.CheckedChanged += new System.EventHandler(this.rbtnStudent_CheckedChanged);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.rbtnStudent);
            this.Controls.Add(this.rbtnLecturer);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "RegisterForm";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void rbtnLecturer_CheckedChanged(object sender, EventArgs e)
        {
            lblPhoneNumber.Visible = false;
            txtPhoneNumber.Visible = false;
        }

        private void rbtnStudent_CheckedChanged(object sender, EventArgs e)
        {
            lblPhoneNumber.Visible = true;
            txtPhoneNumber.Visible = true;
        }
    }
}

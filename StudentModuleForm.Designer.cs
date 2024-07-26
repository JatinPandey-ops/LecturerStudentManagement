using System.Windows.Forms;
namespace LecturerStudentManagement
{
    partial class StudentModuleForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtMatricNumber;
        private TextBox txtFullName;
        private TextBox txtPhoneNumber;
        private ComboBox cmbProgramCode;
        private Button btnSubmit;
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
            this.txtMatricNumber = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.cmbProgramCode = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblMatricNumber = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblProgramCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMatricNumber
            // 
            this.txtMatricNumber.Location = new System.Drawing.Point(150, 30);
            this.txtMatricNumber.Name = "txtMatricNumber";
            this.txtMatricNumber.Size = new System.Drawing.Size(200, 22);
            this.txtMatricNumber.TabIndex = 0;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(150, 70);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(200, 22);
            this.txtFullName.TabIndex = 1;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(150, 110);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(200, 22);
            this.txtPhoneNumber.TabIndex = 2;
            // 
            // cmbProgramCode
            // 
            this.cmbProgramCode.FormattingEnabled = true;
            this.cmbProgramCode.Location = new System.Drawing.Point(150, 150);
            this.cmbProgramCode.Name = "cmbProgramCode";
            this.cmbProgramCode.Size = new System.Drawing.Size(200, 24);
            this.cmbProgramCode.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(150, 190);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 30);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblMatricNumber
            // 
            this.lblMatricNumber.AutoSize = true;
            this.lblMatricNumber.Location = new System.Drawing.Point(50, 30);
            this.lblMatricNumber.Name = "lblMatricNumber";
            this.lblMatricNumber.Size = new System.Drawing.Size(94, 17);
            this.lblMatricNumber.TabIndex = 5;
            this.lblMatricNumber.Text = "Matric Number";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(50, 70);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(71, 17);
            this.lblFullName.TabIndex = 6;
            this.lblFullName.Text = "Full Name";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(50, 110);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(103, 17);
            this.lblPhoneNumber.TabIndex = 7;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // lblProgramCode
            // 
            this.lblProgramCode.AutoSize = true;
            this.lblProgramCode.Location = new System.Drawing.Point(50, 150);
            this.lblProgramCode.Name = "lblProgramCode";
            this.lblProgramCode.Size = new System.Drawing.Size(100, 17);
            this.lblProgramCode.TabIndex = 8;
            this.lblProgramCode.Text = "Program Name";
            // 
            // StudentModuleForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.lblProgramCode);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblMatricNumber);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmbProgramCode);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtMatricNumber);
            this.Name = "StudentModuleForm";
            this.Text = "Student Module";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

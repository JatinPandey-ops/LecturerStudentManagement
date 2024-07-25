using System.Windows.Forms;
namespace LecturerStudentManagement
{
    partial class UpdateDataForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtMatricNo;
        private TextBox txtFullName;
        private TextBox txtPhoneNumber;
        private TextBox txtProgramCode;
        private Button btnUpdate;
        private Label lblMatricNo;
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
            this.txtMatricNo = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtProgramCode = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblMatricNo = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblProgramCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMatricNo
            // 
            this.txtMatricNo.Location = new System.Drawing.Point(150, 30);
            this.txtMatricNo.Name = "txtMatricNo";
            this.txtMatricNo.Size = new System.Drawing.Size(200, 22);
            this.txtMatricNo.TabIndex = 0;
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
            // txtProgramCode
            // 
            this.txtProgramCode.Location = new System.Drawing.Point(150, 150);
            this.txtProgramCode.Name = "txtProgramCode";
            this.txtProgramCode.Size = new System.Drawing.Size(200, 22);
            this.txtProgramCode.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(275, 190);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblMatricNo
            // 
            this.lblMatricNo.AutoSize = true;
            this.lblMatricNo.Location = new System.Drawing.Point(30, 33);
            this.lblMatricNo.Name = "lblMatricNo";
            this.lblMatricNo.Size = new System.Drawing.Size(74, 17);
            this.lblMatricNo.TabIndex = 5;
            this.lblMatricNo.Text = "Matric No:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(30, 73);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(71, 17);
            this.lblFullName.TabIndex = 6;
            this.lblFullName.Text = "Full Name:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(30, 113);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(109, 17);
            this.lblPhoneNumber.TabIndex = 7;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblProgramCode
            // 
            this.lblProgramCode.AutoSize = true;
            this.lblProgramCode.Location = new System.Drawing.Point(30, 153);
            this.lblProgramCode.Name = "lblProgramCode";
            this.lblProgramCode.Size = new System.Drawing.Size(103, 17);
            this.lblProgramCode.TabIndex = 8;
            this.lblProgramCode.Text = "Program Code:";
            // 
            // UpdateDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.lblProgramCode);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblMatricNo);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtProgramCode);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtMatricNo);
            this.Name = "UpdateDataForm";
            this.Text = "Update Data";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

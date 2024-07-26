using System.Windows.Forms;

namespace LecturerStudentManagement
{
    partial class ViewDataForm
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox cmbCourses;
        private Button btnViewData;
        private DataGridView dataGridView1;
        private Label lblCourses;

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
            this.btnViewData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCourses = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // btnViewData
            // 
            this.btnViewData.Location = new System.Drawing.Point(150, 70);
            this.btnViewData.Name = "btnViewData";
            this.btnViewData.Size = new System.Drawing.Size(100, 30);
            this.btnViewData.TabIndex = 1;
            this.btnViewData.Text = "View Data";
            this.btnViewData.UseVisualStyleBackColor = true;
            this.btnViewData.Click += new System.EventHandler(this.btnViewData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(500, 200);
            this.dataGridView1.TabIndex = 2;
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Location = new System.Drawing.Point(50, 30);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(58, 17);
            this.lblCourses.TabIndex = 3;
            this.lblCourses.Text = "Courses";
            // 
            // ViewDataForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.lblCourses);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnViewData);
            this.Controls.Add(this.cmbCourses);
            this.Name = "ViewDataForm";
            this.Text = "View Student Data";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

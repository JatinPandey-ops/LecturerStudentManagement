using System.Windows.Forms;

namespace LecturerStudentManagement
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem viewDataToolStripMenuItem;
        private ToolStripMenuItem updateDataToolStripMenuItem;
        private ToolStripMenuItem chooseStudentToolStripMenuItem;
        private ToolStripMenuItem searchByPhoneNumberToolStripMenuItem;
        private ToolStripMenuItem createCoursesToolStripMenuItem;
        private ToolStripMenuItem dropCoursesToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private Label lblFullName;
        private Button btnLogout;  // Add logout button

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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByPhoneNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCoursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropCoursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFullName = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();  // Add logout button
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.viewDataToolStripMenuItem,
            this.updateDataToolStripMenuItem,
            this.chooseStudentToolStripMenuItem,
            this.searchByPhoneNumberToolStripMenuItem,
            this.createCoursesToolStripMenuItem,
            this.dropCoursesToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // viewDataToolStripMenuItem
            // 
            this.viewDataToolStripMenuItem.Name = "viewDataToolStripMenuItem";
            this.viewDataToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.viewDataToolStripMenuItem.Text = "View Data";
            this.viewDataToolStripMenuItem.Click += new System.EventHandler(this.viewDataToolStripMenuItem_Click);
            // 
            // updateDataToolStripMenuItem
            // 
            this.updateDataToolStripMenuItem.Name = "updateDataToolStripMenuItem";
            this.updateDataToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.updateDataToolStripMenuItem.Text = "Update Data";
            this.updateDataToolStripMenuItem.Click += new System.EventHandler(this.updateDataToolStripMenuItem_Click);
            // 
            // chooseStudentToolStripMenuItem
            // 
            this.chooseStudentToolStripMenuItem.Name = "chooseStudentToolStripMenuItem";
            this.chooseStudentToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.chooseStudentToolStripMenuItem.Text = "Choose Student";
            this.chooseStudentToolStripMenuItem.Click += new System.EventHandler(this.chooseStudentToolStripMenuItem_Click);
            // 
            // searchByPhoneNumberToolStripMenuItem
            // 
            this.searchByPhoneNumberToolStripMenuItem.Name = "searchByPhoneNumberToolStripMenuItem";
            this.searchByPhoneNumberToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.searchByPhoneNumberToolStripMenuItem.Text = "Search by Phone Number";
            this.searchByPhoneNumberToolStripMenuItem.Click += new System.EventHandler(this.searchByPhoneNumberToolStripMenuItem_Click);
            // 
            // createCoursesToolStripMenuItem
            // 
            this.createCoursesToolStripMenuItem.Name = "createCoursesToolStripMenuItem";
            this.createCoursesToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.createCoursesToolStripMenuItem.Text = "Create Courses";
            this.createCoursesToolStripMenuItem.Click += new System.EventHandler(this.createCoursesToolStripMenuItem_Click);
            // 
            // dropCoursesToolStripMenuItem
            // 
            this.dropCoursesToolStripMenuItem.Name = "dropCoursesToolStripMenuItem";
            this.dropCoursesToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.dropCoursesToolStripMenuItem.Text = "Drop Courses";
            this.dropCoursesToolStripMenuItem.Click += new System.EventHandler(this.dropCoursesToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(13, 36);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(0, 17);
            this.lblFullName.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(700, 36);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 30);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

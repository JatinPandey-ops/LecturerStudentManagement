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
        private ToolStripMenuItem assignStudentToCourseToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByPhoneNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCoursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropCoursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignStudentToCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFullName = new System.Windows.Forms.Label();
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
            this.assignStudentToCourseToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1126, 28);
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
            this.viewDataToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.viewDataToolStripMenuItem.Text = "View Data";
            this.viewDataToolStripMenuItem.Click += new System.EventHandler(this.viewDataToolStripMenuItem_Click);
            // 
            // updateDataToolStripMenuItem
            // 
            this.updateDataToolStripMenuItem.Name = "updateDataToolStripMenuItem";
            this.updateDataToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.updateDataToolStripMenuItem.Text = "Update Data";
            this.updateDataToolStripMenuItem.Click += new System.EventHandler(this.updateDataToolStripMenuItem_Click);
            // 
            // chooseStudentToolStripMenuItem
            // 
            this.chooseStudentToolStripMenuItem.Name = "chooseStudentToolStripMenuItem";
            this.chooseStudentToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.chooseStudentToolStripMenuItem.Text = "Choose Student";
            this.chooseStudentToolStripMenuItem.Click += new System.EventHandler(this.chooseStudentToolStripMenuItem_Click);
            // 
            // searchByPhoneNumberToolStripMenuItem
            // 
            this.searchByPhoneNumberToolStripMenuItem.Name = "searchByPhoneNumberToolStripMenuItem";
            this.searchByPhoneNumberToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.searchByPhoneNumberToolStripMenuItem.Text = "Search By Phone Number";
            this.searchByPhoneNumberToolStripMenuItem.Click += new System.EventHandler(this.searchByPhoneNumberToolStripMenuItem_Click);
            // 
            // createCoursesToolStripMenuItem
            // 
            this.createCoursesToolStripMenuItem.Name = "createCoursesToolStripMenuItem";
            this.createCoursesToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
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
            // assignStudentToCourseToolStripMenuItem
            // 
            this.assignStudentToCourseToolStripMenuItem.Name = "assignStudentToCourseToolStripMenuItem";
            this.assignStudentToCourseToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.assignStudentToCourseToolStripMenuItem.Text = "Assign Student To Course";
            this.assignStudentToCourseToolStripMenuItem.Click += new System.EventHandler(this.assignStudentToCourseToolStripMenuItem_Click);
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
            this.lblFullName.Location = new System.Drawing.Point(12, 40);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(68, 16);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "Full Name";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1126, 450);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

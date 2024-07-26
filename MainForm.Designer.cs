namespace LecturerStudentManagement
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

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
            this.panelMain = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // viewDataToolStripMenuItem
            // 
            this.viewDataToolStripMenuItem.Name = "viewDataToolStripMenuItem";
            this.viewDataToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.viewDataToolStripMenuItem.Text = "View Data";
            this.viewDataToolStripMenuItem.Click += new System.EventHandler(this.viewDataToolStripMenuItem_Click);
            // 
            // updateDataToolStripMenuItem
            // 
            this.updateDataToolStripMenuItem.Name = "updateDataToolStripMenuItem";
            this.updateDataToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.updateDataToolStripMenuItem.Text = "Update Data";
            this.updateDataToolStripMenuItem.Click += new System.EventHandler(this.updateDataToolStripMenuItem_Click);
            // 
            // chooseStudentToolStripMenuItem
            // 
            this.chooseStudentToolStripMenuItem.Name = "chooseStudentToolStripMenuItem";
            this.chooseStudentToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.chooseStudentToolStripMenuItem.Text = "Choose Student";
            this.chooseStudentToolStripMenuItem.Click += new System.EventHandler(this.chooseStudentToolStripMenuItem_Click);
            // 
            // searchByPhoneNumberToolStripMenuItem
            // 
            this.searchByPhoneNumberToolStripMenuItem.Name = "searchByPhoneNumberToolStripMenuItem";
            this.searchByPhoneNumberToolStripMenuItem.Size = new System.Drawing.Size(156, 20);
            this.searchByPhoneNumberToolStripMenuItem.Text = "Search by Phone Number";
            this.searchByPhoneNumberToolStripMenuItem.Click += new System.EventHandler(this.searchByPhoneNumberToolStripMenuItem_Click);
            // 
            // createCoursesToolStripMenuItem
            // 
            this.createCoursesToolStripMenuItem.Name = "createCoursesToolStripMenuItem";
            this.createCoursesToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.createCoursesToolStripMenuItem.Text = "Create Courses";
            this.createCoursesToolStripMenuItem.Click += new System.EventHandler(this.createCoursesToolStripMenuItem_Click);
            // 
            // dropCoursesToolStripMenuItem
            // 
            this.dropCoursesToolStripMenuItem.Name = "dropCoursesToolStripMenuItem";
            this.dropCoursesToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.dropCoursesToolStripMenuItem.Text = "Drop Courses";
            this.dropCoursesToolStripMenuItem.Click += new System.EventHandler(this.dropCoursesToolStripMenuItem_Click);
            // 
            // assignStudentToCourseToolStripMenuItem
            // 
            this.assignStudentToCourseToolStripMenuItem.Name = "assignStudentToCourseToolStripMenuItem";
            this.assignStudentToCourseToolStripMenuItem.Size = new System.Drawing.Size(151, 20);
            this.assignStudentToCourseToolStripMenuItem.Text = "Assign Student to Course";
            this.assignStudentToCourseToolStripMenuItem.Click += new System.EventHandler(this.assignStudentToCourseToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(12, 40);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(35, 13);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "Name";
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(15, 60);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(770, 380);
            this.panelMain.TabIndex = 2;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchByPhoneNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createCoursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dropCoursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignStudentToCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Panel panelMain;
    }
}


namespace DITECH_FINAL_PROJECT
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ManageStudents = new System.Windows.Forms.Button();
            this.ManageCourses = new System.Windows.Forms.Button();
            this.ManageUsers = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ExitBTN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 35);
            this.panel1.TabIndex = 0;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Tomato;
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Location = new System.Drawing.Point(542, 5);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(60, 24);
            this.logoutBtn.TabIndex = 24;
            this.logoutBtn.Text = "Log out";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Main Menu";
            // 
            // ExitBTN
            // 
            this.ExitBTN.BackColor = System.Drawing.Color.Red;
            this.ExitBTN.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.ExitBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitBTN.Location = new System.Drawing.Point(608, 6);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(25, 23);
            this.ExitBTN.TabIndex = 2;
            this.ExitBTN.Text = "X";
            this.ExitBTN.UseVisualStyleBackColor = false;
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(635, 57);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "User";
            // 
            // ManageStudents
            // 
            this.ManageStudents.BackColor = System.Drawing.Color.Aqua;
            this.ManageStudents.FlatAppearance.BorderSize = 0;
            this.ManageStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ManageStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageStudents.Location = new System.Drawing.Point(72, 189);
            this.ManageStudents.Name = "ManageStudents";
            this.ManageStudents.Size = new System.Drawing.Size(125, 50);
            this.ManageStudents.TabIndex = 3;
            this.ManageStudents.Text = "Manage Students\r\n";
            this.ManageStudents.UseVisualStyleBackColor = false;
            this.ManageStudents.Click += new System.EventHandler(this.ManageStudents_Click);
            // 
            // ManageCourses
            // 
            this.ManageCourses.BackColor = System.Drawing.Color.Aqua;
            this.ManageCourses.FlatAppearance.BorderSize = 0;
            this.ManageCourses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ManageCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageCourses.Location = new System.Drawing.Point(241, 189);
            this.ManageCourses.Name = "ManageCourses";
            this.ManageCourses.Size = new System.Drawing.Size(125, 50);
            this.ManageCourses.TabIndex = 4;
            this.ManageCourses.Text = "Manage Courses";
            this.ManageCourses.UseVisualStyleBackColor = false;
            this.ManageCourses.Click += new System.EventHandler(this.ManageCourses_Click);
            // 
            // ManageUsers
            // 
            this.ManageUsers.BackColor = System.Drawing.Color.Aqua;
            this.ManageUsers.FlatAppearance.BorderSize = 0;
            this.ManageUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageUsers.Location = new System.Drawing.Point(411, 189);
            this.ManageUsers.Name = "ManageUsers";
            this.ManageUsers.Size = new System.Drawing.Size(125, 50);
            this.ManageUsers.TabIndex = 5;
            this.ManageUsers.Text = "Manage Users";
            this.ManageUsers.UseVisualStyleBackColor = false;
            this.ManageUsers.Click += new System.EventHandler(this.ManageUsers_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(635, 380);
            this.ControlBox = false;
            this.Controls.Add(this.ManageUsers);
            this.Controls.Add(this.ManageCourses);
            this.Controls.Add(this.ManageStudents);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitBTN;
        private System.Windows.Forms.Button ManageStudents;
        private System.Windows.Forms.Button ManageCourses;
        private System.Windows.Forms.Button ManageUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button logoutBtn;
    }
}
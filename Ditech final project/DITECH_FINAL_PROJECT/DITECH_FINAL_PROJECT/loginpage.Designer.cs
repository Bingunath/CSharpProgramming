
namespace DITECH_FINAL_PROJECT
{
    partial class loginpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginpage));
            this.extbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usrnameTB = new System.Windows.Forms.TextBox();
            this.passwdTB = new System.Windows.Forms.TextBox();
            this.usrname = new System.Windows.Forms.Label();
            this.passwd = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserListBox = new System.Windows.Forms.ComboBox();
            this.UserIdTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // extbtn
            // 
            this.extbtn.BackColor = System.Drawing.Color.OrangeRed;
            this.extbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.extbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extbtn.Location = new System.Drawing.Point(1004, 12);
            this.extbtn.Name = "extbtn";
            this.extbtn.Size = new System.Drawing.Size(34, 35);
            this.extbtn.TabIndex = 7;
            this.extbtn.Text = "X";
            this.extbtn.UseVisualStyleBackColor = false;
            this.extbtn.Click += new System.EventHandler(this.extbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(276, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // usrnameTB
            // 
            this.usrnameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrnameTB.Location = new System.Drawing.Point(196, 230);
            this.usrnameTB.Name = "usrnameTB";
            this.usrnameTB.Size = new System.Drawing.Size(308, 26);
            this.usrnameTB.TabIndex = 1;
            // 
            // passwdTB
            // 
            this.passwdTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwdTB.Location = new System.Drawing.Point(196, 283);
            this.passwdTB.Name = "passwdTB";
            this.passwdTB.PasswordChar = '*';
            this.passwdTB.Size = new System.Drawing.Size(308, 26);
            this.passwdTB.TabIndex = 2;
            // 
            // usrname
            // 
            this.usrname.AutoSize = true;
            this.usrname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrname.Location = new System.Drawing.Point(72, 232);
            this.usrname.Name = "usrname";
            this.usrname.Size = new System.Drawing.Size(117, 24);
            this.usrname.TabIndex = 3;
            this.usrname.Text = "USERNAME";
            // 
            // passwd
            // 
            this.passwd.AutoSize = true;
            this.passwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwd.Location = new System.Drawing.Point(72, 285);
            this.passwd.Name = "passwd";
            this.passwd.Size = new System.Drawing.Size(118, 24);
            this.passwd.TabIndex = 4;
            this.passwd.Text = "PASSWORD";
            // 
            // loginbtn
            // 
            this.loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.Location = new System.Drawing.Point(290, 327);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(115, 46);
            this.loginbtn.TabIndex = 5;
            this.loginbtn.Text = "LOG-IN";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.UserListBox);
            this.panel1.Controls.Add(this.UserIdTB);
            this.panel1.Controls.Add(this.loginbtn);
            this.panel1.Controls.Add(this.passwd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.usrname);
            this.panel1.Controls.Add(this.passwdTB);
            this.panel1.Controls.Add(this.usrnameTB);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(215, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 390);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // UserListBox
            // 
            this.UserListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UserListBox.FormattingEnabled = true;
            this.UserListBox.Location = new System.Drawing.Point(336, 190);
            this.UserListBox.Name = "UserListBox";
            this.UserListBox.Size = new System.Drawing.Size(80, 28);
            this.UserListBox.TabIndex = 7;
            this.UserListBox.SelectedIndexChanged += new System.EventHandler(this.UserListBox_SelectedIndexChanged);
            // 
            // UserIdTB
            // 
            this.UserIdTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UserIdTB.Location = new System.Drawing.Point(241, 192);
            this.UserIdTB.Name = "UserIdTB";
            this.UserIdTB.Size = new System.Drawing.Size(89, 26);
            this.UserIdTB.TabIndex = 6;
            this.UserIdTB.TextChanged += new System.EventHandler(this.UserIdTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "ENTER USER\'s ID";
            // 
            // loginpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1050, 530);
            this.Controls.Add(this.extbtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loginpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN-STUDENT REGISTRATION";
            this.Load += new System.EventHandler(this.loginpage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button extbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox usrnameTB;
        private System.Windows.Forms.TextBox passwdTB;
        private System.Windows.Forms.Label usrname;
        private System.Windows.Forms.Label passwd;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox UserListBox;
        private System.Windows.Forms.TextBox UserIdTB;
        private System.Windows.Forms.Label label1;
    }
}
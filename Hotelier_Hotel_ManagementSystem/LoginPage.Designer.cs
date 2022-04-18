
namespace Hotelier_Hotel_ManagementSystem
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SignUpBTN = new System.Windows.Forms.Button();
            this.ClearBTN = new System.Windows.Forms.Button();
            this.LoginBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PassWordTB = new System.Windows.Forms.TextBox();
            this.UserNameTB = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = global::Hotelier_Hotel_ManagementSystem.Properties.Resources.Hotelier2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.SignUpBTN);
            this.panel1.Controls.Add(this.ClearBTN);
            this.panel1.Controls.Add(this.LoginBTN);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PassWordTB);
            this.panel1.Controls.Add(this.UserNameTB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 371);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Hotelier_Hotel_ManagementSystem.Properties.Resources.Login_Manager1;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(103, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // SignUpBTN
            // 
            this.SignUpBTN.Location = new System.Drawing.Point(291, 314);
            this.SignUpBTN.Name = "SignUpBTN";
            this.SignUpBTN.Size = new System.Drawing.Size(97, 23);
            this.SignUpBTN.TabIndex = 5;
            this.SignUpBTN.Text = "SIGN UP";
            this.SignUpBTN.UseVisualStyleBackColor = true;
            this.SignUpBTN.Click += new System.EventHandler(this.SignUpBTN_Click);
            // 
            // ClearBTN
            // 
            this.ClearBTN.Location = new System.Drawing.Point(210, 314);
            this.ClearBTN.Name = "ClearBTN";
            this.ClearBTN.Size = new System.Drawing.Size(75, 23);
            this.ClearBTN.TabIndex = 4;
            this.ClearBTN.Text = "CLEAR";
            this.ClearBTN.UseVisualStyleBackColor = true;
            this.ClearBTN.Click += new System.EventHandler(this.ClearBTN_Click);
            // 
            // LoginBTN
            // 
            this.LoginBTN.Location = new System.Drawing.Point(129, 314);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(75, 23);
            this.LoginBTN.TabIndex = 3;
            this.LoginBTN.Text = "LOGIN";
            this.LoginBTN.UseVisualStyleBackColor = true;
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 278);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "PASSWORD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 226);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "USERNAME";
            // 
            // PassWordTB
            // 
            this.PassWordTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.PassWordTB.Location = new System.Drawing.Point(129, 273);
            this.PassWordTB.Margin = new System.Windows.Forms.Padding(4);
            this.PassWordTB.Name = "PassWordTB";
            this.PassWordTB.Size = new System.Drawing.Size(282, 22);
            this.PassWordTB.TabIndex = 1;
            this.PassWordTB.UseSystemPasswordChar = true;
            // 
            // UserNameTB
            // 
            this.UserNameTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.UserNameTB.Location = new System.Drawing.Point(129, 220);
            this.UserNameTB.Margin = new System.Windows.Forms.Padding(4);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(282, 22);
            this.UserNameTB.TabIndex = 0;
            // 
            // LoginPage
            // 
            this.AcceptButton = this.LoginBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 371);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginPage_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginPage_FormClosed);
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PassWordTB;
        private System.Windows.Forms.TextBox UserNameTB;
        private System.Windows.Forms.Button SignUpBTN;
        private System.Windows.Forms.Button ClearBTN;
        private System.Windows.Forms.Button LoginBTN;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
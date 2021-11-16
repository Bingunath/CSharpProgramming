
namespace Library_Managment_System
{
    partial class NewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUser));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.UserIdTB = new System.Windows.Forms.TextBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.ConfirmPassWordTB = new System.Windows.Forms.TextBox();
            this.NewPassWordTB = new System.Windows.Forms.TextBox();
            this.NewUserNameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SeeUsersBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(245, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "RESGISTER NEW USER";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.UserIdTB);
            this.panel1.Controls.Add(this.ErrorLabel);
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Controls.Add(this.RegisterBtn);
            this.panel1.Controls.Add(this.ConfirmPassWordTB);
            this.panel1.Controls.Add(this.NewPassWordTB);
            this.panel1.Controls.Add(this.NewUserNameTB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(251, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 364);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "USER ID";
            // 
            // UserIdTB
            // 
            this.UserIdTB.Location = new System.Drawing.Point(173, 41);
            this.UserIdTB.Name = "UserIdTB";
            this.UserIdTB.Size = new System.Drawing.Size(161, 20);
            this.UserIdTB.TabIndex = 9;
            this.UserIdTB.TextChanged += new System.EventHandler(this.UserIdTB_TextChanged);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(112, 218);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 8;
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Location = new System.Drawing.Point(259, 256);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "EXIT";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterBtn.Location = new System.Drawing.Point(178, 256);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(75, 23);
            this.RegisterBtn.TabIndex = 6;
            this.RegisterBtn.Text = "REGISTER";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // ConfirmPassWordTB
            // 
            this.ConfirmPassWordTB.Location = new System.Drawing.Point(173, 181);
            this.ConfirmPassWordTB.Name = "ConfirmPassWordTB";
            this.ConfirmPassWordTB.PasswordChar = '*';
            this.ConfirmPassWordTB.Size = new System.Drawing.Size(161, 20);
            this.ConfirmPassWordTB.TabIndex = 5;
            this.ConfirmPassWordTB.TextChanged += new System.EventHandler(this.ConfirmPassWordTB_TextChanged);
            // 
            // NewPassWordTB
            // 
            this.NewPassWordTB.Location = new System.Drawing.Point(173, 131);
            this.NewPassWordTB.Name = "NewPassWordTB";
            this.NewPassWordTB.Size = new System.Drawing.Size(161, 20);
            this.NewPassWordTB.TabIndex = 4;
            // 
            // NewUserNameTB
            // 
            this.NewUserNameTB.Location = new System.Drawing.Point(173, 84);
            this.NewUserNameTB.Name = "NewUserNameTB";
            this.NewUserNameTB.Size = new System.Drawing.Size(161, 20);
            this.NewUserNameTB.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "CONFIRM PASSWORD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "ENTER PASSWORD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "ENTER USERNAME";
            // 
            // SeeUsersBtn
            // 
            this.SeeUsersBtn.Location = new System.Drawing.Point(667, 45);
            this.SeeUsersBtn.Name = "SeeUsersBtn";
            this.SeeUsersBtn.Size = new System.Drawing.Size(96, 23);
            this.SeeUsersBtn.TabIndex = 2;
            this.SeeUsersBtn.Text = "SEE USERS";
            this.SeeUsersBtn.UseVisualStyleBackColor = true;
            this.SeeUsersBtn.Click += new System.EventHandler(this.SeeUsersBtn_Click);
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::Library_Managment_System.Properties.Resources._253332;
            this.ClientSize = new System.Drawing.Size(822, 501);
            this.Controls.Add(this.SeeUsersBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New User";
            this.Load += new System.EventHandler(this.NewUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.TextBox ConfirmPassWordTB;
        private System.Windows.Forms.TextBox NewPassWordTB;
        private System.Windows.Forms.TextBox NewUserNameTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SeeUsersBtn;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UserIdTB;
    }
}

namespace DITECH_FINAL_PROJECT
{
    partial class newuser
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
            this.canclebtn = new System.Windows.Forms.Button();
            this.registerbtn = new System.Windows.Forms.Button();
            this.connewpass = new System.Windows.Forms.TextBox();
            this.newpass = new System.Windows.Forms.TextBox();
            this.newusr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.canclebtn);
            this.panel1.Controls.Add(this.registerbtn);
            this.panel1.Controls.Add(this.connewpass);
            this.panel1.Controls.Add(this.newpass);
            this.panel1.Controls.Add(this.newusr);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(250, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 376);
            this.panel1.TabIndex = 0;
            // 
            // canclebtn
            // 
            this.canclebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canclebtn.Location = new System.Drawing.Point(336, 202);
            this.canclebtn.Name = "canclebtn";
            this.canclebtn.Size = new System.Drawing.Size(102, 43);
            this.canclebtn.TabIndex = 8;
            this.canclebtn.Text = "CANCLE";
            this.canclebtn.UseVisualStyleBackColor = true;
            this.canclebtn.Click += new System.EventHandler(this.canclebtn_Click);
            // 
            // registerbtn
            // 
            this.registerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerbtn.Location = new System.Drawing.Point(225, 203);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(104, 43);
            this.registerbtn.TabIndex = 7;
            this.registerbtn.Text = "CREATE";
            this.registerbtn.UseVisualStyleBackColor = true;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // connewpass
            // 
            this.connewpass.Location = new System.Drawing.Point(225, 159);
            this.connewpass.Name = "connewpass";
            this.connewpass.PasswordChar = '*';
            this.connewpass.Size = new System.Drawing.Size(213, 20);
            this.connewpass.TabIndex = 6;
            this.connewpass.TextChanged += new System.EventHandler(this.connewpass_TextChanged);
            // 
            // newpass
            // 
            this.newpass.Location = new System.Drawing.Point(225, 124);
            this.newpass.Name = "newpass";
            this.newpass.PasswordChar = '*';
            this.newpass.Size = new System.Drawing.Size(213, 20);
            this.newpass.TabIndex = 5;
            // 
            // newusr
            // 
            this.newusr.Location = new System.Drawing.Point(225, 84);
            this.newusr.Name = "newusr";
            this.newusr.Size = new System.Drawing.Size(213, 20);
            this.newusr.TabIndex = 4;
            this.newusr.TextChanged += new System.EventHandler(this.newusr_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CONFIRM PASSWORD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PASSWORD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NEW USERNAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTER NEW USER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // newuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1050, 530);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "newuser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New user";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button canclebtn;
        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.TextBox connewpass;
        private System.Windows.Forms.TextBox newpass;
        private System.Windows.Forms.TextBox newusr;
    }
}
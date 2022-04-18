
namespace Hotelier_Hotel_ManagementSystem
{
    partial class OtpSms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtpSms));
            this.NameTB = new System.Windows.Forms.TextBox();
            this.NumberTB = new System.Windows.Forms.TextBox();
            this.OtpTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SendOtpBTN = new System.Windows.Forms.Button();
            this.VerifyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameTB
            // 
            this.NameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTB.Location = new System.Drawing.Point(128, 32);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(222, 22);
            this.NameTB.TabIndex = 0;
            // 
            // NumberTB
            // 
            this.NumberTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberTB.Location = new System.Drawing.Point(128, 81);
            this.NumberTB.Name = "NumberTB";
            this.NumberTB.Size = new System.Drawing.Size(222, 22);
            this.NumberTB.TabIndex = 1;
            // 
            // OtpTB
            // 
            this.OtpTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtpTB.Location = new System.Drawing.Point(128, 163);
            this.OtpTB.Name = "OtpTB";
            this.OtpTB.Size = new System.Drawing.Size(222, 22);
            this.OtpTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(82, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "OTP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(76, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // SendOtpBTN
            // 
            this.SendOtpBTN.Location = new System.Drawing.Point(365, 81);
            this.SendOtpBTN.Name = "SendOtpBTN";
            this.SendOtpBTN.Size = new System.Drawing.Size(75, 23);
            this.SendOtpBTN.TabIndex = 6;
            this.SendOtpBTN.Text = "Send OTP";
            this.SendOtpBTN.UseVisualStyleBackColor = true;
            this.SendOtpBTN.Click += new System.EventHandler(this.SendOtpBTN_Click);
            // 
            // VerifyBtn
            // 
            this.VerifyBtn.Location = new System.Drawing.Point(118, 208);
            this.VerifyBtn.Name = "VerifyBtn";
            this.VerifyBtn.Size = new System.Drawing.Size(75, 23);
            this.VerifyBtn.TabIndex = 7;
            this.VerifyBtn.Text = "Verify";
            this.VerifyBtn.UseVisualStyleBackColor = true;
            this.VerifyBtn.Click += new System.EventHandler(this.VerifyBtn_Click);
            // 
            // OtpSms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Hotelier_Hotel_ManagementSystem.Properties.Resources.Hotelier2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(478, 269);
            this.Controls.Add(this.VerifyBtn);
            this.Controls.Add(this.SendOtpBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OtpTB);
            this.Controls.Add(this.NumberTB);
            this.Controls.Add(this.NameTB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OtpSms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OtpSms";
            this.Load += new System.EventHandler(this.OtpSms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox NumberTB;
        private System.Windows.Forms.TextBox OtpTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SendOtpBTN;
        private System.Windows.Forms.Button VerifyBtn;
    }
}
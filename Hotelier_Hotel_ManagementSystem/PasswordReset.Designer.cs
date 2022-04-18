
namespace Hotelier_Hotel_ManagementSystem
{
    partial class PasswordReset
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
            this.NewPass1 = new System.Windows.Forms.TextBox();
            this.NewPass2 = new System.Windows.Forms.TextBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.membershipplans1 = new Hotelier_Hotel_ManagementSystem.membershipplans();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameLB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.membershipplans1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewPass1
            // 
            this.NewPass1.Location = new System.Drawing.Point(150, 137);
            this.NewPass1.Name = "NewPass1";
            this.NewPass1.Size = new System.Drawing.Size(234, 20);
            this.NewPass1.TabIndex = 1;
            this.NewPass1.UseSystemPasswordChar = true;
            // 
            // NewPass2
            // 
            this.NewPass2.Location = new System.Drawing.Point(150, 179);
            this.NewPass2.Name = "NewPass2";
            this.NewPass2.Size = new System.Drawing.Size(234, 20);
            this.NewPass2.TabIndex = 2;
            this.NewPass2.UseSystemPasswordChar = true;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(150, 218);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(121, 23);
            this.UpdateBtn.TabIndex = 3;
            this.UpdateBtn.Text = "Change Password";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(309, 218);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // membershipplans1
            // 
            this.membershipplans1.DataSetName = "membershipplans";
            this.membershipplans1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "New Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Confirm Pasword";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username";
            // 
            // UsernameLB
            // 
            this.UsernameLB.AutoSize = true;
            this.UsernameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLB.ForeColor = System.Drawing.Color.White;
            this.UsernameLB.Location = new System.Drawing.Point(151, 94);
            this.UsernameLB.Name = "UsernameLB";
            this.UsernameLB.Size = new System.Drawing.Size(41, 13);
            this.UsernameLB.TabIndex = 9;
            this.UsernameLB.Text = "label4";
            // 
            // PasswordReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = global::Hotelier_Hotel_ManagementSystem.Properties.Resources.Hotelier2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(494, 315);
            this.Controls.Add(this.UsernameLB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.NewPass2);
            this.Controls.Add(this.NewPass1);
            this.Name = "PasswordReset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordReset";
            this.Load += new System.EventHandler(this.PasswordReset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.membershipplans1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NewPass1;
        private System.Windows.Forms.TextBox NewPass2;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button CancelBtn;
        private membershipplans membershipplans1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UsernameLB;
    }
}
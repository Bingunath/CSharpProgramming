
namespace Library_Managment_System
{
    partial class LibraryHomeMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryHomeMenu));
            this.LBMS = new System.Windows.Forms.Button();
            this.LBRS = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.MinimizedBtn = new System.Windows.Forms.Button();
            this.RegisterNewMember = new System.Windows.Forms.Button();
            this.membersTableAdapter = new Library_Managment_System.LibraryBooksDatabaseDataSet3TableAdapters.membersTableAdapter();
            this.NewUserBtn = new System.Windows.Forms.Button();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.SuspendLayout();
            // 
            // LBMS
            // 
            this.LBMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LBMS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBMS.FlatAppearance.BorderSize = 0;
            this.LBMS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.LBMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBMS.Font = new System.Drawing.Font("Adobe Fangsong Std R", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBMS.Location = new System.Drawing.Point(168, 198);
            this.LBMS.Name = "LBMS";
            this.LBMS.Size = new System.Drawing.Size(186, 78);
            this.LBMS.TabIndex = 0;
            this.LBMS.Text = "Library Book Managment System";
            this.LBMS.UseVisualStyleBackColor = false;
            this.LBMS.Click += new System.EventHandler(this.LBMS_Click);
            // 
            // LBRS
            // 
            this.LBRS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LBRS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LBRS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBRS.FlatAppearance.BorderSize = 0;
            this.LBRS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.LBRS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBRS.Font = new System.Drawing.Font("Adobe Fangsong Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBRS.Location = new System.Drawing.Point(361, 198);
            this.LBRS.Name = "LBRS";
            this.LBRS.Size = new System.Drawing.Size(186, 78);
            this.LBRS.TabIndex = 1;
            this.LBRS.Text = "Library Book Registration System";
            this.LBRS.UseVisualStyleBackColor = false;
            this.LBRS.Click += new System.EventHandler(this.LBRS_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Red;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(819, 12);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(29, 32);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // MinimizedBtn
            // 
            this.MinimizedBtn.BackColor = System.Drawing.Color.Transparent;
            this.MinimizedBtn.FlatAppearance.BorderSize = 0;
            this.MinimizedBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.MinimizedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizedBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.MinimizedBtn.Location = new System.Drawing.Point(784, 12);
            this.MinimizedBtn.Name = "MinimizedBtn";
            this.MinimizedBtn.Size = new System.Drawing.Size(29, 32);
            this.MinimizedBtn.TabIndex = 3;
            this.MinimizedBtn.Text = "_";
            this.MinimizedBtn.UseVisualStyleBackColor = false;
            this.MinimizedBtn.Click += new System.EventHandler(this.MinimizedBtn_Click);
            // 
            // RegisterNewMember
            // 
            this.RegisterNewMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RegisterNewMember.FlatAppearance.BorderSize = 0;
            this.RegisterNewMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.RegisterNewMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterNewMember.Font = new System.Drawing.Font("Adobe Fangsong Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterNewMember.Location = new System.Drawing.Point(554, 198);
            this.RegisterNewMember.Name = "RegisterNewMember";
            this.RegisterNewMember.Size = new System.Drawing.Size(186, 78);
            this.RegisterNewMember.TabIndex = 5;
            this.RegisterNewMember.Text = "Register New Member";
            this.RegisterNewMember.UseVisualStyleBackColor = false;
            this.RegisterNewMember.Click += new System.EventHandler(this.RegisterNewMember_Click);
            // 
            // membersTableAdapter
            // 
            this.membersTableAdapter.ClearBeforeFill = true;
            // 
            // NewUserBtn
            // 
            this.NewUserBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.NewUserBtn.FlatAppearance.BorderSize = 0;
            this.NewUserBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.NewUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewUserBtn.Location = new System.Drawing.Point(690, 21);
            this.NewUserBtn.Name = "NewUserBtn";
            this.NewUserBtn.Size = new System.Drawing.Size(75, 23);
            this.NewUserBtn.TabIndex = 6;
            this.NewUserBtn.Text = "New User";
            this.NewUserBtn.UseVisualStyleBackColor = false;
            this.NewUserBtn.Click += new System.EventHandler(this.NewUserBtn_Click);
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.ExponentialEaseInOut;
            this.circularProgressBar1.AnimationSpeed = 300;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.White;
            this.circularProgressBar1.InnerColor = System.Drawing.Color.RoyalBlue;
            this.circularProgressBar1.InnerMargin = 5;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(362, 297);
            this.circularProgressBar1.MarqueeAnimationSpeed = 1000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.circularProgressBar1.OuterMargin = -27;
            this.circularProgressBar1.OuterWidth = 25;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.circularProgressBar1.ProgressWidth = 10;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(158, 158);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 8;
            this.circularProgressBar1.Text = "PLEASE WAIT.!";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.circularProgressBar1.Value = 68;
            // 
            // LibraryHomeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Library_Managment_System.Properties.Resources._253332;
            this.ClientSize = new System.Drawing.Size(860, 543);
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.NewUserBtn);
            this.Controls.Add(this.RegisterNewMember);
            this.Controls.Add(this.MinimizedBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.LBRS);
            this.Controls.Add(this.LBMS);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LibraryHomeMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Home Menu";
            this.Load += new System.EventHandler(this.LibraryHomeMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LBMS;
        private System.Windows.Forms.Button LBRS;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button MinimizedBtn;
        private System.Windows.Forms.Button RegisterNewMember;
        private LibraryBooksDatabaseDataSet3TableAdapters.membersTableAdapter membersTableAdapter;
        private System.Windows.Forms.Button NewUserBtn;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
    }
}
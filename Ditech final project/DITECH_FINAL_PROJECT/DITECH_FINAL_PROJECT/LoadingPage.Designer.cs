
namespace DITECH_FINAL_PROJECT
{
    partial class LoadingPage
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
            this.components = new System.ComponentModel.Container();
            this.loadinglabel = new System.Windows.Forms.Label();
            this.LoadingBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadinglabel
            // 
            this.loadinglabel.AutoSize = true;
            this.loadinglabel.BackColor = System.Drawing.Color.Black;
            this.loadinglabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadinglabel.ForeColor = System.Drawing.Color.White;
            this.loadinglabel.Location = new System.Drawing.Point(276, 252);
            this.loadinglabel.Name = "loadinglabel";
            this.loadinglabel.Size = new System.Drawing.Size(98, 20);
            this.loadinglabel.TabIndex = 1;
            this.loadinglabel.Text = "Loading...!";
            // 
            // LoadingBar
            // 
            this.LoadingBar.ForeColor = System.Drawing.Color.Red;
            this.LoadingBar.Location = new System.Drawing.Point(12, 287);
            this.LoadingBar.Name = "LoadingBar";
            this.LoadingBar.Size = new System.Drawing.Size(616, 23);
            this.LoadingBar.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(631, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO SM SYSTEM\r\n";
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.Color.Firebrick;
            this.WelcomeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WelcomeLabel.Font = new System.Drawing.Font("Adobe Gothic Std B", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.Gold;
            this.WelcomeLabel.Location = new System.Drawing.Point(12, 82);
            this.WelcomeLabel.Margin = new System.Windows.Forms.Padding(3);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(136, 50);
            this.WelcomeLabel.TabIndex = 3;
            this.WelcomeLabel.Text = "label2";
            // 
            // LoadingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImage = global::DITECH_FINAL_PROJECT.Properties.Resources._161016_high_school_graduation_f53b9e44b36f8927d2520c945926f1ce_fit_760w;
            this.ClientSize = new System.Drawing.Size(640, 390);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.LoadingBar);
            this.Controls.Add(this.loadinglabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingPage";
            this.Load += new System.EventHandler(this.LoadingPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label loadinglabel;
        private System.Windows.Forms.ProgressBar LoadingBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label WelcomeLabel;
    }
}
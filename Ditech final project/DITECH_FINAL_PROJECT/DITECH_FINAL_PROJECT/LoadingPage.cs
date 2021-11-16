using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DITECH_FINAL_PROJECT
{
    public partial class LoadingPage : Form
    {
        public LoadingPage(string name)
        {
            InitializeComponent();
            WelcomeLabel.Text =name;
        }
        private void LoadingPage_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int StartPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            StartPoint += 1;
            LoadingBar.Value = StartPoint;
            loadinglabel.Text ="Loading " + StartPoint.ToString() + "%";
            if(LoadingBar.Value == 100)
            {
                LoadingBar.Value = 0;
                timer1.Stop();
                this.Hide();
                MainMenu MM = new MainMenu(WelcomeLabel.Text);
                MM.Show();

            }
        }

        
    }
}

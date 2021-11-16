using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Managment_System
{
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }
        int StartPoint = 0;
        public void timer1_Tick(object sender, EventArgs e)
        {

            StartPoint += 2;
            progressBar1.Value = StartPoint;
            ProgessBarLabel.Text ="Please Wait.. Loading.." + StartPoint.ToString() + "%";

            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                this.Hide();
                LibraryHomeMenu LHM = new LibraryHomeMenu();
                LHM.Show();
            }
        }

        public void WelcomePage_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}

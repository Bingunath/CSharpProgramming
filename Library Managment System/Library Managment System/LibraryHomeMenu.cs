using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Library_Managment_System
{
    public partial class LibraryHomeMenu : Form
    {
        public LibraryHomeMenu()
        {
            InitializeComponent();
        }

        private void LibraryHomeMenu_Load(object sender, EventArgs e)
        {

            
            circularProgressBar1.Hide();
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
        }

        private void LBMS_Click(object sender, EventArgs e)
        {         
            
            circularProgressBar1.Show();
            for (int i = 1; i <=100; i++)
            {
                Thread.Sleep(80);
                circularProgressBar1.Value = i;
                circularProgressBar1.Update();
                circularProgressBar1.Text ="Loading.." + i.ToString() + "%";

                if (i == 100)
                {
                    circularProgressBar1.Hide();
                    this.Hide();
                    Library Lb = new Library();
                    Lb.Show();

                }
            }

            
        }

        private void LBRS_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage LP = new LoginPage();
            LP.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult MSG = MessageBox.Show("Do You want to Exit From this Application?", "WNAT TO EXIT?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (MSG == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MSG = DialogResult.No;
            }
        }

        private void MinimizedBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void RegisterNewMember_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm3 LF3 = new LoginForm3();
            LF3.Show();
            
        }

        private void NewUserBtn_Click(object sender, EventArgs e)
        {
            LoginPage2 NLP2 = new LoginPage2();
            NLP2.Show();
            this.Hide();
        }
        
    }
}

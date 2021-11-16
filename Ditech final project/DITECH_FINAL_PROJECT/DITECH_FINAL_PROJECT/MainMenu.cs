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
    public partial class MainMenu : Form
    {
        public MainMenu(string name)
        {
            InitializeComponent();
            label1.Text = name;
        }
        /*public MainMenu()
        {
            InitializeComponent();
        }*/


        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void ManageStudents_Click(object sender, EventArgs e)
        {
            studentRegistrationForm SRF = new studentRegistrationForm(label1.Text);
            SRF.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult ConfirmationMessage = MessageBox.Show("Do you want to log out from this session?", "WANT LOG OUT?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ConfirmationMessage == DialogResult.Yes)
            {
                loginpage lp = new loginpage();
                lp.Show();
                this.Hide();
                MessageBox.Show(label1.Text + " You have log out successfully", "Log out Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ConfirmationMessage = DialogResult.No;
            }
        }

        private void ManageUsers_Click(object sender, EventArgs e)
        {
            LoginPage2 LG2 = new LoginPage2();
            LG2.Show();
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            DialogResult ConfirmationMessage = MessageBox.Show("Do you want to log out from this session?", "WANT LOG OUT?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ConfirmationMessage == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                ConfirmationMessage = DialogResult.No;
            }
        }

        private void ManageCourses_Click(object sender, EventArgs e)
        {
            LoginPage3 LP3 = new LoginPage3();
            LP3.Show();
        }
    }
}

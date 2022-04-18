using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotelier_Hotel_ManagementSystem
{
    public partial class LoginPage : Form
    {
        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BinguTech\source\repos\Hotelier_Hotel_ManagementSystem\Hotelier_Hotel_ManagementSystem\DataBase\Hotelierbase.mdf;Integrated Security=True");
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string com = "select * from [users] where username = '" + UserNameTB.Text + "' and password= '" + PassWordTB.Text + "' ";
                Connection.Open();
                SqlCommand sc = new SqlCommand(com, Connection);
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                //DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                sda.Fill(ds);
                Connection.Close();

                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    this.Hide();
                    LoadingPage LP = new LoadingPage(UserNameTB.Text);
                    LP.Show();
                }
                else
                {
                    MessageBox.Show("Your username or password wrong..!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void ClearBTN_Click(object sender, EventArgs e)
        {
            UserNameTB.Text = "";
            PassWordTB.Text = "";
        }

        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*DialogResult exit = MessageBox.Show("Do you really want to Exit?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (exit == DialogResult.OK)
            {
                Application.Exit();
            }
            else if (exit == DialogResult.No)
            {
                e.Cancel = true;
            }*/
        }

        private void LoginPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SignUpBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage2 lp2 = new LoginPage2();
            lp2.Show();
        }
    }
}

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
    public partial class LoginPage2 : Form
    {
        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BinguTech\source\repos\Hotelier_Hotel_ManagementSystem\Hotelier_Hotel_ManagementSystem\DataBase\Hotelierbase.mdf;Integrated Security=True");
        public LoginPage2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string com = "select * from [users] where username = '"+UserNameTB.Text+"' and password = '"+PassWordTB.Text+"' ";
            Connection.Open();
            SqlCommand sc = new SqlCommand(com,Connection);
            Connection.Close();
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            int count = dt.Rows.Count;
            if(count == 1)
            {
                for (int i = 0; i < count; i++)
                {
                    if(dt.Rows[i]["accounttype"].ToString() == "admin")
                    {
                        UserNameTB.Text = "";
                        PassWordTB.Text = "";
                        this.Dispose();
                        Users us = new Users();
                        us.Show();

                    }
                    else
                    {
                        MessageBox.Show(UserNameTB.Text+ " you do not have access to this feature, Please contact the system administrator.","ONLY ADNIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        UserNameTB.Text = "";
                        PassWordTB.Text = "";
                        UserNameTB.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Your Username or Password invalid please try again...!", "INVALID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserNameTB.Text = "";
                PassWordTB.Text = "";
                UserNameTB.Focus();
            }
            
        }

        private void CancleBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage LG = new LoginPage();
            LG.Show();
        }
    }
}

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
using Dapper;

namespace Hotelier_Hotel_ManagementSystem
{
    public partial class PasswordReset : Form
    {
        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BinguTech\source\repos\Hotelier_Hotel_ManagementSystem\Hotelier_Hotel_ManagementSystem\DataBase\Hotelierbase.mdf;Integrated Security=True");
        //SqlConnection Connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\DataBase\Hotelierbase.mdf;Integrated Security = True");
        //SqlConnection Connection = new SqlConnection(SqlConnectionClass.ConnectionString);
        public PasswordReset(string name)
        {
            InitializeComponent();
            UsernameLB.Text = name;
        }

        private void PasswordReset_Load(object sender, EventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (NewPass1.Text != NewPass2.Text)
                {
                    MessageBox.Show("Password does not match please try again", "DOES NOT MATCH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (NewPass1.Text.Length < 6)
                {
                    MessageBox.Show("Password should contain minimum 6 characters", "INVALID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string com = "update [users] set password='" + NewPass1.Text + "', password2='" + NewPass2.Text + "' where username='" + UsernameLB.Text + "'  ";

                    Connection.Open();
                    SqlCommand sc = new SqlCommand(com, Connection);
                    sc.ExecuteNonQuery();
                    Connection.Close();

                    //usernameTB.Text = "";
                    NewPass1.Text = "";
                    NewPass2.Text = "";
                    MessageBox.Show("User "+UsernameLB.Text+ " password updated successfully...!", "SUCCESSFULL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    LoginPage lp = new LoginPage();
                    lp.Show();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}

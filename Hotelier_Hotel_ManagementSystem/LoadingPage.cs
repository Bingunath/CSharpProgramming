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
    public partial class LoadingPage : Form
    {
        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BinguTech\source\repos\Hotelier_Hotel_ManagementSystem\Hotelier_Hotel_ManagementSystem\DataBase\Hotelierbase.mdf;Integrated Security=True");
        int StartPoint = 0;
        public LoadingPage(string username)
        {
            InitializeComponent();
            UserLB.Text = username.ToUpper();


        }
        private void LoadingPage_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            //string username1 = username1;
            StartPoint += 5;
            progressBar1.Value = StartPoint;
            if (progressBar1.Value >= 0 && progressBar1.Value <= 20)
            {
                label1.Text = "Please Wait... ";
                label1.ForeColor = Color.Red;
            }
            if (progressBar1.Value >= 20 && progressBar1.Value <= 90)
            {
                label1.Text = "Granting access";
                label1.ForeColor = Color.Yellow;
            }
            if(progressBar1.Value >= 90 && progressBar1.Value <= 120)
            {
                label1.Text = "Loading the main Window...!";
                label1.ForeColor = Color.YellowGreen;
            }
            if (progressBar1.Value >= 120 && progressBar1.Value <= 150)
            {
                label1.Text = "Welcome to the HOTELIER...!";
                label1.ForeColor = Color.Orange;
            }
            if (progressBar1.Value == 150)
            {
                try
                {
                    progressBar1.Value = 0;
                    timer1.Stop();

                    string com = "select * from [users] where username = '" + UserLB.Text + "'";
                    Connection.Open();
                    SqlCommand sc = new SqlCommand(com,Connection);
                    Connection.Close();
                    SqlDataAdapter sda = new SqlDataAdapter(sc);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    int user = dt.Rows.Count;
                    if(user == 1)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            if (!(dt.Rows[i]["accounttype"].ToString() == "admin" || dt.Rows[i]["accounttype"].ToString() == "standard"))
                            {
                                this.Hide();
                                GuestUserPanel gup = new GuestUserPanel(UserLB.Text);
                                gup.Show();
                            }
                            else
                            {

                                this.Hide();
                                MainPage MP = new MainPage(UserLB.Text);
                                MP.Show();
                            }
                        }
                    }
                    else
                    {

                    }
                    
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                
                
            }
        }

        
    }
}

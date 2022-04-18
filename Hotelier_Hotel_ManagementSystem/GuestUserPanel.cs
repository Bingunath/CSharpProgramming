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
    public partial class GuestUserPanel : Form
    {
        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BinguTech\source\repos\Hotelier_Hotel_ManagementSystem\Hotelier_Hotel_ManagementSystem\DataBase\Hotelierbase.mdf;Integrated Security=True");
        public GuestUserPanel(string username)
        {
            InitializeComponent();
            UserNameLB.Text = username;
        }

        private void GuestUserPanel_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Today.ToLongDateString();
            Depature();
            Total_Inhouse();
            PoolUsers();
            GymUsers();
        }
        private void Depature()
        {
            try
            {
                string com = "select * from [inhouseguests] where checkout = '" + DepatureDTP.Value.ToString() + "' ";
                Connection.Open();
                SqlCommand sc = new SqlCommand(com, Connection);
                sc.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                //HouseGuestDataGrid.DataSource = dt;
                Connection.Close();

                if (dt.Rows.Count >= 1)
                {
                    DepLB.Text = dt.Rows.Count.ToString();
                }
                else
                {
                    DepLB.Text = "0";
                    //label16.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void Total_Inhouse()
        {
            try
            {
                Connection.Open();
                string Query1 = "select * from [inhouseguests]";
                SqlCommand cmd1 = new SqlCommand(Query1, Connection);
                Connection.Close();
                SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                occiLB.Text = dt1.Rows.Count.ToString();
            }
            catch
            {

            }

        }

        private void PoolUsers()
        {
            try
            {
                string com = "select * from [pooldata] where date = '" + poolgymusersDTP.Value.ToString() + "' ";
                Connection.Open();
                SqlCommand sc = new SqlCommand(com, Connection);
                sc.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                //HouseGuestDataGrid.DataSource = dt;
                Connection.Close();
                int sum = 0;
                int sum2 = 0;

                if (dt.Rows.Count >= 1)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        int count1 = sum += Convert.ToInt32(dt.Rows[i]["children"]);
                        int count2 = sum2 += Convert.ToInt32(dt.Rows[i]["adult"]);
                        PoolLB.Text = (count1 + count2).ToString();
                    }
                }
                else
                {
                    PoolLB.Text = "0";
                }

            }
            catch
            {

            }
        }
        private void GymUsers()
        {
            try
            {
                string com = "select * from [gymdata] where date = '" + poolgymusersDTP.Value.ToString() + "' ";
                Connection.Open();
                SqlCommand sc = new SqlCommand(com, Connection);
                sc.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                //HouseGuestDataGrid.DataSource = dt;
                Connection.Close();
                int sum = 0;

                if (dt.Rows.Count >= 1)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        int count2 = sum += Convert.ToInt32(dt.Rows[i]["adult"]);
                        GymLB.Text = count2.ToString();
                    }
                }
                else
                {
                    GymLB.Text = "0";
                }

            }
            catch
            {

            }

        }

        private void GuestUserPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Depature();
            Total_Inhouse();
            PoolUsers();
            GymUsers();
        }

        private void poolusers_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "PoolUsage")
                {
                    IsOpen = true;
                    f.Focus();
                    break;

                }
            }
            if (IsOpen == false)
            {
                PoolUsage PU = new PoolUsage();
                PU.Show();
            }
        }

        private void gymusers_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Gym")
                {
                    IsOpen = true;
                    f.Focus();
                    break;

                }
            }
            if (IsOpen == false)
            {
                Gym gym = new Gym();
                gym.Show();
            }
        }

        private void occiLB_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "InHouseGuests")
                {
                    IsOpen = true;
                    f.Focus();
                    break;

                }
            }
            if (IsOpen == false)
            {
                InHouseGuests IHG = new InHouseGuests();
                IHG.Show();
            }
        }

        private void DepLB_Click(object sender, EventArgs e)
        {
            /*bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Depature")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                Depature DP = new Depature();
                DP.Show();
            }*/
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(UserNameLB.Text.ToUpperInvariant() + " Do You want to Log Out?", "LOG-OUT?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {

                    foreach (Form f in Application.OpenForms)
                    {
                        if (!f.Focused)
                        {
                            f.Visible = false;
                            f.Dispose();

                        }
                        if (f.IsDisposed)
                        {
                            Application.Restart();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                dialog = DialogResult.No;
            }
        }

        private void poolgymusersDTP_ValueChanged(object sender, EventArgs e)
        {
            PoolUsers();
            GymUsers();
        }

        private void DepatureDTP_ValueChanged(object sender, EventArgs e)
        {
            Depature();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/bingunath-kalhara-487aa7202/");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Bingunath");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            HotelierAbout HAB = new HotelierAbout();
            HAB.Show();
        }
    }
}

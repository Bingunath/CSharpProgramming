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
    public partial class MainPage : Form
    {
        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BinguTech\source\repos\Hotelier_Hotel_ManagementSystem\Hotelier_Hotel_ManagementSystem\DataBase\Hotelierbase.mdf;Integrated Security=True");
        //SqlConnection Connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\DataBase\Hotelierbase.mdf;Integrated Security = True");
        //SqlConnection Connection = new SqlConnection(SqlConnectionClass.ConnectionString);
        private int childFormNumber = 0;

        public MainPage(string username)
        {
            InitializeComponent();
            logOutToolStripMenuItem.Text = username.ToUpper();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //foreach (Form childForm in MdiChildren)
            //{
                //childForm.Close();
            //}
        }

        private void guuestProfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {                    
            
        }

        private void createGuestProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Guest Profiles")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                GuestProfiles GP = new GuestProfiles();
                GP.Show();
            }*/
            InfoBox IB = new InfoBox();
            IB.Show();
        }

        private void gymToolStripMenuItem_Click(object sender, EventArgs e)
        {           
          
        }

        private void gymDailyUsageToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void registerGymMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "RegisterGymMembers")
                {
                    IsOpen = true;
                    f.Focus();
                    break;

                }
            }
            if (IsOpen == false)
            {
                RegisterGymMembers RGM = new RegisterGymMembers();
                RGM.Show();
            }
            
        }

        private void poolUsageToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void createReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*bool IsOpen = false;

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
                CreateReservation CR = new CreateReservation();
                CR.Show();
            }*/
            InfoBox IB = new InfoBox();
            IB.Show();

        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            
            //AutoGreeting();
            label2.Text = DateTime.Today.ToLongDateString();
            Depature();
            Total_Inhouse();
            Total_GymMembers();
            MembershipRenewals();
            PoolUsers();
            GymUsers();
            
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void inHouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen =false;

            foreach(Form f in Application.OpenForms)
            {
                if(f.Text == "InHouseGuests")
                {
                    IsOpen = true;
                    f.Focus();
                    break;

                }
            }
            if ( IsOpen == false)
            {
                InHouseGuests IHG = new InHouseGuests();
                IHG.Show();
            }
            
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exit = MessageBox.Show("Do you really want to exit?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                exit = DialogResult.No;
            }
        }

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult exit = MessageBox.Show("Do you really want to exit?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                exit = DialogResult.No;
            }
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        /*private IDbConnection SqlConnection(string connectionString)
        {
            //throw new NotImplementedException();
        }*/

        private void MembershipRenewals()
        {
            try
            {
                string com4 = "select * from [gymmembership] where expires = '" + RenewalDTP.Value.ToString() + "' ";
                Connection.Open();
                SqlCommand sc4 = new SqlCommand(com4, Connection);
                sc4.ExecuteNonQuery();
                SqlDataAdapter sda4 = new SqlDataAdapter(sc4);
                DataTable dt4 = new DataTable();
                sda4.Fill(dt4);
                //HouseGuestDataGrid.DataSource = dt;
                Connection.Close();

                if (dt4.Rows.Count >= 1)
                {
                    RenewalLB.Text = dt4.Rows.Count.ToString();
                }
                else
                {
                    RenewalLB.Text = "0";
                    //label16.Visible = true;
                }
            }
            catch
            {

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
        public void Total_GymMembers()
        {
            try
            {
                Connection.Open();
                string Query1 = "select * from [gymmembers]";
                SqlCommand cmd1 = new SqlCommand(Query1, Connection);
                Connection.Close();
                SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                MembersLB.Text = ((dt1.Rows.Count) - 1).ToString();
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


        private void DepatureDTP_ValueChanged(object sender, EventArgs e)
        {
            Depature();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Depature();
            Total_Inhouse();
            Total_GymMembers();
            MembershipRenewals();
            PoolUsers();
            GymUsers();
        }

        private void DepLB_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

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

        private void MainPage_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            
        }

        private void MainPage_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult exit = MessageBox.Show(logOutToolStripMenuItem.Text.ToUpperInvariant()+" Do you really want to Exit?", "Quit", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);

            if (exit == DialogResult.OK)
            {
                Application.Exit();
            }
            else if(exit == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void departureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if(f.Text == "Depature")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if(IsOpen == false)
            {
                Depature DP = new Depature();
                DP.Show();
            }

            
        }

        private void MainPage_FormClosed_2(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MembersLB_Click(object sender, EventArgs e)
        {
            RegisterGymMembers RGM = new RegisterGymMembers();
            RGM.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            HotelierAbout HAB = new HotelierAbout();
            HAB.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/bingunath-kalhara-487aa7202/");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Bingunath");
        }

        private void RenewalDTP_ValueChanged(object sender, EventArgs e)
        {
            MembershipRenewals();
        }

        private void RenewalLB_Click(object sender, EventArgs e)
        {
            RegisterGymMembers RGM = new RegisterGymMembers();
            RGM.Show();
        }

        private void poolgymusersDTP_ValueChanged(object sender, EventArgs e)
        {
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            //groupBox2.Enabled = true;
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoBox IB = new InfoBox();
            IB.Show();
        }

        private void kidsClubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoBox IB = new InfoBox();
            IB.Show();
        }

        private void manageReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoBox IB = new InfoBox();
            IB.Show();
        }

        private void registerNewMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoBox IB = new InfoBox();
            IB.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(logOutToolStripMenuItem.Text.ToUpperInvariant() + " Do You want to Log Out?", "LOG-OUT?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
    }
}

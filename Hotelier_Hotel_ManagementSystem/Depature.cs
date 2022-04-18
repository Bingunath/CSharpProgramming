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
    public partial class Depature : Form
    {
        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BinguTech\source\repos\Hotelier_Hotel_ManagementSystem\Hotelier_Hotel_ManagementSystem\DataBase\Hotelierbase.mdf;Integrated Security=True");
        //SqlConnection Connection = new SqlConnection(SqlConnectionClass.ConnectionString);
        public Depature()
        {
            InitializeComponent();
        }

        private void Depature_Load(object sender, EventArgs e)
        {
            Depature1();
            Random_Referance();
            Total_Inhouse();
            TotalAdults();
            TotalChildren();
            TotalHeadCount();
            errorLB.Visible = false;
            label1.Text = "Data Table is empty right now.";
        }
        public void Random_Referance()
        {
            Random Number = new Random();
            int Number1 = Number.Next(00000, 1000000);
            IdTB.Text = Number1.ToString();
        }

        private void Depature1()
        {
            string com = "select * from [inhouseguests] where checkout between '" + CheckINDTP.Value.ToString() + "' and '" + CheckOutDTP.Value.ToString() + "' ";
            Connection.Open();
            SqlCommand sc = new SqlCommand(com, Connection);
            sc.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DepatureDataGrid.DataSource = dt;
            Connection.Close();

            if (dt.Rows.Count >= 1)
            {
                label1.Text = "";
                label1.Visible = false;
            }
            else
            {
                label1.Text = "No guest data found..!";
                label1.Visible = true;
            }
        }

        public void Total_Inhouse()
        {

            /*Connection.Open();
            string Query1 = "select * from [inhouseguests]";
            SqlCommand cmd1 = new SqlCommand(Query1, Connection);
            Connection.Close();
            SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            label14.Text = dt1.Rows.Count.ToString();*/

            label14.Text = ((DepatureDataGrid.Rows.Count)-1).ToString();
        }

        public void TotalAdults()
        {
            int totaladults = 0;
            for(int i = 0; i < DepatureDataGrid.Rows.Count; i++)
            {
                totaladults = totaladults + Convert.ToInt32(DepatureDataGrid.Rows[i].Cells[10].Value);
            }
            TotalAdultLB.Text = totaladults.ToString();
            /*string com = "select * from [inhouseguests]";
            Connection.Open();
            SqlCommand sc = new SqlCommand(com, Connection);
            Connection.Close();
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int sum = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int count = sum += Convert.ToInt32(dt.Rows[i]["adults"]);
                TotalAdultLB.Text = count.ToString();
            }*/
        }

        public void TotalChildren()
        {
            int totalchildren = 0;
            for (int i = 0;i< DepatureDataGrid.Rows.Count;i++)
            {
                totalchildren = totalchildren + Convert.ToInt32(DepatureDataGrid.Rows[i].Cells[11].Value);
            }
            TotalChildrenLB.Text = totalchildren.ToString();
            /*string com = "select * from [inhouseguests]";
            Connection.Open();
            SqlCommand sc = new SqlCommand(com, Connection);
            Connection.Close();
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int sum = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int count = sum += Convert.ToInt32(dt.Rows[i]["children"]);
                TotalChildrenLB.Text = count.ToString();
            }*/


        }
        public void TotalHeadCount()
        {
            int headcount = 0;
            for(int i=0;i< DepatureDataGrid.Rows.Count; i++)
            {
                headcount = headcount + Convert.ToInt32(DepatureDataGrid.Rows[i].Cells[10].Value) + Convert.ToInt32(DepatureDataGrid.Rows[i].Cells[11].Value);
            }
            TotalInhouseLB.Text = headcount.ToString();
            
            /*string com = "select * from [inhouseguests]";
            Connection.Open();
            SqlCommand sc = new SqlCommand(com, Connection);
            Connection.Close();
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int sum = 0;
            int sum2 = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int count1 = sum += Convert.ToInt32(dt.Rows[i]["children"]);
                int count2 = sum2 += Convert.ToInt32(dt.Rows[i]["adults"]);
                TotalInhouseLB.Text = (count1 + count2).ToString();
            }*/

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string com = "delete from [inhouseguests] where id = '" + IdTB.Text + "' ";
            Connection.Open();
            SqlCommand cmd = new SqlCommand(com, Connection);
            cmd.ExecuteNonQuery();
            Connection.Close();
            IdTB.Text = "";
            TitleTB.Text = "";
            FnameTB.Text = "";
            LnameTB.Text = "";
            RoomNoTB.Text = "";
            RoomTypeTB.Text = "";
            //CheckINDTP.ResetText();
            //CheckOutDTP.ResetText();
            DurationTB.Text = "0";
            AcompanyTB.Text = "";
            AdultsTB.Text = "0";
            ChildrenTB.Text = "0";
            //Display();
            Depature1();
            //AutoGeneratedCode();
            Random_Referance();
            Total_Inhouse();
            TotalAdults();
            TotalChildren();
            TotalHeadCount();
            //HouseGuestDataGrid.DataSource = null;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            IdTB.Text = "";
            TitleTB.Text = "";
            FnameTB.Text = "";
            LnameTB.Text = "";
            RoomNoTB.Text = "";
            RoomTypeTB.Text = "";
            CheckINDTP.ResetText();
            CheckOutDTP.ResetText();
            DurationTB.Text = "0";
            AcompanyTB.Text = "";
            AdultsTB.Text = "0";
            ChildrenTB.Text = "0";
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                IdTB.Text = DepatureDataGrid.SelectedRows[0].Cells[0].Value.ToString();
                TitleTB.Text = DepatureDataGrid.SelectedRows[0].Cells[1].Value.ToString();
                FnameTB.Text = DepatureDataGrid.SelectedRows[0].Cells[2].Value.ToString();
                LnameTB.Text = DepatureDataGrid.SelectedRows[0].Cells[3].Value.ToString();
                RoomNoTB.Text = DepatureDataGrid.SelectedRows[0].Cells[4].Value.ToString();
                RoomTypeTB.Text = DepatureDataGrid.SelectedRows[0].Cells[5].Value.ToString();
                DurationTB.Text = DepatureDataGrid.SelectedRows[0].Cells[8].Value.ToString();
                AcompanyTB.Text = DepatureDataGrid.SelectedRows[0].Cells[9].Value.ToString();
                AdultsTB.Text = DepatureDataGrid.SelectedRows[0].Cells[10].Value.ToString();
                ChildrenTB.Text = DepatureDataGrid.SelectedRows[0].Cells[11].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Please select data row that you want to edit");
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = IdTB.Text;
                string FirstName = FnameTB.Text;
                string LastName = LnameTB.Text;
                string Room = RoomNoTB.Text;
                string RoomType = RoomTypeTB.Text;
                if (ID == "" || FirstName == "" || LastName == "" || Room == "" || RoomType == "")
                {
                    MessageBox.Show("Please Fill the required fields", "Please Fill", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string com = "update [inhouseguests] set title= '" + TitleTB.Text + "', firstname = '" + FnameTB.Text + "',lastname= '" + LnameTB.Text + "', roomno ='" + RoomNoTB.Text + "',roomtype= '" + RoomTypeTB.Text + "',checkin ='" + CheckINDTP.Value.ToString() + "',checkout= '" + CheckOutDTP.Value.ToString() + "',duration = '" + DurationTB.Text + "',acompany= '" + AcompanyTB.Text + "',adults= '" + AdultsTB.Text + "',children= '" + ChildrenTB.Text + "' where   id = '" + IdTB.Text + "' ";

                    Connection.Open();
                    SqlCommand cmd = new SqlCommand(com, Connection);
                    cmd.ExecuteNonQuery();
                    Connection.Close();
                    IdTB.Text = "";
                    TitleTB.Text = "";
                    FnameTB.Text = "";
                    LnameTB.Text = "";
                    RoomNoTB.Text = "";
                    RoomTypeTB.Text = "";
                    //CheckINDTP.ResetText();
                    //CheckOutDTP.ResetText();
                    DurationTB.Text = "";
                    AcompanyTB.Text = "";
                    AdultsTB.Text = "";
                    ChildrenTB.Text = "";
                    Depature1();
                    TotalAdults();
                    TotalChildren();
                    TotalHeadCount();
                    Random_Referance();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            
        }

        private void CheckINDTP_ValueChanged_1(object sender, EventArgs e)
        {
            Depature1();
            Total_Inhouse();
            TotalAdults();
            TotalChildren();
            TotalHeadCount();
            DateTime Checkin = CheckINDTP.Value;
            DateTime Checkout = CheckOutDTP.Value;

            TimeSpan Du = (Checkout - Checkin);
            int days = Convert.ToInt32(Du.TotalDays);
            DurationTB.Text = days.ToString() + " Days";
        }
        private void CheckOutDTP_ValueChanged_1(object sender, EventArgs e)
        {
            Depature1();
            Total_Inhouse();
            TotalAdults();
            TotalChildren();
            TotalHeadCount();
            DateTime Checkin = CheckINDTP.Value;
            DateTime Checkout = CheckOutDTP.Value;

            TimeSpan Du = (Checkout - Checkin);
            int days = Convert.ToInt32(Du.TotalDays);
            DurationTB.Text = days.ToString() + " Days";
        }

        private void RoomNoTB_TextChanged(object sender, EventArgs e)
        {
            if (RoomNoTB.Text == "")
            {
                Depature1();
                errorLB.Visible = false;
                errorLB.Text = "";
                TotalAdults();
                TotalChildren();
                TotalHeadCount();
            }
            else
            {
                string com = "select * from [inhouseguests] where roomno = '" + RoomNoTB.Text + "' ";
                Connection.Open();
                SqlCommand sc = new SqlCommand(com, Connection);
                Connection.Close();
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DepatureDataGrid.DataSource = dt;

                if (dt.Rows.Count == 1)
                {
                    errorLB.Visible = true;
                    errorLB.Text = "Room is already occupied";
                    label1.Text = "";
                    label1.Visible = false;
                    TotalAdults();
                    TotalChildren();
                    TotalHeadCount();
                }
                else
                {
                    errorLB.Visible = false;
                    errorLB.Text = "";
                    label1.Text = "Chart is empty right now.";
                    label1.Visible = true;

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label1.Text = "Data Table is empty right now.";
                label1.Visible = true;

                string com = "select * from [inhouseguests] where id like'" + textBox1.Text + "%' or firstname like '" + textBox1.Text + "%' or lastname like '" + textBox1.Text + "%' or roomno like '" + textBox1.Text + "%' and checkin between  '" + CheckINDTP.Value.ToString() + "' and '" + CheckOutDTP.Value.ToString() + "' ";
                Connection.Open();
                SqlCommand sc = new SqlCommand(com, Connection);
                sc.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DepatureDataGrid.DataSource = null;
                Connection.Close();
            }
            else
            {

                string com = "select * from [inhouseguests] where id like'" + textBox1.Text + "%' or firstname like '" + textBox1.Text + "%' or lastname like '" + textBox1.Text + "%' or roomno like '" + textBox1.Text + "%' and checkin between  '" + CheckINDTP.Value.ToString() + "' and '" + CheckOutDTP.Value.ToString() + "' ";
                Connection.Open();
                SqlCommand sc = new SqlCommand(com, Connection);
                sc.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DepatureDataGrid.DataSource = dt;
                if (dt.Rows.Count >= 1)
                {
                    label1.Text = "";
                    label1.Visible = false;
                }
                else
                {
                    label1.Text = "No guest data found..!";
                    label1.Visible = true;
                }

                Connection.Close();
                TotalAdults();
                TotalChildren();
                TotalHeadCount();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DepatureDataGrid_Click(object sender, EventArgs e)
        {
            try
            {
                TotalAdultLB.Text = DepatureDataGrid.SelectedRows[0].Cells[10].Value.ToString();
                TotalChildrenLB.Text = DepatureDataGrid.SelectedRows[0].Cells[11].Value.ToString();
                int total = Convert.ToInt32(DepatureDataGrid.SelectedRows[0].Cells[10].Value) + Convert.ToInt32(DepatureDataGrid.SelectedRows[0].Cells[11].Value);
                TotalInhouseLB.Text = total.ToString();
            }
            catch
            {
                MessageBox.Show("Cells are empty");
                TotalInhouseLB.Text = "0";
                TotalAdultLB.Text = "0";
                TotalChildrenLB.Text = "0";
            }
        }
    }
}

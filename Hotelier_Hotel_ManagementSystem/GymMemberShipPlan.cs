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
    public partial class GymMemberShipPlan : Form
    {
        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BinguTech\source\repos\Hotelier_Hotel_ManagementSystem\Hotelier_Hotel_ManagementSystem\DataBase\Hotelierbase.mdf;Integrated Security=True");
        //SqlConnection Connection = new SqlConnection(SqlConnectionClass.ConnectionString);
        public GymMemberShipPlan()
        {
            InitializeComponent();
        }

        private void GymMemberShipPlan_Load(object sender, EventArgs e)
        {
            Display();
            RandomNumber();
            AutoNumbers();
        }
        public void Display()
        {
            string comm = "select * from [membershipplan]";
            Connection.Open();
            SqlCommand sc = new SqlCommand(comm, Connection);
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            PlanGrid.DataSource = dt;
            Connection.Close();
        }
        public void RandomNumber()
        {
            Random Num = new Random();
            int num = Num.Next(0,100);
            NoTB.Text = num.ToString();
        }

        public void AutoNumbers()
        {
            string com = "select * from [membershipplan]";
            Connection.Open();
            SqlCommand sc = new SqlCommand(com,Connection);
            Connection.Close();
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            for (int i= 0; i<dt.Rows.Count; i++)
            {
                int Auto = Convert.ToInt32(dt.Rows[i]["no"].ToString());
                NoTB.Text = (Auto + 1).ToString();
            }
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string Plan = PlanTB.Text;
            string ValidDays = ValidTB.Text;
            string Privilages = PrivilageTB.Text;
            string Prices = PriceTB.Text;

            if (Plan == "" || ValidDays == "" || Privilages == "" || Prices == "")
            {
                MessageBox.Show("Please Fill the required fields", "Please Fill", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string com = "insert into [membershipplan] (no,membershipplan,valid,privilages,price)" +
                "values('" + NoTB.Text + "','" + PlanTB.Text + "','" + ValidTB.Text + "','" + PrivilageTB.Text + "','" + PriceTB.Text + "')";
                Connection.Open();
                SqlCommand cmd = new SqlCommand(com, Connection);
                cmd.ExecuteNonQuery();
                Connection.Close();

                NoTB.Text = "";
                PlanTB.Text = "";
                ValidTB.Text = "";
                PrivilageTB.Text = "";
                PriceTB.Text = "";
                Display();
                //RandomNumber();
                AutoNumbers();
            }
        }


        private void ClearBtn_Click(object sender, EventArgs e)
        {
            PlanTB.Text = "";
            ValidTB.Text = "";
            PrivilageTB.Text = "";
            PriceTB.Text = "";
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string com = "delete from [membershipplan] where no = '" + NoTB.Text + "' ";
            Connection.Open();
            SqlCommand cmd = new SqlCommand(com, Connection);
            cmd.ExecuteNonQuery();
            Connection.Close();

            PlanTB.Text = "";
            ValidTB.Text = "";
            PrivilageTB.Text = "";
            PriceTB.Text = "";
            Display();
            //RandomNumber();
            AutoNumbers();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string com = "update [membershipplan] set membershipplan = '" + PlanTB.Text + "',valid= '" + ValidTB.Text + "', privilages ='" + PrivilageTB.Text + "',price= '" + PriceTB.Text + "' where no = '" + NoTB.Text + "' ";
            Connection.Open();
            SqlCommand cmd = new SqlCommand(com, Connection);
            cmd.ExecuteNonQuery();
            Connection.Close();

            PlanTB.Text = "";
            ValidTB.Text = "";
            PrivilageTB.Text = "";
            PriceTB.Text = "";
            Display();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            NoTB.Text = PlanGrid.SelectedRows[0].Cells[0].Value.ToString();
            PlanTB.Text = PlanGrid.SelectedRows[0].Cells[1].Value.ToString();
            ValidTB.Text = PlanGrid.SelectedRows[0].Cells[2].Value.ToString();
            PrivilageTB.Text = PlanGrid.SelectedRows[0].Cells[3].Value.ToString();
            PriceTB.Text = PlanGrid.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void NoTB_TextChanged(object sender, EventArgs e)
        {
            string com = "select * from [membershipplan] where no ='" + NoTB.Text + "' ";
            Connection.Open();
            SqlCommand sc = new SqlCommand(com, Connection);
            Connection.Close();
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            int count = dt.Rows.Count;
            if (count == 1)
            {
                SaveBtn.Enabled = false;
            }
            else
            {
                SaveBtn.Enabled = true;
            }
        }

        private void AutoNumbersBtn_Click(object sender, EventArgs e)
        {
            AutoNumbers();
        }
    }
}
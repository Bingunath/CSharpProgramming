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
    public partial class GuestProfiles : Form
    {
        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BinguTech\source\repos\Hotelier_Hotel_ManagementSystem\Hotelier_Hotel_ManagementSystem\DataBase\Hotelierbase.mdf;Integrated Security=True");
        //SqlConnection Connection = new SqlConnection(SqlConnectionClass.ConnectionString);
        public GuestProfiles()
        {
            InitializeComponent();
        }

        private void GuestProfiles_Load(object sender, EventArgs e)
        {
            Display();
            Random_Referance();
        }
        public void Display()
        {
            string com = "select * from [guestprofile]";
            Connection.Open();
            SqlCommand sc = new SqlCommand(com,Connection);
            Connection.Close();
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GuestDataGrid.DataSource = dt;
        }
        public void Random_Referance()
        {
           
            Random Number = new Random();
            int Number1 = Number.Next(0000000, 1000000);
            RefTB.Text = Number1.ToString() ;
        }

        private void TitleCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            TitleTB.Text = TitleCB.SelectedItem.ToString();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Random_Referance();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string REF = RefTB.Text;
            string Fname = FirstNTB.Text;
            string Mname = MiddleNTB.Text;
            string Lname = LastNTB.Text;
            string ID = IDnoTB.Text;
            string HomeA = HomeATB.Text;
            string CurrentA = CurrentATB.Text;

            if (REF == "" || Fname == "" || Mname == "" || Lname =="" || ID == "" || HomeA == "" || CurrentA == "")
            {
                MessageBox.Show("Please Fill the required fields", "Please Fill", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string com = "insert into [guestprofile](refid,title,firstname,middlename,lastname,dob,mobileno,idno,passport,nationality,homeaddress,currentaddress)" +
                    "values('"+RefTB.Text+ "','"+TitleTB.Text+ "','"+FirstNTB.Text+"','"+MiddleNTB.Text+ "','"+LastNTB.Text+ "', '"+DOBDTP.Value.ToString()+ "','"+MobileTB.Text+ "','"+IDnoTB.Text+ "','"+PassportTB.Text+ "','"+NationalityTB.Text+ "','"+HomeATB.Text+ "','"+CurrentATB.Text+"' ) ";
                Connection.Open();
                SqlCommand sc = new SqlCommand(com,Connection);
                sc.ExecuteNonQuery();
                Connection.Close();
                RefTB.Text = "";
                TitleTB.Text = "";
                FirstNTB.Text = "";
                MiddleNTB.Text = "";
                LastNTB.Text = "";
                DOBDTP.ResetText();
                MobileTB.Text = "";
                IDnoTB.Text = "";
                PassportTB.Text = "";
                NationalityTB.Text = "";
                HomeATB.Text = "";
                CurrentATB.Text = "";
                Display();
                Random_Referance();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string com = "delete from [guestprofile] where refid ='"+RefTB.Text+"' ";
            Connection.Open();
            SqlCommand sc = new SqlCommand(com, Connection);
            sc.ExecuteNonQuery();
            Connection.Close();
            RefTB.Text = "";
            TitleTB.Text = "";
            FirstNTB.Text = "";
            MiddleNTB.Text = "";
            LastNTB.Text = "";
            DOBDTP.ResetText();
            MobileTB.Text = "";
            IDnoTB.Text = "";
            PassportTB.Text = "";
            NationalityTB.Text = "";
            HomeATB.Text = "";
            CurrentATB.Text = "";
            Display();
            Random_Referance();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            RefTB.Text = "";
            TitleTB.Text = "";
            FirstNTB.Text = "";
            MiddleNTB.Text = "";
            LastNTB.Text = "";
            DOBDTP.ResetText();
            MobileTB.Text = "";
            IDnoTB.Text = "";
            PassportTB.Text = "";
            NationalityTB.Text = "";
            HomeATB.Text = "";
            CurrentATB.Text = "";
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string com = "update [guestprofile] set title='"+TitleTB.Text+"', firstname='"+FirstNTB.Text+ "',middlename='"+MiddleNTB.Text+ "',lastname ='"+LastNTB.Text+ "',dob='"+DOBDTP.Value.ToString()+ "',mobileno='"+MobileTB.Text+ "',idno='"+IDnoTB.Text+ "',Passport='"+PassportTB.Text+ "',nationality='"+NationalityTB.Text+ "',homeaddress='"+HomeATB.Text+ "',currentaddress='"+CurrentATB.Text+"'  where refid ='" + RefTB.Text + "' ";
            Connection.Open();
            SqlCommand sc = new SqlCommand(com, Connection);
            sc.ExecuteNonQuery();
            Connection.Close();
            RefTB.Text = "";
            TitleTB.Text = "";
            FirstNTB.Text = "";
            MiddleNTB.Text = "";
            LastNTB.Text = "";
            DOBDTP.ResetText();
            MobileTB.Text = "";
            IDnoTB.Text = "";
            PassportTB.Text = "";
            NationalityTB.Text = "";
            HomeATB.Text = "";
            CurrentATB.Text = "";
            Display();
            Random_Referance();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            RefTB.Text = GuestDataGrid.SelectedRows[0].Cells[0].Value.ToString();
            TitleTB.Text = GuestDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            FirstNTB.Text = GuestDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            MiddleNTB.Text = GuestDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            LastNTB.Text = GuestDataGrid.SelectedRows[0].Cells[4].Value.ToString();
            DOBDTP.CustomFormat = GuestDataGrid.SelectedRows[0].Cells[5].Value.ToString();
            MobileTB.Text = GuestDataGrid.SelectedRows[0].Cells[6].Value.ToString();
            IDnoTB.Text = GuestDataGrid.SelectedRows[0].Cells[7].Value.ToString();
            PassportTB.Text = GuestDataGrid.SelectedRows[0].Cells[8].Value.ToString();
            NationalityTB.Text = GuestDataGrid.SelectedRows[0].Cells[9].Value.ToString();
            HomeATB.Text = GuestDataGrid.SelectedRows[0].Cells[10].Value.ToString();
            CurrentATB.Text = GuestDataGrid.SelectedRows[0].Cells[11].Value.ToString();
        }

        private void RefTB_TextChanged(object sender, EventArgs e)
        {
            string com = "select * from [guestprofile] where refid ='" + RefTB.Text + "' ";
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
    }
}

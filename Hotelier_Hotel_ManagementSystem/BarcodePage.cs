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
    public partial class BarcodePage : Form
    {
        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BinguTech\source\repos\Hotelier_Hotel_ManagementSystem\Hotelier_Hotel_ManagementSystem\DataBase\Hotelierbase.mdf;Integrated Security=True");
        //SqlConnection Connection = new SqlConnection(SqlConnectionClass.ConnectionString);
        public BarcodePage()
        {
            InitializeComponent();
        }

        private void Barcode_Load(object sender, EventArgs e)
        {
            Display();
            MembersList();
        }

        public void MembersList()
        {
            string com = "select * from [gymmembers]";
            Connection.Open();
            SqlCommand sc = new SqlCommand(com,Connection);
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Connection.Close();

            for(int i =0; i<dt.Rows.Count; i++)
            {
                MemberIDCB.Items.Add(dt.Rows[i]["membershipid"].ToString());
            }
        }
        public void Display()
        {
            string comm = "select * from [gymmembers]";
            Connection.Open();
            SqlCommand sc = new SqlCommand(comm, Connection);
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GymMembersGrid.DataSource = dt;
            Connection.Close();
        }

        private void MemberIDCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string com = "select * from [gymmembers] where membershipid ='"+MemberIDCB.SelectedItem.ToString()+"' ";
            Connection.Open();
            SqlCommand sc = new SqlCommand(com, Connection);
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Connection.Close();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                BarcodeTB.Text = dt.Rows[i]["snno"].ToString();
            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            string com = "select * from [gymmembers] where membershipid ='" + SearchBox.Text + "' or name like '"+SearchBox.Text+"%' ";
            Connection.Open();
            SqlCommand sc = new SqlCommand(com, Connection);
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GymMembersGrid.DataSource = dt;
            Connection.Close();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                BarcodeTB.Text = dt.Rows[i]["snno"].ToString();
            }
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            BarcodeLib.Barcode barcode = new BarcodeLib.Barcode();
            Image img = barcode.Encode(BarcodeLib.TYPE.CODE128, BarcodeTB.Text, Color.Black,Color.White,300,100) ;
            pictureBox1.Image = img;
        }
    }
}

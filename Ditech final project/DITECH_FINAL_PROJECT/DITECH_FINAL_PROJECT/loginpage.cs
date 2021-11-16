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

namespace DITECH_FINAL_PROJECT
{
    public partial class loginpage : Form
    {
       
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Trusted_Connection=Yes;Integrated Security=True;");
        public loginpage()
        {
            InitializeComponent();
        }

        private void loginpage_Load(object sender, EventArgs e)
        {
            ComboBox_load();
            usrnameTB.Enabled = false;
        }

        public void ComboBox_load()
        {
            connection.Open();
            SqlCommand sc = connection.CreateCommand();
            sc.CommandType = CommandType.Text;
            sc.CommandText = "select * from [login]";
            sc.ExecuteNonQuery();

            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            
            foreach(DataRow dr in dt.Rows)
            {
                UserListBox.Items.Add(dr["userid"].ToString());
            }
            connection.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string username = usrnameTB.Text;
            string password = passwdTB.Text;

            if (username =="" && password == "")
            {
                MessageBox.Show("Please Enter Username and Password","Empty Values", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {


                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [login] where username=@Username and password=@Password";
                cmd.Parameters.AddWithValue("@Username",username);
                cmd.Parameters.AddWithValue("@Password", password);

                
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                connection.Close();
                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {

                    LoadingPage LP = new LoadingPage(usrnameTB.Text);
                    LP.Show();
                    //MessageBox.Show("Login Success..!","SUCCESS!", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Hide();

                }
                else
                {
                    MessageBox.Show(" INVALID PASSWORD..! Login not Success..!", "NOT SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passwdTB.Text = "";
                }


            }
        }

        private void extbtn_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Do you want exit from this application?","EXIT",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                confirm =DialogResult.No;
            }
        }

        private void newusr_Click(object sender, EventArgs e)
        {
            newuser p3 = new newuser();
            p3.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            //for (int i = 0; i< UserListBox.Items.Count; i++)
            //{
               // if (UserListBox.SelectedItem == UserListBox.Items[i])
                //{
                    UserIdTB.Text = UserListBox.SelectedItem.ToString();
                //}
                //else
                //{
                //}
            //}
            
        }

        private void UserIdTB_TextChanged(object sender, EventArgs e)
        {
            if(UserIdTB.Text == "")
            {
                usrnameTB.Text = "";
            }
            else
            {
                connection.Open();
                SqlCommand sc = connection.CreateCommand();
                sc.CommandType = CommandType.Text;
                sc.CommandText = "select * from [login] where userid = '" + UserIdTB.Text + "' ";



                SqlDataAdapter sda = new SqlDataAdapter(sc);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                SqlDataReader dr = sc.ExecuteReader();
                if (dr.Read())
                {
                    usrnameTB.Text = (dr["username"].ToString());
                }
                else
                {
                    usrnameTB.Text = "NO USER FOUND";
                }
                connection.Close();
            }
            
        }
    }
}

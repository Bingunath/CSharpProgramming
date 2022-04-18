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
    public partial class Users : Form
    {
        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BinguTech\source\repos\Hotelier_Hotel_ManagementSystem\Hotelier_Hotel_ManagementSystem\DataBase\Hotelierbase.mdf;Integrated Security=True");
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDataSet.users' table. You can move, or remove it, as needed.
            //this.usersTableAdapter.Fill(this.usersDataSet.users);
            RandomNumber();
            DisplayData();

        }

        private void DisplayData()
        {
            string com = "select * from [users]";
            Connection.Open();
            SqlCommand sc = new SqlCommand(com, Connection);
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            UserDataGrid.DataSource = dt;
            Connection.Close();
        }

        public void RandomNumber()
        {
            Random random = new Random();
            int num = random.Next(0000, 1000);
            IdTB.Text = num.ToString();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (IdTB.Text=="" || FnameTB.Text=="" || LnameTB.Text=="" || UsernameTB.Text == "" || EmailTB.Text == "" || AccountTypeCB.SelectedIndex <= 0 || PasswordTB.Text=="" || Password2TB.Text == "")
            {
                MessageBox.Show("You need to fill all the information","NO EMPTY!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (PasswordTB.Text.Length < 6)
            {
                MessageBox.Show("Password must be morethan 6 Characters", "MORE CHARACTERS!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (PasswordTB.Text != Password2TB.Text)
            {
                MessageBox.Show("Password does not match", "NO MATCH!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string com = "insert into [users] (id,firstname,lastname,username,email,accounttype,password,password2)" +
                     "values('" + IdTB.Text + "','" + FnameTB.Text + "','" + LnameTB.Text + "','" + UsernameTB.Text + "','" + EmailTB.Text + "','" + AccountTypeCB.SelectedItem.ToString() + "','" + PasswordTB.Text + "','" + Password2TB.Text + "' ) ";

                    Connection.Open();
                    SqlCommand sc = new SqlCommand(com, Connection);
                    sc.ExecuteNonQuery();
                    Connection.Close();
                    MessageBox.Show("User "+ UsernameTB.Text+"\nsuccessfully registered" , "SUCCESSFULL..!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RandomNumber();
                    FnameTB.Text = "";
                    LnameTB.Text = "";
                    UsernameTB.Text = "";
                    EmailTB.Text = "";
                    AccountTypeCB.SelectedIndex = -1;
                    PasswordTB.Text = "";
                    Password2TB.Text = "";
                    DisplayData();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to delete this user?","DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                try
                {
                    string com = "delete from [users] where id = '" + IdTB.Text + "' ";

                    Connection.Open();
                    SqlCommand sc = new SqlCommand(com, Connection);
                    sc.ExecuteNonQuery();
                    Connection.Close();
                    RandomNumber();
                    FnameTB.Text = "";
                    LnameTB.Text = "";
                    UsernameTB.Text = "";
                    EmailTB.Text = "";
                    AccountTypeCB.SelectedIndex = -1;
                    PasswordTB.Text = "";
                    Password2TB.Text = "";
                    DisplayData();
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

        private void SaveChangesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string com = "update [users] set firstname = '"+FnameTB.Text+ "', lastname ='"+LnameTB.Text+ "', username='"+UsernameTB.Text+ "', email='"+EmailTB.Text+ "', accounttype ='"+AccountTypeCB.SelectedItem.ToString()+ "', password = '"+PasswordTB.Text+ "', password2='"+Password2TB.Text+ "' where id = '"+IdTB.Text+"' ";

                Connection.Open();
                SqlCommand sc = new SqlCommand(com, Connection);
                sc.ExecuteNonQuery();
                Connection.Close();
                MessageBox.Show("User data updated","SUCCESSFULL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RandomNumber();
                FnameTB.Text = "";
                LnameTB.Text = "";
                UsernameTB.Text = "";
                EmailTB.Text = "";
                AccountTypeCB.SelectedIndex = -1;
                PasswordTB.Text = "";
                Password2TB.Text = "";
                DisplayData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void IdTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string com = "select * from [users] where id = '"+IdTB.Text+"' ";
                Connection.Open();
                SqlCommand sc = new SqlCommand(com, Connection);
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                //DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                sda.Fill(ds);
                Connection.Close();

                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    SaveBtn.Enabled = false;
                    SaveBtn.Visible = false;
                }
                else
                {
                    SaveBtn.Enabled = true;
                    SaveBtn.Visible = true;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            RandomNumber();
        }

        private void UserDataGrid_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                IdTB.Text = UserDataGrid.SelectedRows[0].Cells[0].Value.ToString();
                FnameTB.Text = UserDataGrid.SelectedRows[0].Cells[1].Value.ToString();
                LnameTB.Text = UserDataGrid.SelectedRows[0].Cells[2].Value.ToString();
                UsernameTB.Text = UserDataGrid.SelectedRows[0].Cells[3].Value.ToString();
                EmailTB.Text = UserDataGrid.SelectedRows[0].Cells[4].Value.ToString();
                PasswordTB.Text = UserDataGrid.SelectedRows[0].Cells[6].Value.ToString();
                Password2TB.Text = UserDataGrid.SelectedRows[0].Cells[7].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            IdTB.Text = "";
            FnameTB.Text = "";
            LnameTB.Text = "";
            UsernameTB.Text = "";
            EmailTB.Text = "";
            AccountTypeCB.SelectedIndex = -1;
            PasswordTB.Text = "";
            Password2TB.Text = "";
        }

        private void UsernameTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string com = "select * from [users] where username = '" + UsernameTB.Text + "' ";
                Connection.Open();
                SqlCommand sc = new SqlCommand(com, Connection);
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                //DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                sda.Fill(ds);
                Connection.Close();

                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    MessageBox.Show("User Name "+ UsernameTB.Text + " already exist..!","EXIST..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SaveBtn.Enabled = false;
                }
                else
                {
                    SaveBtn.Enabled = true;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmailTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string com = "select * from [users] where email = '" + EmailTB.Text + "' ";
                Connection.Open();
                SqlCommand sc = new SqlCommand(com, Connection);
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                //DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                sda.Fill(ds);
                Connection.Close();

                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    MessageBox.Show("Email " + EmailTB.Text + " already exist..!","EXIST..!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    SaveBtn.Enabled = false;
                }
                else
                {
                    SaveBtn.Enabled = true;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Users_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginPage lp = new LoginPage();
            lp.Show();
        }
    }
}

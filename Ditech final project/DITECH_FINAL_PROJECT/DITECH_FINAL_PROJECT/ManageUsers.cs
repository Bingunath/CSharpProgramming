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
    public partial class ManageUsers : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Trusted_Connection=Yes;Integrated Security=True;");
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'logins1.login' table. You can move, or remove it, as needed.
            //this.loginTableAdapter.Fill(this.logins1.login);
            RegisterBtn.Enabled = false;
            EditBtn.Enabled = false;
            DeleteBtn.Enabled = false;
            ClearBtn.Enabled = false;
            Display_data();
        }
        public void Display_data()
        {
            connection.Open();
            SqlCommand sc = connection.CreateCommand();
            sc.CommandType = CommandType.Text;
            sc.CommandText = "select * from [login]";
            sc.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(sc);
            dta.Fill(dt);
            UsersDataGrid.DataSource = dt;
            connection.Close();
        }

        private void UsersDataGrid_Click(object sender, EventArgs e)
        {
            UserIdTb.Text = UsersDataGrid.SelectedRows[0].Cells[0].Value.ToString();
            UserNameTB.Text = UsersDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            PassWordTB.Text = UsersDataGrid.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult ConfirmationMessage = MessageBox.Show("Do you want to log out from this session?", "WANT LOG OUT?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ConfirmationMessage == DialogResult.Yes)
            {
                this.Hide();
            }
            else
            {
                ConfirmationMessage = DialogResult.No;
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string UserId = UserIdTb.Text;
            string UserName = UserNameTB.Text;
            string PassWord = PassWordTB.Text;
            string confirm = ConfirmTB.Text;

            

            if (UserName == "" || PassWord == "" || confirm == "" || UserId == "")
            {
                MessageBox.Show("You Must Fill all the data", "FILL DATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
           
            else if (PassWord.Length < 6)
            {
                MessageBox.Show("PassWord Must have at least 6 characters", "PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PassWordTB.Focus();
            }
            else if (confirm != PassWord)
            {
                MessageBox.Show("PassWord Does Not Match", "MATCH THE PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ConfirmTB.Text = "";
                ConfirmTB.Focus();
            }
            else
            {
                connection.Open();
                SqlCommand scomm = connection.CreateCommand();
                scomm.CommandType = CommandType.Text;
                scomm.CommandText = "insert into [login](userid,username, password) values('"+UserIdTb.Text+"' ,'" + UserName + "', '" + PassWord + "')";
                scomm.ExecuteNonQuery();
                connection.Close();
                UserIdTb.Text = "";
                UserNameTB.Text = "";
                PassWordTB.Text = "";
                ConfirmTB.Text = "";
                Display_data();
                MessageBox.Show("New user account created, Please click 'OK' to navigate to the login page", "CREATED SUCCESSFULLY",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand scomm = connection.CreateCommand();
            scomm.CommandType = CommandType.Text;
            scomm.CommandText = "delete from [login] where username = '"+UserNameTB.Text+"'  ";
            scomm.ExecuteNonQuery();
            connection.Close();
            UserIdTb.Text = "";
            UserNameTB.Text = "";
            PassWordTB.Text = "";
            Display_data();
            MessageBox.Show("User account has been deleted", "DELETED SUCCESSFULLY",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UserNameTB_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            string UserName = UserNameTB.Text;
            string PassWord = PassWordTB.Text;
            string confirm = ConfirmTB.Text;

            if (PassWord.Length < 6)
            {
                MessageBox.Show("PassWord Must have at least 6 characters", "PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PassWordTB.Focus();
            }
            else if (confirm != PassWord)
            {
                MessageBox.Show("PassWord Does Not Match", "MATCH THE PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ConfirmTB.Text = "";
                ConfirmTB.Focus();
            }
            else
            {
                connection.Open();
                SqlCommand scomm = connection.CreateCommand();
                scomm.CommandType = CommandType.Text;
                scomm.CommandText = "update [login] set username ='" + UserNameTB.Text + "', password = '" + PassWordTB.Text + "' where userid ='" + UserIdTb.Text + "'  ";
                scomm.ExecuteNonQuery();
                connection.Close();
                UserIdTb.Text = "";
                UserNameTB.Text = "";
                PassWordTB.Text = "";
                ConfirmTB.Text = "";
                Display_data();
                MessageBox.Show("User account has been updated", "UPDATED SUCCESSFULLY",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            UserIdTb.Text = "";
            UserNameTB.Text = "";
            PassWordTB.Text = "";
            ConfirmTB.Text = "";
        }

        private void UserIdTb_TextChanged(object sender, EventArgs e)
        {
            string UserID = UserIdTb.Text;



            if (UserID == "")
            {
                Display_data();
                RegisterBtn.Enabled = false;
                EditBtn.Enabled = false;
                DeleteBtn.Enabled = false;
                ClearBtn.Enabled = false;

            }
            else
            {


                connection.Open();
                SqlCommand sc = connection.CreateCommand();
                sc.CommandType = CommandType.Text;
                sc.CommandText = "select * from [login] where userid ='" + UserIdTb.Text + "' ";
                sc.ExecuteNonQuery();
                connection.Close();

                SqlDataAdapter sda = new SqlDataAdapter(sc);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                sda.Fill(ds);
                sda.Fill(dt);
                UsersDataGrid.DataSource = dt;

                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    DeleteBtn.Enabled = true;
                    RegisterBtn.Enabled = false;
                    EditBtn.Enabled = true;
                    ClearBtn.Enabled = true;

                }
                else
                {
                    RegisterBtn.Enabled = true;
                    EditBtn.Enabled = false;
                    DeleteBtn.Enabled = false;
                    ClearBtn.Enabled = true;
                }

            }
        }
    }
}

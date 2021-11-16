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
    public partial class newuser : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DiTech\Ditech final project\DITECH_FINAL_PROJECT\DITECH_FINAL_PROJECT\Database1.mdf;Integrated Security=True");
        public newuser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            string NewUser = newusr.Text;
            string NewPass = newpass.Text;
            string ConfirmedPass = connewpass.Text;
            if (NewUser == "" && NewPass == "" && ConfirmedPass == "")
            {
                MessageBox.Show("Please complete all the data..!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                newusr.Focus();
            }
            else if (ConfirmedPass != NewPass)
            {
                MessageBox.Show("Your password does not match.Please try again..!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connewpass.Clear();
            }
            
            else
            {
                connection.Open();
                SqlCommand scomm = connection.CreateCommand();
                scomm.CommandType = CommandType.Text;
                scomm.CommandText = "insert into [login](username, password) values('" + newusr.Text + "', '" + newpass.Text + "')";
                scomm.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("New user account created, Please click 'OK' to navigate to the login page" , "CREATED SUCCESSFULLY",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                loginpage lp = new loginpage();
                lp.Show();
                this.Hide();
            }
            
        }

        private void canclebtn_Click(object sender, EventArgs e)
        {
            loginpage lp = new loginpage();
            lp.Show();
            this.Hide();
        }

        private void connewpass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void newusr_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand SC = connection.CreateCommand();
            SC.CommandType = CommandType.Text;
            SC.CommandText = "select * from [login] where username = '"+ newusr.Text + "'  ";
            SC.ExecuteNonQuery();
            connection.Close();

            SqlDataAdapter DA = new SqlDataAdapter(SC);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            int Count = DS.Tables[0].Rows.Count;

            if (Count == 1)
            {
                MessageBox.Show("This user Account is already Exist.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
            }
        }
    }
}

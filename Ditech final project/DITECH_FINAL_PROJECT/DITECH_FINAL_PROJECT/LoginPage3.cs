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
    public partial class LoginPage3 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DiTech\Ditech final project\DITECH_FINAL_PROJECT\DITECH_FINAL_PROJECT\Database1.mdf;Integrated Security=True");
        public LoginPage3()
        {
            InitializeComponent();
        }

        private void LoginPage3_Load(object sender, EventArgs e)
        {
            usrnameTB.Enabled = false;
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string username = usrnameTB.Text;
            string password = passwdTB.Text;

            if (username == "" && password == "")
            {
                MessageBox.Show("Please Enter Username and Password", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [login] where username=@Username and password=@Password";
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                connection.Close();
                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {

                    ManageCourses MC = new ManageCourses();
                    MC.Show();
                    //MessageBox.Show("Login Success..!","SUCCESS!", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Hide();

                }
                else
                {
                    MessageBox.Show(" INVALID PASSWORD..! Login not Success..!", "NOT SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
    
}

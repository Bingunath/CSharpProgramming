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

namespace Library_Managment_System
{
    public partial class LoginForm3 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\My programming\C#\Library Managment System\Library Managment System\LibraryBooksDatabase.mdf;Integrated Security=True");
        public LoginForm3()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string User_Name = UserNameTB.Text;
            string Pass_Word = PasswordTB.Text;

            if (User_Name == "")
            {
                MessageBox.Show("Username Can not be empty..!", "ENTER USERNAME", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserNameTB.Focus();
            }
            else if (Pass_Word == "")
            {
                MessageBox.Show("Password Can not be empty..!", "ENTER PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordTB.Focus();
            }
            else
            {
                connection.Open();
                SqlCommand SC = connection.CreateCommand();
                SC.CommandType = CommandType.Text;
                SC.CommandText = "select * from [logins] where username =@UserName and password = @PassWord";
                SC.Parameters.AddWithValue("@UserName", User_Name);
                SC.Parameters.AddWithValue("@PassWord", Pass_Word);

                SqlDataAdapter SDA = new SqlDataAdapter(SC);
                DataSet DS = new DataSet();
                SDA.Fill(DS);
                connection.Close();

                int count = DS.Tables[0].Rows.Count;
                if (count == 1)
                {

                    this.Hide();
                    MessageBox.Show("WELCOME  " + User_Name, "SUCCESSFULL...!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    members MP = new members(UserNameTB.Text);
                    MP.Show();

                }
                else
                {
                    MessageBox.Show("USER NAME OR PASSWORD INCORRECT", "UNSUCCESSFULL...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UserNameTB.Clear();
                    PasswordTB.Clear();
                    UserNameTB.Focus();
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibraryHomeMenu LHM = new LibraryHomeMenu();
            LHM.Show();
            
        }
    }
}

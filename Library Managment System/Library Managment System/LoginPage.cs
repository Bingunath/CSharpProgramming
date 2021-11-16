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
using System.Drawing.Design;

namespace Library_Managment_System
{
    public partial class LoginPage : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\My programming\C#\Library Managment System\Library Managment System\LibraryBooksDatabase.mdf;Integrated Security=True");


        
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LogoinPage_Load(object sender, EventArgs e)
        {
            
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            String UsrName = UserNameTB.Text;
            string PassWrd = PasswordTB.Text;

            if (UsrName == "")
            {
                MessageBox.Show("Username Can not be empty..!", "ENTER USERNAME", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserNameTB.Focus();
            }
            else if(PassWrd == "")
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
                SC.Parameters.AddWithValue("@UserName",UsrName);
                SC.Parameters.AddWithValue("@PassWord",PassWrd);

                SqlDataAdapter SDA = new SqlDataAdapter(SC);
                DataSet DS = new DataSet();
                SDA.Fill(DS);
                connection.Close();

                int count = DS.Tables[0].Rows.Count;
                if (count == 1)
                {
                    
                    this.Hide();
                    MessageBox.Show("WELCOME  " + UsrName, "SUCCESSFULL...!", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
                    BookRegistration BR = new BookRegistration(UserNameTB.Text);
                    BR.Show();
                   
                }
                else
                {
                    MessageBox.Show("USER NAME OR PASSWORD INCORRECT", "UNSUCCESSFULL...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
        }
        void LoginBTN_Click (object sender , EventArgs e)
        {
            NewUser NU = new NewUser();
            NU.Show();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            LibraryHomeMenu LHM = new LibraryHomeMenu();
            LHM.Show();
            this.Hide();
        }
    }
}

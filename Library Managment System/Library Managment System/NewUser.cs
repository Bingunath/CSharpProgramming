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

    public partial class NewUser : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\My programming\C#\Library Managment System\Library Managment System\LibraryBooksDatabase.mdf;Integrated Security=True");
        public NewUser()
        {
            InitializeComponent();
        }

        private void NewUser_Load(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibraryHomeMenu LHM = new LibraryHomeMenu();
            LHM.Show();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string UserID = UserIdTB.Text;
            string NuserName = NewUserNameTB.Text;
            string Npass = NewPassWordTB.Text;
            string Cpass = ConfirmPassWordTB.Text;

            if (UserID == "" || NuserName == "" || Npass == "" || Cpass == "")
            {
                MessageBox.Show("PLEASE FILL THE REQUIRED INFORMATION", "NO EMPTY...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NewUserNameTB.Focus();
            }
            else if (Cpass != Npass)
            {
                MessageBox.Show("Password Does not match with each other", "DOES NOT MATCH...!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConfirmPassWordTB.Text = "";
                ConfirmPassWordTB.Focus();
            }
            else
            {
                connection.Open();
                SqlCommand sc = connection.CreateCommand();
                sc.CommandType = CommandType.Text;
                sc.CommandText = "insert into [logins] (UserID,username, password) values('"+UserIdTB.Text+"' ,'"+NuserName+"', '"+Cpass+"')";
                sc.ExecuteNonQuery();
                connection.Close();
                UserIdTB.Clear();
                NewUserNameTB.Clear();
                NewPassWordTB.Clear();
                ConfirmPassWordTB.Clear();
                ErrorLabel.Text = "";
                MessageBox.Show( "User " + "' " + NuserName + " '" + " Successfully Registered...!", "SUCCESSFULL...!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

        }

        private void SeeUsersBtn_Click(object sender, EventArgs e)
        {
            UsersForm UF = new UsersForm();
            UF.Show();
            
        }

        private void ConfirmPassWordTB_TextChanged(object sender, EventArgs e)
        {
            string Npass = NewPassWordTB.Text;
            string Cpass = ConfirmPassWordTB.Text;
            if (Npass == Cpass)
            {
                ErrorLabel.Text = "PASSWORD DOES MATCH";
                ErrorLabel.ForeColor = System.Drawing.Color.Green;
                ErrorLabel.Visible = true;

            }
            else if (Cpass == "")
            {
                ErrorLabel.Visible= false;
            }
            else
            {
                ErrorLabel.Text = "PASSWORD DOES NOT MATCH";
                ErrorLabel.ForeColor = System.Drawing.Color.Red;
                ErrorLabel.Visible = true;
            }
        }

        private void UserIdTB_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand sc = connection.CreateCommand();
            sc.CommandType = CommandType.Text;
            sc.CommandText = "select * from [logins] where UserID = '"+UserIdTB.Text+"' ";
            connection.Close();

            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            int LOG = ds.Tables[0].Rows.Count;
            if (LOG == 1)
            {
                RegisterBtn.Enabled = false;
                MessageBox.Show("This User is already existing in DataBase.Please Register New Member " +
                    "Id or Delete the Existing data.", "EXISTING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                RegisterBtn.Enabled = true;
            }
        }
    }
}

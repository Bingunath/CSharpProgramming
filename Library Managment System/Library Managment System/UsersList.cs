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
    public partial class UsersForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\My programming\C#\Library Managment System\Library Managment System\LibraryBooksDatabase.mdf;Integrated Security=True");
        public UsersForm()
        {
            InitializeComponent();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            Show_Users();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand SC = connection.CreateCommand();
            SC.CommandType = CommandType.Text;
            SC.CommandText = "delete from [logins] where UserID = '"+deleteTB.Text+"' ";
            SC.ExecuteNonQuery();
            connection.Close();
            Show_Users();


        }

        private void deleteTB_TextChanged(object sender, EventArgs e)
        {
            if(deleteTB.Text == "")
            {
                Show_Users();
            }
            else
            {
                connection.Open();
                SqlCommand NSC = connection.CreateCommand();
                NSC.CommandType = CommandType.Text;
                NSC.CommandText = "select * from [logins] where UserID = '" + deleteTB.Text + "'  ";

                SqlDataAdapter SDA2 = new SqlDataAdapter(NSC);
                DataTable DT1 = new DataTable();
                SDA2.Fill(DT1);
                UsersDataGride.DataSource = DT1;
                connection.Close();
            }
            
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            //NewUser NU = new NewUser();
            //NU.Show();
            this.Hide();
        }

        public void Show_Users()
        {
            connection.Open();
            SqlCommand NSC = connection.CreateCommand();
            NSC.CommandType = CommandType.Text;
            NSC.CommandText = "select * from [logins]";
            connection.Close();          

            SqlDataAdapter SDA = new SqlDataAdapter(NSC);
            DataTable DT = new DataTable();
            SDA.Fill(DT);
            UsersDataGride.DataSource = DT;
            

        }

        private void UsersDataGride_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void UsersDataGride_MouseClick(object sender, MouseEventArgs e)
        {
            deleteTB.Text = UsersDataGride.SelectedRows[0].Cells[0].Value.ToString();
        }
    }
}

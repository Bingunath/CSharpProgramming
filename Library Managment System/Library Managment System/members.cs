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
    public partial class members : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\My programming\C#\Library Managment System\Library Managment System\LibraryBooksDatabase.mdf;Integrated Security=True");
        public members(string value)
        {
            InitializeComponent();
            label11.Text = "USER : " + value;
            RegisterBtn.Enabled = false;
            ClearBtn.Enabled = false;
            DeleteBtn.Enabled = false;
        }

        private void members_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryBooksDatabaseDataSet3.members' table. You can move, or remove it, as needed.
            //this.membersTableAdapter.Fill(this.libraryBooksDatabaseDataSet3.members);
            DisplayData();

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string Member_id = MemberIdTB.Text;
            string Member_name = NameTB.Text;
            string dob = DOBDtp.Text;
            string age = AgeTB.Text;
            string Contact = ContactTB.Text;
            int IdType = IdTypeCB.SelectedIndex;
            string Idnumber = IdNumberTB.Text;
            string address = AddressTB.Text;

            if (Member_id == "")
            {
                MessageBox.Show("You should Enter Member ID", "ENTER MEMBER ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MemberIdTB.Focus();
            }
            else if (Member_name == "")
            {
                MessageBox.Show("You should Enter Member NAME", "ENTER MEMBER NAME", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NameTB.Focus();
            }
            else if (age == "")
            {
                MessageBox.Show("You should Enter Member Date of Birth", "ENTER BIRTHDAY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DOBDtp.Focus();
            }
            else if (Contact == "")
            {
                MessageBox.Show("You should Enter Member Contact Number", "ENTER CONTACT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ContactTB.Focus();
            }
            else if (IdType == -1)
            {
                MessageBox.Show("You should Enter ID Type...", "ENTER ID TYPE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IdTypeCB.Focus();
            }
            else if (Idnumber == "")
            {
                MessageBox.Show("You should Enter ID Number", "ENTER Id Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IdNumberTB.Focus();
            }
            else if (address == "")
            {
                MessageBox.Show("You should Enter Member's Address", "ENTER ADDRESS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AddressTB.Focus();
            }
            else
            {
                connection.Open();
                SqlCommand sc = connection.CreateCommand();
                sc.CommandType = CommandType.Text;
                sc.CommandText = "insert into [members] (MemberId, MemberName, DateOfBirth, Age, ContactNumber, IdType, IdNumber, Address)" +
                    "values('" + MemberIdTB.Text + "', '" + NameTB.Text + "', '" + DOBDtp.Value.ToString() + "', '" + AgeTB.Text + "', '" + ContactTB.Text + "', '" + IdTypeCB.SelectedItem.ToString() + "', '" + IdNumberTB.Text + "', '" + AddressTB.Text + "'  )";
                sc.ExecuteNonQuery();
                connection.Close();
                DisplayData();
                ClearBtn_Click(sender, e);
                MessageBox.Show("Member has been added to the database Successfully", "SUCCESSFULLY REGISTERED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            

        }

        void DisplayData()
        {
            connection.Open();
            SqlCommand SC = connection.CreateCommand();
            SC.CommandType = CommandType.Text;
            SC.CommandText = "select * from [members]";
            SC.ExecuteNonQuery();           
            SqlDataAdapter sda = new SqlDataAdapter(SC);
            DataTable DT = new DataTable();
            sda.Fill(DT);
            MemberDataGrid.DataSource = DT;
            connection.Close();

        }

        private void DOBDtp_ValueChanged(object sender, EventArgs e)
        {
            DateTime DOB = DOBDtp.Value;
            DateTime Today = DateTime.Now;         

            TimeSpan Days = (Today - DOB);
            int Age = (int)Days.TotalDays;
            
            if (Age / 365 < 0)
            {
                MessageBox.Show("Invalid Input", "INVALID BIRTHDATE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DOBDtp.ResetText();
                DOBDtp.Focus();
                AgeTB.Text = "";
            }
            else
            {
                AgeTB.Text = (Age / 365).ToString() + "  YEARS OLD";
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            MemberIdTB.Text = "";
            NameTB.Text = "";
            DOBDtp.ResetText();
            AgeTB.Text = "";
            ContactTB.Text = "";
            IdTypeCB.SelectedIndex = -1;
            IdNumberTB.Text = "";
            AddressTB.Text = "";
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want close this page and go to home page?", "DO YOU WANT to EXIT?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                LibraryHomeMenu LHM = new LibraryHomeMenu();
                LHM.Show();
            }
            else
            {
                dialog = DialogResult.No;
            }
        }

        private void DeleteTB_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand sc = connection.CreateCommand();
            sc.CommandType = CommandType.Text;
            sc.CommandText = "select * from [members] where MemberId = '"+DeleteTB.Text+"' ";
            connection.Close();

            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            int count = ds.Tables[0].Rows.Count;
            if (count == 1)
            {
                MessageBox.Show("This Member is already existing in DataBase.Please Register New Member " +
                    "Id or Delete the Existing data.", "EXISTING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RegisterBtn.Enabled = false;
                ClearBtn.Enabled = false;
                DeleteBtn.Enabled = true;
            }
            else
            {
                
                RegisterBtn.Enabled = false;
                ClearBtn.Enabled = false;
                DeleteBtn.Enabled = false;
            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand sc2 = connection.CreateCommand();
            sc2.CommandType = CommandType.Text;
            sc2.CommandText = "delete from [members] where MemberId = '" + DeleteTB.Text + "' ";
            sc2.ExecuteNonQuery();
            connection.Close();

            DataTable DT2 = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(sc2);
            SDA.Fill(DT2);
            MemberDataGrid.DataSource = DT2;
            DisplayData();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            string Search = SearchBox.Text;

            if (Search == "")
            {
                DisplayData();
            }
            else
            {
                connection.Open();
                SqlCommand sc = connection.CreateCommand();
                sc.CommandType = CommandType.Text;
                sc.CommandText = "select * from [members] where MemberId = '" + SearchBox.Text + "' ";
                sc.ExecuteNonQuery();

                SqlDataAdapter sda = new SqlDataAdapter(sc);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MemberDataGrid.DataSource = dt;
                connection.Close();
            }
            
           
        }

        private void MemberIdTB_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand sc = connection.CreateCommand();
            sc.CommandType = CommandType.Text;
            sc.CommandText = "select * from [members] where MemberId = '" + MemberIdTB.Text + "' ";
            connection.Close();

            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            int count = ds.Tables[0].Rows.Count;
            if (count == 1)
            {
                RegisterBtn.Enabled = false;
                ClearBtn.Enabled = false;
                MessageBox.Show("This Member is already existing in DataBase.Please Register New Member " +
                    "Id or Delete the Existing data.", "EXISTING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else if (MemberIdTB.Text != "")
            {
                RegisterBtn.Enabled = true;
                ClearBtn.Enabled = true;
            }            
            else
            {
                RegisterBtn.Enabled = false;
                ClearBtn.Enabled = false;
            }
        }

        private void NameTB_TextChanged(object sender, EventArgs e)
        {
            if (NameTB.Text != "")
            {
                RegisterBtn.Enabled = true;
                ClearBtn.Enabled = true;
            }
            else
            {
                RegisterBtn.Enabled = false;
                ClearBtn.Enabled = false;
            }
        }

        private void AgeTB_TextChanged(object sender, EventArgs e)
        {
            if (AgeTB.Text != "")
            {
                RegisterBtn.Enabled = true;
                ClearBtn.Enabled = true;
            }
            else
            {
                RegisterBtn.Enabled = false;
                ClearBtn.Enabled = false;
            }
        }

        private void ContactTB_TextChanged(object sender, EventArgs e)
        {
            if (ContactTB.Text != "")
            {
                RegisterBtn.Enabled = true;
                ClearBtn.Enabled = true;
            }
            else
            {
                RegisterBtn.Enabled = false;
                ClearBtn.Enabled = false;
            }
        }

        private void IdTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IdTypeCB.SelectedIndex != -1)
            {
                RegisterBtn.Enabled = true;
                ClearBtn.Enabled = true;
            }
            else
            {
                RegisterBtn.Enabled = false;
                ClearBtn.Enabled = false;
            }
        }

        private void IdNumberTB_TextChanged(object sender, EventArgs e)
        {
            if (IdNumberTB.Text != "")
            {
                
                ClearBtn.Enabled = true;
            }
            else
            {
                
                ClearBtn.Enabled = false;
            }
        }

        private void AddressTB_TextChanged(object sender, EventArgs e)
        {
            if (AddressTB.Text != "")
            {

                ClearBtn.Enabled = true;
            }
            else
            {

                ClearBtn.Enabled = false;
            }
        }

        private void MemberDataGrid_Click(object sender, EventArgs e)
        {
            
        }

        private void MemberDataGrid_DoubleClick(object sender, EventArgs e)
        {
            DeleteTB.Text = MemberDataGrid.SelectedRows[0].Cells[0].Value.ToString();
        }
    }
}

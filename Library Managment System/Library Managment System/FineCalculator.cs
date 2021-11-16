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
    public partial class FineCalculator : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\My programming\C#\Library Managment System\Library Managment System\LibraryBooksDatabase.mdf;Integrated Security=True");
        public FineCalculator()
        {
            InitializeComponent();
            comboBoxLoad();
            MemberList();
            Books();


        }
        void comboBoxLoad()
        {

            UserIDList.Items.Clear();
            connection.Open();
            SqlCommand Scomm = connection.CreateCommand();
            Scomm.CommandType = CommandType.Text;
            Scomm.CommandText = "select * from [logins]";

            Scomm.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(Scomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                UserIDList.Items.Add(dr["UserID"].ToString());
            }
            connection.Close();
        }
        void MemberList()
        {
            MemberListCB.Items.Clear();
            connection.Open();
            SqlCommand Scomm = connection.CreateCommand();
            Scomm.CommandType = CommandType.Text;
            Scomm.CommandText = "select * from [members]";

            Scomm.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(Scomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                MemberListCB.Items.Add(dr["MemberId"].ToString());
            }
            connection.Close();
        }
        void Books()
        {
            BookListCB.Items.Clear();
            connection.Open();
            SqlCommand Scomm = connection.CreateCommand();
            Scomm.CommandType = CommandType.Text;
            Scomm.CommandText = "select * from [Table]";

            Scomm.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(Scomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                BookListCB.Items.Add(dr["Book_Id"].ToString());
            }
            connection.Close();
        }
        private void FineCalculator_Load(object sender, EventArgs e)
        {
            DisplayData();
            DelayDaysTB.Enabled = false;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime ReturnDay = dateTimePicker2.Value.Date;
            DateTime ReturnedDay = dateTimePicker1.Value.Date;
            TimeSpan Delayed = ReturnedDay - ReturnDay;
            int DelayDays = (int)Delayed.TotalDays;
            DelayDaysTB.Text = DelayDays.ToString();

            ReturnDateTB.Text = ReturnDay.ToString();
            ReturnedDateTB.Text = ReturnedDay.ToString();
            DelayedDaysTB2.Text = DelayDays.ToString();



        }

        private void DelayDaysTB_TextChanged(object sender, EventArgs e)
        {
            string DelayDays = DelayDaysTB.Text;
            int PreFine = Int32.Parse(DelayDays);
            DelayedDaysTB2.Text = DelayDaysTB.Text;


            if (DelayDaysTB.Text.Length == 0)
            {
                DelayDaysTB.Text = "0";
                MessageBox.Show("This Can not be empty", "CAN NOT BE EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (PreFine * 1.5 < 0)
            {
                DisplayTB.Text = "      INVALID DATE...!";
                DisplayTB.ForeColor = System.Drawing.Color.Red;
                DisplayTB.Font = new Font("Microsoft Sans Sherif", 16);
            }
            else
            {
                DisplayTB.Text = (PreFine * 1.43).ToString();
                Fine2TB.Text = (PreFine * 1.43).ToString();
                DisplayTB.ForeColor = System.Drawing.Color.Blue;
                DisplayTB.Font = new Font("Microsoft Sans Sherif", 36);
            }

        }

        private void DisplayTB_TextChanged(object sender, EventArgs e)
        {

            Fine2TB.Text = DisplayTB.Text;
        }


        private void CashTB_TextChanged(object sender, EventArgs e)
        {
            
            string Fines = Fine2TB.Text;
            //int Ifines = Int32.Parse(Fines);
            decimal FFines = Convert.ToDecimal(Fines);

            string Cash = CashTB.Text;
            //int ICash = Int32.Parse(Cash);
            decimal FCash = Convert.ToDecimal(Cash);
            decimal Balance = FCash - FFines;
            BalanceTB.Text = Balance.ToString();

            
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string Memberid = MemberTB.Text;
            string MemberName = MemberNameTB.Text;
            string Bookid = BookIDTB.Text;
            string BookName = BookNameTB.Text;

            if (Memberid == "" || MemberName == "" || Bookid == "")
            {
                MessageBox.Show("You should Enter Member ID", "ENTER Member ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MemberTB.Focus();
            }
            else
            {
                connection.Open();
                SqlCommand sc = connection.CreateCommand();
                sc.CommandType = CommandType.Text;
                sc.CommandText = "insert into [fines] (MemberID,MemberName,BookID,BookName,ReturnDate,ReturnedDate,DelayedDays,Fines,Cash,Balance,Collected_UserID)" +
                    "values('" + MemberTB.Text + "', '" + MemberNameTB.Text + "', '" + BookIDTB.Text + "', '" + BookNameTB.Text + "', '" + ReturnDateTB.Text + "','" + ReturnedDateTB.Text + "','" + DelayedDaysTB2.Text + "', '" + Fine2TB.Text.ToString() + "', '" + CashTB.Text.ToString() + "', '" + BalanceTB.Text.ToString() + "', '" + CollectorID.Text + "') ";
                sc.ExecuteNonQuery();
                connection.Close();
                DisplayData();
            }

        }
        void DisplayData()
        {
            connection.Open();
            SqlCommand SC = connection.CreateCommand();
            SC.CommandType = CommandType.Text;
            SC.CommandText = "select * from [fines]";
            SC.ExecuteNonQuery();


            SqlDataAdapter sda = new SqlDataAdapter(SC);
            DataTable DT = new DataTable();
            sda.Fill(DT);
            FineGridView.DataSource = DT;
            connection.Close();
        }

        private void FineGridView_Click(object sender, EventArgs e)
        {
            DeleteBoxTB.Text = FineGridView.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand SC = connection.CreateCommand();
            SC.CommandType = CommandType.Text;
            SC.CommandText = "delete from [fines] where MemberID = '" + DeleteBoxTB.Text + "' ";
            SC.ExecuteNonQuery();
            connection.Close();
            DisplayData();
        }

        private void MemberTB_TextChanged(object sender, EventArgs e)
        {
            string Mid = MemberTB.Text;
            connection.Open();
            SqlCommand Scomm = connection.CreateCommand();
            Scomm.CommandType = CommandType.Text;
            Scomm.CommandText = "select * from [members] where MemberId = '" + MemberTB.Text + "' ";

            SqlDataReader dr = Scomm.ExecuteReader();

            if (dr.Read())
            {
                MemberNameTB.Text = (dr["MemberName"].ToString());
            }
            else
            {
                MemberNameTB.Text = "";
            }
             connection.Close();
            
        }

        private void MemberNameTB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BookIDTB_TextChanged(object sender, EventArgs e)
        {
            string Bookid = BookIDTB.Text;
            connection.Open();
            SqlCommand Scomm = connection.CreateCommand();
            Scomm.CommandType = CommandType.Text;
            Scomm.CommandText = "select * from [Table] where Book_Id = '" + BookIDTB.Text + "' ";

            SqlDataReader dr = Scomm.ExecuteReader();

            if (dr.Read())
            {
                BookNameTB.Text = (dr["Book_Name"].ToString());
            }
            else
            {
                BookNameTB.Text = "";
            }
                connection.Close();
            
        }

        private void ClearAllBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void UserIDList_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand sc = connection.CreateCommand();
            sc.CommandType = CommandType.Text;
            sc.CommandText = "select * from [logins] where UserID = '"+UserIDList.SelectedItem.ToString()+"'  ";

            SqlDataReader SDR = sc.ExecuteReader();

            if (SDR.Read())
            {
                CollectorID.Text = (SDR["username"].ToString());
            }
            else
            {
                CollectorID.Text = "NO USER FOUND!";
            }
            connection.Close();
            
        }

        private void MemberListCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            MemberTB.Text = MemberListCB.SelectedItem.ToString();
        }

        private void BookListCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            BookIDTB.Text = BookListCB.SelectedItem.ToString();
        }
    }
}
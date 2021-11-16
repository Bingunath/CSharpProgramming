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
    public partial class Library : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\My programming\C#\Library Managment System\Library Managment System\LibraryBooksDatabase.mdf;Integrated Security=True");
        public Library()
        {
            InitializeComponent();
            IssueBtn.Enabled = false;
            ClearBtn.Enabled = false;
            DeleteBtn.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Display_Data();
            Display_Data1();
            DisplayData2();
            NoRecordLabel1.Text = "";


        }

        
        public void Display_Data()
        {
            connection.Open();
            SqlCommand DSC = connection.CreateCommand();
            DSC.CommandType = CommandType.Text;
            DSC.CommandText = "select * from [Table]";
            DSC.ExecuteNonQuery();
            DataTable Dt = new DataTable();
            SqlDataAdapter Sda = new SqlDataAdapter(DSC);
            Sda.Fill(Dt);
            BookList1.DataSource = Dt;
            connection.Close();

        }
        public void Display_Data1()
        {
            connection.Open();
            SqlCommand Dsc = connection.CreateCommand();
            Dsc.CommandType = CommandType.Text;
            Dsc.CommandText = "select * from [books]";
            Dsc.ExecuteNonQuery();
            DataTable DT = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(Dsc);
            SDA.Fill(DT);
            booksDataGridView.DataSource = DT;
            connection.Close();

        }
        void DisplayData2()
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (BookIdTB1.Text != "")
            {
                IssueBtn.Enabled = true;
                ClearBtn.Enabled = true;
            }
            else
            {
                IssueBtn.Enabled = false;
                ClearBtn.Enabled = false;
            }
        }

        private void IssueBtn_Click(object sender, EventArgs e)
        {
            string Bookid = BookIdTB1.Text;
            int BookStatus = BookStatusCB.SelectedIndex;
            string Memberid = MemberIdTB.Text;

            if (Bookid == "")
            {
                MessageBox.Show("You should Enter Book ID", "ENTER BOOK ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BookIdTB1.Focus();
            }
            else if (BookStatus == -1)
            {
                MessageBox.Show("You should select the status of the book", "SELECT BOOK STATUS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BookStatusCB.Focus();
            }
            else if (Memberid == "")
            {
                MessageBox.Show("You should enter Member's ID", "ENTER MEMBER'S ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MemberIdTB.Focus();
            }
            else
            {
                connection.Open();
                SqlCommand SC = connection.CreateCommand();
                SC.CommandType = CommandType.Text;
                SC.CommandText = "insert into [books] (BookId, MemberId, MemberName, Contact, BookSTATUS, Issue_Date, Returning_Date, Address) " +
                    "values('" + BookIdTB1.Text + "', '" + MemberIdTB.Text + "','" + MemberNameTB.Text + "', '" + MemberCnTB.Text + "', '" + BookStatusCB.SelectedItem.ToString() + "', '" + BookIssueDTP.Value.ToString() + "', '" + ReturningDTP.Value.ToString() + "' , '" + AddressTB.Text + "')";
                SC.ExecuteNonQuery();
                connection.Close();
                Display_Data1();
                BookIdTB1.Text = "";
                BookStatusCB.SelectedIndex = -1;
                MemberIdTB.Text = "";
                MemberNameTB.Text = "";
                MemberCnTB.Text = "";
                AddressTB.Text = "";
                BookIssueDTP.ResetText();
                ReturningDTP.ResetText();

                MessageBox.Show("BOOK REGISTERED SUCCESFULLY..!", "SUCCESSFULL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

            
        

        private void SearchBoxTB_TextChanged(object sender, EventArgs e)
        {
            string Bookid = SearchBoxTB.Text;

            if (Bookid == "")
            {
                Display_Data();
                Display_Data1();
            }
            else
            {
                connection.Open();
                SqlCommand DSC = connection.CreateCommand();
                DSC.CommandType = CommandType.Text;
                DSC.CommandText = "select * from [Table] where Book_Id = '" + SearchBoxTB.Text + "'  ";
                DSC.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(DSC);
                DataTable ds = new DataTable();
                sda.Fill(ds);
                BookList1.DataSource = ds;

                //This block of code for display data when user search the book by ID and showing BORROWED BOOK LIST
                SqlCommand sc = connection.CreateCommand();
                sc.CommandType = CommandType.Text;
                sc.CommandText = "select * from [books] where BookId ='" + SearchBoxTB.Text + "' or MemberId = '" + SearchBoxTB.Text + "'  ";
                
                sc.ExecuteNonQuery();
                SqlDataAdapter SDA = new SqlDataAdapter(sc);
                DataTable DT = new DataTable();
                SDA.Fill(DT);
                booksDataGridView.DataSource = DT;
                connection.Close();

            }        
                    

                






          }

            private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Clear all the data?", "WANT TO CLEAR?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                BookIdTB1.Text = "";
                BookStatusCB.SelectedIndex = -1;
                MemberIdTB.Text = "";
                MemberNameTB.Text = "";
                MemberCnTB.Text = "";
                AddressTB.Text = "";
                BookIssueDTP.ResetText();
                ReturningDTP.ResetText();

            }
            else
            {
                dialog = DialogResult.No;
            }

        }

        private void BookIssueDTP_ValueChanged(object sender, EventArgs e)
        {
            DateTime IssueDate = BookIssueDTP.Value;
            DateTime ReturnDate = IssueDate.AddDays(14);
            ReturningDTP.Value = ReturnDate;

                 
            
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            //this button function can delete data from the database entered bood id in BookId column.
            connection.Open();
            SqlCommand ScDel = connection.CreateCommand();
            ScDel.CommandType = CommandType.Text;
            ScDel.CommandText = "delete from [books] where BookId = '"+DeleteBox1.Text+"' or MemberId = '"+DeleteBox1.Text+"' ";
            ScDel.ExecuteNonQuery();
            connection.Close();
            Display_Data1();
            DeleteBox1.Clear();

        }

        private void BookStatusCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            
        }

        private void ReturningDTP_ValueChanged(object sender, EventArgs e)
        {
            /*DateTime ReturningDate = ReturningDTP.Value;
            DateTime issuedDate = ReturningDate.AddDays(-14);
            BookIssueDTP.Value = issuedDate;*/
        }

        private void MemberIdTB_TextChanged(object sender, EventArgs e)
        {
            string Mid = MemberIdTB.Text;
            connection.Open();
            SqlCommand Scomm = connection.CreateCommand();
            Scomm.CommandType = CommandType.Text;
            Scomm.CommandText = "select * from [members] where MemberId = '"+MemberIdTB.Text+"' ";           
                      
            SqlDataReader dr = Scomm.ExecuteReader();
            
            if (dr.Read())
            {
                MemberNameTB.Text = (dr["MemberName"].ToString());
                MemberCnTB.Text = (dr["ContactNumber"].ToString());
                AddressTB.Text = (dr["Address"].ToString());
            }
            else
            {
                MemberNameTB.Text = "";
                MemberCnTB.Text = "";
                AddressTB.Text = "";
            }
            connection.Close();



        }

        

        private void MemberSearchBox_TextChanged_1(object sender, EventArgs e)
        {
            NoRecordLabel1.Text = "";
            if (MemberSearchBox.Text != "")
            {
                connection.Open();
                SqlCommand sc = connection.CreateCommand();
                sc.CommandType = CommandType.Text;
                sc.CommandText = "select * from [members] where MemberId = '" + MemberSearchBox.Text + "' ";
                sc.ExecuteNonQuery();
                connection.Close();
                SqlDataAdapter sda1 = new SqlDataAdapter(sc);
                DataTable dt = new DataTable();
                DataSet DS = new DataSet();
                
                sda1.Fill(dt);
                sda1.Fill(DS);

                MemberDataGrid.DataSource = dt;
                

                int member = DS.Tables[0].Rows.Count;
                if (member != 1)
                {
                    NoRecordLabel1.Text = "NO RECORD FOUND";
                }
                else
                {
                    //NoRecordLabel1.Text = "";
                }
                
                
            }
            else
            {
                DisplayData2();
            }
            
        }

        private void DeleteBox1_TextChanged(object sender, EventArgs e)
        {
            NoRecordLabel.Text = "";
            if (DeleteBox1.Text == "")
            {
                IssueBtn.Enabled = false;
                ClearBtn.Enabled = false;
                Display_Data1();
            }
            else
            {
                connection.Open();
                SqlCommand sc = connection.CreateCommand();
                sc.CommandType = CommandType.Text;
                sc.CommandText = "select * from [books] where BookId = '" + DeleteBox1.Text + "' or MemberId = '" + DeleteBox1.Text + "' ";
                connection.Close();

                SqlDataAdapter sda3 = new SqlDataAdapter(sc);
                DataSet ds3 = new DataSet();
                DataTable dt3 = new DataTable();
                sda3.Fill(ds3);
                sda3.Fill(dt3);
                booksDataGridView.DataSource = dt3;


                int count = ds3.Tables[0].Rows.Count;
                if (count >= 1)
                {

                    DeleteBtn.Enabled = true;
                    IssueBtn.Enabled = false;
                    ClearBtn.Enabled = false;
                }
                else
                {
                    DeleteBtn.Enabled = false;
                    IssueBtn.Enabled = true;
                    ClearBtn.Enabled = true;
                    NoRecordLabel.Text = "No Record Found";


                }
            }
            
        }

        private void deleteAllBtn_Click(object sender, EventArgs e)
        {
            /*connection.Open();
            SqlCommand DSC = connection.CreateCommand();
            DSC.CommandType = CommandType.Text;
            DSC.CommandText = "delete * from [books]";
            DSC.ExecuteNonQuery();
            connection.Close();
            Display_Data1();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FineCalculator FC = new FineCalculator();
            FC.Show();
        }

        private void BtnExit_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LibraryHomeMenu LHM = new LibraryHomeMenu();
            LHM.Show();
        }

        private void booksDataGridView_DoubleClick(object sender, EventArgs e)
        {
            DeleteBox1.Text = booksDataGridView.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void MemberDataGrid_Click(object sender, EventArgs e)
        {
            MemberIdTB.Text = MemberDataGrid.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void BookList1_Click(object sender, EventArgs e)
        {
            BookIdTB1.Text = BookList1.SelectedRows[0].Cells[0].Value.ToString();
        }
    }
}

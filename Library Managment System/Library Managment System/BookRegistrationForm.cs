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
    public partial class BookRegistration : Form
    {
        
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\My programming\C#\Library Managment System\Library Managment System\LibraryBooksDatabase.mdf;Integrated Security=True");
        public BookRegistration(string value)
        {
            InitializeComponent();
            UserLabel.Text = "USER : " + value;
            
            
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryBooksDatabaseDataSet);

        }

        private void BookRegistration_Load(object sender, EventArgs e)
        {
            Display_Data();
            RegisterBtn.Enabled = false;
            ClearBtn.Enabled = false;
            DeleteBtn.Enabled = false;

            


        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            String bookId = BookIdTb.Text;
            String bookName = BookNameTb.Text;
            String BookAuthour = BookauthourTb.Text;
            DateTime Publishdate = PublishDateDtp.Value;
            int BookCategory = BookcategoryCb.SelectedIndex;
            int BookQuantity = QuantityCb.SelectedIndex;

            if(bookId == "")
            {
                MessageBox.Show("'BOOK ID ' Can Not be Empty", "COMPLETE BOOK ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BookIdTb.Focus();
            }
            else if (bookName == "")
            {
                MessageBox.Show("'BOOK NAME ' Can Not be Empty", "COMPLETE BOOK NAME", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BookNameTb.Focus();
            }
            else if (BookAuthour == "")
            {
                MessageBox.Show("'BOOK AUTHOUR' Can Not be Empty", "COMPLETE BOOK AUTHOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BookauthourTb.Focus();
            }
            else if (Publishdate == null)
            {
                MessageBox.Show("'BOOK AUTHOUR' Can Not be Empty", "COMPLETE BOOK AUTHOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PublishDateDtp.Focus();
            }
            else if (BookCategory == -1)
            {
                MessageBox.Show("'BOOK CATEGORY' Can Not be Empty", "COMPLETE BOOK CATEGORY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BookcategoryCb.Focus();
            }
            else if (BookQuantity == -1)
            {
                MessageBox.Show("'QUANTITY' Can Not be Empty", "COMPLETE QUANTITY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                QuantityCb.Focus();
            }
            else
            {
                connection.Open();
                SqlCommand SC = connection.CreateCommand();
                SC.CommandType = CommandType.Text;
                SC.CommandText = "insert into [Table] (Book_Id, Book_Name, Book_Authour, Published_Date, Category, Quantity) " +
                    "values('" + BookIdTb.Text + "', '" + BookNameTb.Text + "', '" + BookauthourTb.Text + "', '" + PublishDateDtp.Value.ToString() + "', '" + BookcategoryCb.SelectedItem.ToString() + "', '" + QuantityCb.SelectedItem.ToString() + "')";
                SC.ExecuteNonQuery();
                connection.Close();
                BookIdTb.Text = "";
                BookNameTb.Text = "";
                BookauthourTb.Text = "";
                PublishDateDtp.Checked = false;
                BookcategoryCb.SelectedIndex = -1;
                QuantityCb.SelectedIndex = -1;
                Display_Data();
                MessageBox.Show("BOOK REGISTERED SUCCESFULLY..!", "SUCCESSFULL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            
            
        
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
            tableDataGridView.DataSource = Dt;
            connection.Close();

        }

        private void tableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult Dialog = MessageBox.Show("DO YOU WANT TO EXIT FROM THIS APPLICATION?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(Dialog ==DialogResult.Yes)
            {
                //Application.Exit();
                LibraryHomeMenu LHM = new LibraryHomeMenu();
                LHM.Show();
                this.Close();
            }
            else
            {
                Dialog = DialogResult.No;
            }

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            this.BookIdTb.Text = "";
            this.BookNameTb.Text = "";
            this.BookauthourTb.Text = "";
            //this.PublishDateDtp.Value = 'dd/mm/yyyy'  ;
            this.BookcategoryCb.SelectedIndex = -1;
            this.QuantityCb.SelectedIndex = -1;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do You want to Delete this Record?", "DELETE RECORD", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                connection.Open();
                SqlCommand Sc = connection.CreateCommand();
                Sc.CommandType = CommandType.Text;
                Sc.CommandText = "delete from [Table] where Book_Id = '" + BookIdTb.Text + "'";
                Sc.ExecuteNonQuery();
                connection.Close();
                Display_Data();
            }
            else
            {
                dialog = DialogResult.No;
            }
            
        }

        private void PublishDateDtp_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = PublishDateDtp.Value;
            if (date == null)
            {
                MessageBox.Show("BAD");
            }
          
            
        }

        private void BookIdTb_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand SC = connection.CreateCommand();
            SC.CommandType = CommandType.Text;
            SC.CommandText = "select * from [Table] where Book_Id = '"+BookIdTb.Text+"' ";
            connection.Close();

            SqlDataAdapter DA = new SqlDataAdapter(SC);
            DataSet ds = new DataSet();
            DA.Fill(ds);

            int count = ds.Tables[0].Rows.Count;
            string B_Id = BookIdTb.Text;
            if (count == 1)
            {
                MessageBox.Show("This book is Already Registered in the Database. Please," +
                    "Delete existing data by pressing 'DELETE' buttton or enter new book","RECORD EXIST..!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DeleteBtn.Enabled = true;
                RegisterBtn.Enabled = false;
            }
            else if (B_Id != "")
            {
                RegisterBtn.Enabled = true;
                ClearBtn.Enabled = true;
            }
            else
            {
                DeleteBtn.Enabled = false; 
                RegisterBtn.Enabled = false;
                ClearBtn.Enabled = false;
            }

        }
    }
}

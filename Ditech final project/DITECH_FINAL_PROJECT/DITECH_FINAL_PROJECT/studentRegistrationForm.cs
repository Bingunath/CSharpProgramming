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
    public partial class studentRegistrationForm : Form
    {
        // this initialize the connection with the database.
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Trusted_Connection=Yes;Integrated Security=True;");

        string GENDER;// declaring varible for gender radio button.


        public studentRegistrationForm(string name)
        {
            InitializeComponent();
            //Those codes for disable for form buttons when the form loads.
            inbtn.Enabled = false;
            dlbtn.Enabled = false;
            clbtn.Enabled = false;
            exbtn.Enabled = true;// when the form loads "EXIT" button will be enabled
            calculatfee.Enabled = false;
            clearBtn.Enabled = false;
            UserLabel.Text = name;
        }

        public studentRegistrationForm()
        {
            InitializeComponent();
            //Those codes for disable for form buttons when the form loads.
            inbtn.Enabled = false;
            dlbtn.Enabled = false;
            clbtn.Enabled = false;
            exbtn.Enabled = true;// when the form loads "EXIT" button will be enabled
            calculatfee.Enabled = false;
            clearBtn.Enabled = false;
            //label5.Text = name;
        }
        private void studentRegistrationForm_Load(object sender, EventArgs e)
        {
            CourseDataGrid.ReadOnly = true;
            data_display();
            Display_data();
            CourseList_Load();
            label10.Text = "";
            label11.Text = "";

        }

        public void CourseList_Load()
        {
            ecCB.Items.Clear();
            connection.Open();
            SqlCommand sc = connection.CreateCommand();
            sc.CommandType = CommandType.Text;
            sc.CommandText = "select * from [courses]";
            sc.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows )
            {
                ecCB.Items.Add(dr["coursename"].ToString());
            }
            connection.Close();

        }

        public void Display_data()
        {
            connection.Open();
            SqlCommand sc = connection.CreateCommand();
            sc.CommandType = CommandType.Text;
            sc.CommandText = "select * from [courses]";
            sc.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(sc);
            dta.Fill(dt);
            CourseDataGrid.DataSource = dt;
            connection.Close();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rn_Click(object sender, EventArgs e)
        {
            rnTB.Focus();//focusing Registration number textbox when the user clicks the label
        }

        private void r_studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.r_studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.students_RegistrationDataSet);

        }

        

        private void sn_Click(object sender, EventArgs e)
        {
            snTB.Focus();//focusing Student name textbox when the user clicks the lable
        }

        private void dob_Click(object sender, EventArgs e)
        {
            dtp.Focus();//focusing Date of birth textbox when the user clicks the lable
        }

        private void aTB_TextChanged(object sender, EventArgs e)
        {
            // This codes for enable or disable buttons when the user enter age of student.
            string age = aTB.Text;
            if (age != "")
            {
                inbtn.Enabled = true;
                clbtn.Enabled = true;
                exbtn.Enabled = false;
                dlbtn.Enabled = false;

            }
            else
            {
                inbtn.Enabled = false;
                exbtn.Enabled = true;
                clbtn.Enabled = false;
                dlbtn.Enabled = false;
            }

        }

        private void cntct_Click(object sender, EventArgs e)
        {
            cnTB.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ecCB.Focus();
        }

        private void inbtn_Click(object sender, EventArgs e)
        {
            


            //Declaring variable for if-else statement to check whether textboxs are empty.

            string Rnumber = rnTB.Text;
            string Sname = snTB.Text;
            string age = aTB.Text;
            string DOB = dtp.Value.ToString();            
            string contactS = cnTB.Text.ToString();
                      

            int courses = ecCB.SelectedIndex;
            

            if (Rnumber == "")
            {
                MessageBox.Show("You should Enter Registration Number.!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error );
                rnTB.Focus();
                     
                
                
            }         
            else if (Sname == "")
            {
                MessageBox.Show("You should Enter Student Name..!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                snTB.Focus();
            }
            else if (age == "")
            {
                MessageBox.Show("You should Select Student's Birthday..!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtp.Focus();
            }
            else if (contactS == "")
            {
                MessageBox.Show("You should Enter Student's Contact Number..!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cnTB.Focus();
            }
            else if (courses == -1)
            {
                MessageBox.Show("You should Select the student's Enrolled course..!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ecCB.Focus();
            }
            
            else if (DOB == "")
            {
                MessageBox.Show("You should Select your Date of Birth..!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtp.Focus();
            }
            else if(contactS == "")
            {
                MessageBox.Show("You should Enter Your contact number..!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cnTB.Focus();
                
            }
                        
            else
            {
                
                connection.Open();
                SqlCommand sc = connection.CreateCommand();
                sc.CommandType = CommandType.Text;
                sc.CommandText = "insert into [students] (Rnumber, names, dob, age, gender, contactNumber, courses, courseID, fee, Discount_Presentage, Discounted_Amount, Net_Course_Fee, Cash, Balance, Registar_Name)" +
                    "values('" + rnTB.Text + "', '" + snTB.Text + "', '" + dtp.Value.ToString() + "','" + aTB.Text.ToString() + "', '" + GENDER + "' , '" + cnTB.Text.ToString() + "', '" + ecCB.SelectedItem.ToString() + "','"+CourseIDTB.Text+"' ,  '" + feebox.Text + "', '"+discBox.Text+"', '"+discamntTB.Text+"', '"+netfeeTB.Text+"', '"+CashTB.Text+"', '"+BalanceTB.Text+"', '"+UserLabel.Text+"' )";
                sc.ExecuteNonQuery();
                connection.Close();
                data_display();
                MessageBox.Show("Student Resgitered..!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.rnTB.Text = "";
                this.snTB.Text = "";
                this.dtp.Checked = false;
                this.aTB.Text = "";
                this.cnTB.Text = "";
                this.ecCB.SelectedIndex = 0;
                this.feebox.Text = "";
                CourseIDTB.Text = "";
                CashTB.Text = "";
                BalanceTB.Text = "";
                clearBtn_Click(sender, e);

            }


            



        }

        private void ecCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand sc1 = connection.CreateCommand();
            sc1.CommandType = CommandType.Text;
            sc1.CommandText = "select * from [courses] where coursename ='"+ecCB.SelectedItem.ToString()+"'  ";

            SqlDataReader dr = sc1.ExecuteReader();

            if (dr.Read())
            {
                feebox.Text = (dr["coursefees"].ToString());
                CourseIDTB.Text = (dr["courseID"].ToString());
                //textBox1.Text = (dr["courseID"].ToString());
                
            }
            else
            {
                feebox.Text = "";
                CourseIDTB.Text = "";
            }
            connection.Close();

        }

        private void clbtn_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Do you want to Clear all the information you entered?", "CLEAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dialog == DialogResult.Yes)
            {
                this.rnTB.Text = "";
                this.snTB.Text = "";
                this.dtp.Checked = false;
                this.aTB.Text = "";
                this.cnTB.Text = "";
                this.ecCB.SelectedIndex = 0;
                rbtnM.Checked = false;
                rbtnFe.Checked = false;
                this.feebox.Text = "";
                CourseIDTB.Text = "";
            }
            else
            {
                dialog = DialogResult.No;
            }
            
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            DateTime dob = dtp.Value;
            DateTime today = DateTime.Now;
            TimeSpan days = (today - dob);
            int age = (int)days.TotalDays;
            aTB.Text = (age / 365).ToString();

            if(age/365 < 18)// This expression can check whether Student below 18 Years old. 
            {
                MessageBox.Show("Under 18 years old students can not be enrolled");//and let the user know.
                aTB.Clear();
            }
            else if(dob > today )// this expression for avoid user entering non-exixtence Birthdates
            {
                MessageBox.Show("Invalid Birthday Input..!");
            }
        }

        public void data_display()
        {
            
            connection.Open();
            SqlCommand sc = connection.CreateCommand();
            sc.CommandType = CommandType.Text;
            sc.CommandText = "select * from [students]";
            sc.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(sc);
            dta.Fill(dt);
            studentsDataGridView.DataSource = dt;
            connection.Close();



        }

        

        private void exbtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Exite from this application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(dialog == DialogResult.Yes)
            {
                this.Hide();
            }
            else
            {
                dialog = DialogResult.No;
            }
            
        }

        private void dlbtn_Click(object sender, EventArgs e)
        {
            DialogResult ConfirmationMessage = MessageBox.Show("Do you want to delete this Record?","DELETE", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            string Sname = snTB.Text;
            if (ConfirmationMessage == DialogResult.Yes)
            {
                

                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from [students] where Rnumber ='"+rnTB.Text+"'    ";
                cmd.ExecuteNonQuery();                
                connection.Close();
                data_display();
                MessageBox.Show("Student Deleted Successfully..!", "SUCCESSFULLY DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rnTB.Clear();

            }
            else
            {
                ConfirmationMessage = DialogResult.No;
            }
            
        }

        
        private void rnTB_TextChanged(object sender, EventArgs e)
        {

            

            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [students] where Rnumber ='" + rnTB.Text + "'  ";
            connection.Close();

            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sa.Fill(ds);

            string number = rnTB.Text;
            int cnt = ds.Tables[0].Rows.Count;

            
            if (cnt == 1)
            {

                MessageBox.Show("Student Record already in the Database..!," +
                    "Please Delete the existing record by pressing 'DELETE' button or enter new student number.", "RECORD EXIST", MessageBoxButtons.OK, MessageBoxIcon.Information);
                inbtn.Enabled = false;
                clbtn.Enabled = true;
                dlbtn.Enabled = true;
                exbtn.Enabled = false;




            }           
            else if (number != "")
            {
                inbtn.Enabled = true;
                clbtn.Enabled = true;
                exbtn.Enabled = false;
                dlbtn.Enabled = false;

            }
            else
            {
               
                inbtn.Enabled = false;
                exbtn.Enabled = true;
                clbtn.Enabled = false;
                dlbtn.Enabled = false;

            }          
                                  
            

            
        }

        private void snTB_TextChanged(object sender, EventArgs e)
        {
            string name = snTB.Text;
            if (name != "")
            {
                inbtn.Enabled = true;
                clbtn.Enabled = true;
                exbtn.Enabled = false;
                dlbtn.Enabled = true;
            }
            else
            {
                inbtn.Enabled = false;
                exbtn.Enabled = true;
                clbtn.Enabled = false;
                dlbtn.Enabled = false;
            }
        }

        private void Showbtn_Click(object sender, EventArgs e)
        {
            this.data_display();
        }

        private void dit_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calculatfee_Click(object sender, EventArgs e)
        {

            string CourseFee = discount.Text;
            int ICourseFee = Int32.Parse(CourseFee);

            string DicountPresentage = discBox.Text;
            int IDicountPresentage = Int32.Parse(DicountPresentage);

            string DiscountedAmount = discamntTB.Text;
            //int IDiscountedAmount = Int32.Parse(DiscountedAmount);

            if(CourseFee == feebox.Text)
            {
                int Discount = (ICourseFee * IDicountPresentage) / 100;
                int NetWorth = ICourseFee - Discount;
                discamntTB.Text = Discount.ToString();
                netfeeTB.Text = NetWorth.ToString();
                
            }
            else
            {
                MessageBox.Show("Discount is not applicable Please try again later", "NOT VALID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearBtn_Click(sender,e);

            }

            /*string Dit = ditcf.Text;// Declaring varble for Diploma in information Technology course text
            int nDit = Int32.Parse(Dit);// converting text to integer

            string disc = discBox.Text;
            int Ndisc = Int32.Parse(disc);

            string De = decf.Text;
            int nDe = Int32.Parse(De);

            string Dbm = dbmcf.Text;
            int nDbm = Int32.Parse(Dbm);

            string Hndc = hndccf.Text;
            int nHndc = Int32.Parse(Hndc);

            string Hndbm = hndbmcf.Text;
            int nHndbm = Int32.Parse(Hndbm);

            string Dbox = discount.Text;

            if (Dbox == Dit)//if-else statement for Diploma IT
            {
                int Ndiscount = (nDit * Ndisc) / 100;
                feebox.Text ="Rs. " + (nDit - Ndiscount).ToString();
                netfeeTB.Text = (nDit - Ndiscount).ToString();
                discamntTB.Text = Ndiscount.ToString();
            }
            
            else if (Dbox == De)//if-else statement for Diploma Englsh
            {
                int Ndiscount = (nDe * Ndisc) / 100;
                feebox.Text = (nDe - Ndiscount).ToString();
                netfeeTB.Text = (nDe - Ndiscount).ToString();
                discamntTB.Text = Ndiscount.ToString();
            }
            else if (Dbox == Dbm)//if-else statement for Diploma BM
            {
                int Ndiscount = (nDbm * Ndisc) / 100;
                feebox.Text = (nDbm - Ndiscount).ToString();
                netfeeTB.Text = (nDbm - Ndiscount).ToString();
                discamntTB.Text = Ndiscount.ToString();
            }
            else if (Dbox == Hndc)//if-else statement for HND commerce
            {
                int Ndiscount = (nHndc * Ndisc) / 100;
                feebox.Text = (nHndc - Ndiscount).ToString();
                netfeeTB.Text = (nHndc - Ndiscount).ToString();
                discamntTB.Text = Ndiscount.ToString();
            }
            else if (Dbox == Hndbm)
            {
                int Ndiscount = (nHndbm * Ndisc) / 100;
                feebox.Text = (nHndbm - Ndiscount).ToString();
                netfeeTB.Text = (nHndbm - Ndiscount).ToString();
                discamntTB.Text = Ndiscount.ToString();
            }
            else
            {
                MessageBox.Show("Discount Not Applicable", "Discount Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                discamntTB.Text = "";
                netfeeTB.Text = "";
                feebox.Text = "";
            }*/
        }

        private void r_studentsDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           // dlbtn.Enabled = true;

        }

        private void rbtnM_CheckedChanged(object sender, EventArgs e)
        {
            GENDER = "Male";
        }

        private void rbtnFe_CheckedChanged(object sender, EventArgs e)
        {
            GENDER = "Female";
        }

        

        private void clearBtn_Click(object sender, EventArgs e)
        {
            discount.Clear();
            discBox.Clear();
            discamntTB.Clear();
            netfeeTB.Clear();
        }

        private void discount_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void discBox_TextChanged(object sender, EventArgs e)
        {

            string Discount = discBox.Text;
            if (Discount != "")
            {
                calculatfee.Enabled = true;
                clearBtn.Enabled = true;
            }
            else
            {
                calculatfee.Enabled = false;
                clearBtn.Enabled = false;                
            }
        }

        private void feebox_TextChanged(object sender, EventArgs e)
        {
            discount.Text = feebox.Text;
        }

        private void CourseDataGrid_Click(object sender, EventArgs e)
        {
            discount.Text = CourseDataGrid.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                Display_data();
                label11.Text = "";
            }
            else
            {
                connection.Open();
                SqlCommand sc = connection.CreateCommand();
                sc.CommandType = CommandType.Text;
                sc.CommandText = "select * from [courses] where courseID ='" + textBox1.Text + "' ";

                
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                sda.Fill(ds);
                sda.Fill(dt);
                CourseDataGrid.DataSource = dt;

                int Snumber = ds.Tables[0].Rows.Count;

                if (Snumber == 1)
                {
                    label11.Text = "";
                }
                else
                {
                    label11.Text = "No Record Found..!";
                }
                connection.Close();

            }

            
        }

        private void CourseIDTB_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void BalanceBtn_Click(object sender, EventArgs e)
        {

           
            //string Cash = CashTB.Text;
           // int Icash = Int32.Parse(Cash);

            //string Netfee = netfeeTB.Text;
            //int INetfee = Int32.Parse(Netfee);

            //string Fullfee = discount.Text;
            //int IFullfee = Int32.Parse(Fullfee);

            if(CashTB.Text == "" || netfeeTB.Text == "")
            {
                MessageBox.Show("Please Enter cash amount or course fee", "PLEASE COMPLETE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (BalanceCB.SelectedItem == BalanceCB.Items[0])
            {
               // INetfee = 0;
                string Cash = CashTB.Text;
                int Icash = Int32.Parse(Cash);

                string Netfee = netfeeTB.Text;
                int INetfee = Int32.Parse(Netfee);


                string Fullfee = discount.Text;
                int IFullfee = Int32.Parse(Fullfee);

                int Balance1 = Icash - IFullfee;
                BalanceTB.Text = Balance1.ToString();
                //BalanceCB.Items.Remove(BalanceCB.Items[0]);
                
                
            }
            else
            {
                string Cash = CashTB.Text;
                int Icash = Int32.Parse(Cash);

                string Netfee = netfeeTB.Text;
                int INetfee = Int32.Parse(Netfee);


                string Fullfee = discount.Text;
                int IFullfee = Int32.Parse(Fullfee);

                BalanceCB.SelectedItem = BalanceCB.Items[1];
                int Balance2 = Icash -INetfee ;
                BalanceTB.Text = Balance2.ToString();

            }
        }

        private void BalanceCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            string Netfee = netfeeTB.Text;
            

            
            if (BalanceCB.SelectedItem == BalanceCB.Items[0])
            {

                netfeeTB.Text = feebox.Text;

            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            
            if (searchBox.Text == "")
            {
                data_display();
                label10.Text = "";
            }
            else
            {
                connection.Open();
                SqlCommand sc = connection.CreateCommand();
                sc.CommandType = CommandType.Text;
                sc.CommandText = "select * from [students] where Rnumber = '" + searchBox.Text + "' ";

                SqlDataAdapter sda = new SqlDataAdapter(sc);
                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                sda.Fill(dt);
                sda.Fill(ds);
                studentsDataGridView.DataSource = dt;

                int Snumber = ds.Tables[0].Rows.Count; 

                if(Snumber == 1)
                {
                    label10.Text = "";
                }
                else
                {
                    label10.Text = "No Record Found..!";
                }
                connection.Close();
            }
            
        }
    }
}

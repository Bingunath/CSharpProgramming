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

    public partial class ManageCourses : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\DiTech\Ditech final project\DITECH_FINAL_PROJECT\DITECH_FINAL_PROJECT\Database1.mdf;Integrated Security = True");
        public ManageCourses()
        {
            InitializeComponent();
        }

        private void ManageCourses_Load(object sender, EventArgs e)
        {
            Display_data();
            RegisterBtn.Enabled = false;
            EditBtn.Enabled = false;
            DeleteBtn.Enabled = false;
            ClearBtn.Enabled = false;
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

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string CourseID = CourseIDTB.Text;
            string CourseName = CourseNameTB.Text;

            string CourseFees = CourseFeesTB.Text;
            int Cfees = Int32.Parse(CourseFees);

            string Faciliator = FaciliatorTB.Text;

            if (CourseID == "" || CourseName == "" || Cfees.ToString() == "" || Faciliator == "")
            {
                MessageBox.Show("You Must Fill all the data", "FILL DATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                connection.Open();
                SqlCommand scomm = connection.CreateCommand();
                scomm.CommandType = CommandType.Text;
                scomm.CommandText = "insert into [courses](courseID, coursename,coursefees,coursefaciliator)" +
                    " values('" + CourseID + "', '" + CourseName + "', '" + Cfees.ToString() + "', '" + Faciliator + "')";
                scomm.ExecuteNonQuery();
                connection.Close();
                CourseIDTB.Text = "";
                CourseNameTB.Text = "";
                CourseFeesTB.Text = "";
                FaciliatorTB.Text = "";
                TitleBox.SelectedIndex = 0;
                Display_data();
                MessageBox.Show("New user account created, Please click 'OK' to navigate to the login page", "CREATED SUCCESSFULLY",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TitleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string Title = TitleBox.SelectedItem.ToString();

            for (int i = 0; i <= TitleBox.SelectedIndex; i++)
            {
                FaciliatorTB.Text = TitleBox.Items[i].ToString();
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to exit?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();

            }
            else
            {
                dialog = DialogResult.No;
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            CourseIDTB.Text = "";
            CourseNameTB.Text = "";
            CourseFeesTB.Text = "";
            FaciliatorTB.Text = "";
            TitleBox.SelectedIndex = 0;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand scomm = connection.CreateCommand();
            scomm.CommandType = CommandType.Text;
            scomm.CommandText = "delete from [courses] where courseID = '" + CourseIDTB.Text + "'  ";
            scomm.ExecuteNonQuery();
            connection.Close();
            CourseIDTB.Text = "";
            CourseNameTB.Text = "";
            CourseFeesTB.Text = "";
            FaciliatorTB.Text = "";
            TitleBox.SelectedIndex = 0;
            Display_data();
            MessageBox.Show("User account has been deleted", "DELETED SUCCESSFULLY",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CourseDataGrid_Click(object sender, EventArgs e)
        {
            CourseIDTB.Text = CourseDataGrid.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void CourseIDTB_TextChanged(object sender, EventArgs e)
        {
            string CourseID = CourseIDTB.Text;

            if (CourseID == "")
            {
                Display_data();
                RegisterBtn.Enabled = false;
                EditBtn.Enabled = false;
                DeleteBtn.Enabled = false;
                ClearBtn.Enabled = false;
            }
            else
            {
                connection.Open();
                SqlCommand sc = connection.CreateCommand();
                sc.CommandType = CommandType.Text;
                sc.CommandText = "select * from [courses] where courseID ='"+CourseIDTB.Text+"' ";
                connection.Close();
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                
                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                sda.Fill(dt);
                sda.Fill(ds);
                CourseDataGrid.DataSource = dt;

                

                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    RegisterBtn.Enabled = false;
                    EditBtn.Enabled = true;
                    DeleteBtn.Enabled = true;
                    ClearBtn.Enabled = true;
                    

                }
                else
                {
                    RegisterBtn.Enabled = true;
                    EditBtn.Enabled = false;
                    DeleteBtn.Enabled = false;
                    ClearBtn.Enabled = true;
                }

                connection.Open();
                SqlCommand sc1 = connection.CreateCommand();
                sc1.CommandType = CommandType.Text;
                sc1.CommandText = "select * from [courses] where courseID ='" + CourseIDTB.Text + "' ";
                SqlDataReader dr = sc1.ExecuteReader();



                if (dr.Read())
                {
                    CourseNameTB.Text = (dr["coursename"].ToString());
                    CourseFeesTB.Text = (dr["coursefees"].ToString());
                    FaciliatorTB.Text = (dr["coursefaciliator"].ToString());
                }

                else
                {
                    
                    CourseNameTB.Text = "";
                    CourseFeesTB.Text = "";
                    FaciliatorTB.Text = "";
                    TitleBox.SelectedIndex = 0;
                }
                connection.Close();
            }
        }

        private void CourseNameTB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            string CourseID = CourseIDTB.Text;
            string CourseName = CourseNameTB.Text;

            string CourseFees = CourseFeesTB.Text;
            int Cfees = Int32.Parse(CourseFees);

            string Faciliator = FaciliatorTB.Text;
            connection.Open();
            SqlCommand sc = connection.CreateCommand();
            sc.CommandType = CommandType.Text;
            sc.CommandText = "update [courses] set coursename='"+CourseName+"',coursefees='"+Cfees+"', coursefaciliator='"+Faciliator+"' where courseID = '"+CourseIDTB.Text+"'   ";
            sc.ExecuteNonQuery();
            connection.Close();
            CourseIDTB.Text = "";
            CourseNameTB.Text = "";
            CourseFeesTB.Text = "";
            FaciliatorTB.Text = "";
            TitleBox.SelectedIndex = 0;
            MessageBox.Show("User account has been updated", "UPDATED SUCCESSFULLY",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
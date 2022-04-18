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
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Hotelier_Hotel_ManagementSystem
{
    public partial class Gym : Form
    {
        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BinguTech\source\repos\Hotelier_Hotel_ManagementSystem\Hotelier_Hotel_ManagementSystem\DataBase\Hotelierbase.mdf;Integrated Security=True");
        //SqlConnection Connection = new SqlConnection(SqlConnectionClass.ConnectionString);
        public Gym()
        {
            InitializeComponent();
        }

        private void Gym_Load(object sender, EventArgs e)
        {
            timer1.Start();
            TimeLabel.Text = DateTime.Now.ToShortTimeString();
            DateLabel.Text = DateTime.Now.ToLongDateString();
            DateDTP.CustomFormat = "dd/MM/yyyy";
            Random_Referance();
            MemberID_List();
            Room_List();
            TotalHeadCount();
            TowelCount();
            WaterBottlesCount();
            AdultCount();
            MaleCount();
            FemaleCount();
            label22.Text = "Data table is empty...!";
            label22.Visible = true;
            SearchData();

        }
        public void Random_Referance()
        {
            Random Number = new Random();
            int Number1 = Number.Next(00000, 100000);
            ReferanceTB.Text = "DGU" + Number1.ToString();
        }

        public void Display()
        {
            string comm = "select * from [gymdata]";
            Connection.Open();
            SqlCommand sc = new SqlCommand(comm, Connection);
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GymDataGrid.DataSource = dt;
            Connection.Close();
        }

        private void SearchData()
        {
            string com = "select * from [gymdata] where date between'" + FromDateDTP.Value.ToString() + "' and '" + ToDateDTP.Value.ToString() + "' ";
            Connection.Open();
            SqlCommand sc = new SqlCommand(com, Connection);
            sc.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GymDataGrid.DataSource = dt;
            if (dt.Rows.Count >= 1)
            {
                label22.Text = "";
                label22.Visible = false;
            }
            else
            {
                label22.Text = "No guest data found..!";
                label22.Visible = true;
            }

            Connection.Close();
            TotalHeadCount();
            TowelCount();
            WaterBottlesCount();
            AdultCount();
            MaleCount();
            FemaleCount();
        }
        public void MemberID_List()
        {
            string com = "select * from [gymmembers]";
            Connection.Open();
            SqlCommand sc = new SqlCommand(com, Connection);
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Connection.Close();
            int cnt = dt.Rows.Count;
            for (int i = 0; i < cnt; i++)
            {
                MembersIDCB.Items.Add(dt.Rows[i]["membershipid"].ToString());                
            }
        }

        public void Room_List()
        {
            string com = "select * from [inhouseguests]";
            Connection.Open();
            SqlCommand sc = new SqlCommand(com, Connection);
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Connection.Close();
            int cnt = dt.Rows.Count;
            for (int i = 0; i < cnt; i++)
            {
                RoomListCB.Items.Add(dt.Rows[i]["roomno"].ToString());
                RoomListCB.Sorted = true;
            }
        }

        public void TotalHeadCount()
        {

            //int RowCount = GymDataGrid.Rows.Count - 1;
            //HeadCountLB.Text = RowCount.ToString();
            int sum = 0;
            for (int i = 0; i < GymDataGrid.Rows.Count; i++)
            {
                sum = (sum + Convert.ToInt32(GymDataGrid.Rows[i].Cells[9].Value));
            }
            HeadCountLB.Text = sum.ToString();

        }
        public void TowelCount()
        {
            int sum = 0;
            for (int i = 0; i < GymDataGrid.Rows.Count; i++)
            {
                sum = (sum + Convert.ToInt32(GymDataGrid.Rows[i].Cells[8].Value));
            }
            TowelCountLB.Text = sum.ToString();

        }
        public void WaterBottlesCount()
        {
            int sum = 0;
            for (int i = 0; i < GymDataGrid.Rows.Count; i++)
            {
                sum = (sum + Convert.ToInt32(GymDataGrid.Rows[i].Cells[12].Value));
            }
            WaterBottlesLB.Text = sum.ToString();

        }
        public void MaleCount()
        {
            int sum = 0;
            for (int i = 0; i < GymDataGrid.Rows.Count; i++)
            {
                sum = (sum + Convert.ToInt32(GymDataGrid.Rows[i].Cells[10].Value));
            }
            MaleHCLB.Text = sum.ToString();

        }
        public void FemaleCount()
        {
            int sum = 0;
            for (int i = 0; i < GymDataGrid.Rows.Count; i++)
            {
                sum = (sum + Convert.ToInt32(GymDataGrid.Rows[i].Cells[11].Value));
            }
            FemaleHCLB.Text = sum.ToString();

        }
        public void AdultCount()
        {
            int sum = 0;
            for (int i = 0; i < GymDataGrid.Rows.Count; i++)
            {
                sum = (sum + Convert.ToInt32(GymDataGrid.Rows[i].Cells[9].Value));
            }
            AdultsHCLB.Text = sum.ToString();

        }


        private void TimeinBtn_Click(object sender, EventArgs e)
        {
            //TimeINDTP.CustomFormat = "HH:mm:ss";
            TimeINTB.Text = TimeLabel.Text;
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            DateDTP.CustomFormat = "dd/MM/yyyy";
        }

        private void TimeOutBtn_Click(object sender, EventArgs e)
        {
            try
            {
                TimeOutTB.Text = TimeLabel.Text;

                DateTime TimeIN = Convert.ToDateTime(TimeINTB.Text);
                DateTime TimeOut = Convert.ToDateTime(TimeOutTB.Text);

                TimeSpan WorkoutDu = TimeOut - TimeIN;
                float DU = ((float)WorkoutDu.TotalHours);
                TimeSpan DU2 = WorkoutDu.Duration();
                float DU1 = ((float)WorkoutDu.TotalMinutes);

                if (DU < 1)
                {
                    textBox1.Text = DU1.ToString() + "Mins";
                }
                else
                {
                    //textBox1.Text =Math.Round(DU).ToString() + "Hrs"; 
                    textBox1.Text = DU2.ToString().Remove(5) + "Hrs";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("'TimeIn' can not be empty. " + ex.Message );
                TimeinBtn.Focus();
            }

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string REF = ReferanceTB.Text;
            string MemberID = MemberIDTB.Text;
            string Name = NameTB.Text;
            string TimeIN = TimeINTB.Text;
            string Towels = TowelTB.Text;
            string water = waterBottles.Text;
            if (REF == "" || MemberID == "" || Name == "" || TimeIN == "" || Towels == "" || water == "")
            {
                MessageBox.Show("Please Fill the required fields", "Please Fill", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string com = "insert into [gymdata] (referanceid,roomnumber,title,name,date,timein,timeout,workouttime,towels,adult,male,female,waterbottles,remarks)" +
                "values('" + ReferanceTB.Text + "','" + MemberIDTB.Text + "','" + TitleTB.Text + "','" + NameTB.Text + "','" + DateDTP.Value.ToString() + "','" + TimeINTB.Text + "','" + TimeOutTB.Text + "','" + textBox1.Text + "','" + TowelTB.Text + "','" + AdultsTB.Text + "','" + MaleTB.Text + "','" + FemaleTB.Text + "','" + waterBottles.Text + "',  '" + RemarksTB.Text + "'  )";
                Connection.Open();
                SqlCommand cmd = new SqlCommand(com, Connection);
                cmd.ExecuteNonQuery();
                Connection.Close();
                ReferanceTB.Text = "";
                MemberIDTB.Text = "";
                TitleTB.Text = "";
                NameTB.Text = "";
                DateDTP.ResetText();
                TimeINTB.Text = "";
                TimeOutTB.Text = "";
                textBox1.Text = "";
                TowelTB.Text = "0";
                AdultsTB.Text = "0";
                MaleTB.Text = "0";
                FemaleTB.Text = "0";
                waterBottles.Text = "0";
                RemarksTB.Text = "";
                //Display();
                SearchData();
                Random_Referance();
                TowelCount();
                TotalHeadCount();
                WaterBottlesCount();
                AdultCount();
                MaleCount();
                FemaleCount();

            }


        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ReferanceTB.Text = "";
            MemberIDTB.Text = "";
            TitleTB.Text = "";
            NameTB.Text = "";
            DateDTP.ResetText();
            TimeINTB.Text = "";
            TimeOutTB.Text = "";
            textBox1.Text = "";
            TowelTB.Text = "0";
            AdultsTB.Text = "0";
            MaleTB.Text = "0";
            FemaleTB.Text = "0";
            waterBottles.Text = "0";
            RemarksTB.Text = "";
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string com = "delete from [gymdata] where referanceid = '" + ReferanceTB.Text + "' ";
            Connection.Open();
            SqlCommand cmd = new SqlCommand(com, Connection);
            cmd.ExecuteNonQuery();
            Connection.Close();
            ReferanceTB.Text = "";
            MemberIDTB.Text = "";
            TitleTB.Text = "";
            NameTB.Text = "";
            DateDTP.ResetText();
            TimeINTB.Text = "";
            TimeOutTB.Text = "";
            textBox1.Text = "";
            TowelTB.Text = "0";
            AdultsTB.Text = "0";
            MaleTB.Text = "0";
            FemaleTB.Text = "0";
            waterBottles.Text = "0";
            RemarksTB.Text = "";
            SearchData();
            Random_Referance();
            TowelCount();
            TotalHeadCount();
            WaterBottlesCount();
            AdultCount();
            MaleCount();
            FemaleCount();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string com = "update [gymdata] set referanceid = '" + ReferanceTB.Text + "',roomnumber = '" + MemberIDTB.Text + "',title= '" + TitleTB.Text + "', name ='" + NameTB.Text + "',date= '" + DateDTP.Value.ToString() + "',timein ='" + TimeINTB.Text + "',timeout= '" + TimeOutTB.Text + "',workouttime = '" + textBox1.Text + "',towels= '" + TowelTB.Text + "',adult='" + AdultsTB.Text + "', male='" + MaleTB.Text + "',female='"+FemaleTB.Text+"'  ,waterbottles= '" + waterBottles.Text + "',remarks= '" + RemarksTB.Text + "'   where referanceid = '" + ReferanceTB.Text + "' ";

            Connection.Open();
            SqlCommand cmd = new SqlCommand(com, Connection);
            cmd.ExecuteNonQuery();
            Connection.Close();

            ReferanceTB.Text = "";
            MemberIDTB.Text = "";
            TitleTB.Text = "";
            NameTB.Text = "";
            DateDTP.ResetText();
            TimeINTB.Text = "";
            TimeOutTB.Text = "";
            textBox1.Text = "";
            TowelTB.Text = "0";
            AdultsTB.Text = "0";
            MaleTB.Text = "0";
            FemaleTB.Text = "0";
            waterBottles.Text = "0";
            RemarksTB.Text = "";
            SearchData();
            Random_Referance();
            TowelCount();
            TotalHeadCount();
            WaterBottlesCount();
            AdultCount();
            MaleCount();
            FemaleCount();
        }

        private void GymDataGrid_DoubleClick(object sender, EventArgs e)
        {

            ReferanceTB.Text = GymDataGrid.SelectedRows[0].Cells[0].Value.ToString();
            MemberIDTB.Text = GymDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            TitleTB.Text = GymDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            NameTB.Text = GymDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            DateDTP.CustomFormat = GymDataGrid.SelectedRows[0].Cells[4].Value.ToString();
            TimeINTB.Text = GymDataGrid.SelectedRows[0].Cells[5].Value.ToString();
            TimeOutTB.Text = GymDataGrid.SelectedRows[0].Cells[6].Value.ToString();
            textBox1.Text = GymDataGrid.SelectedRows[0].Cells[7].Value.ToString();
            TowelTB.Text = GymDataGrid.SelectedRows[0].Cells[8].Value.ToString();
            AdultsTB.Text = GymDataGrid.SelectedRows[0].Cells[9].Value.ToString();
            MaleTB.Text = GymDataGrid.SelectedRows[0].Cells[10].Value.ToString();
            FemaleTB.Text = GymDataGrid.SelectedRows[0].Cells[11].Value.ToString();
            waterBottles.Text = GymDataGrid.SelectedRows[0].Cells[12].Value.ToString();
            RemarksTB.Text = GymDataGrid.SelectedRows[0].Cells[13].Value.ToString();


        }

        private void EditBTN_Click(object sender, EventArgs e)
        {
            try
            {
                ReferanceTB.Text = GymDataGrid.SelectedRows[0].Cells[0].Value.ToString();
                MemberIDTB.Text = GymDataGrid.SelectedRows[0].Cells[1].Value.ToString();
                TitleTB.Text = GymDataGrid.SelectedRows[0].Cells[2].Value.ToString();
                NameTB.Text = GymDataGrid.SelectedRows[0].Cells[3].Value.ToString();
                DateDTP.CustomFormat = GymDataGrid.SelectedRows[0].Cells[4].Value.ToString();
                TimeINTB.Text = GymDataGrid.SelectedRows[0].Cells[5].Value.ToString();
                TimeOutTB.Text = GymDataGrid.SelectedRows[0].Cells[6].Value.ToString();
                textBox1.Text = GymDataGrid.SelectedRows[0].Cells[7].Value.ToString();
                TowelTB.Text = GymDataGrid.SelectedRows[0].Cells[8].Value.ToString();
                AdultsTB.Text = GymDataGrid.SelectedRows[0].Cells[9].Value.ToString();
                MaleTB.Text = GymDataGrid.SelectedRows[0].Cells[10].Value.ToString();
                FemaleTB.Text = GymDataGrid.SelectedRows[0].Cells[11].Value.ToString();
                waterBottles.Text = GymDataGrid.SelectedRows[0].Cells[12].Value.ToString();
                RemarksTB.Text = GymDataGrid.SelectedRows[0].Cells[13].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Please select data row that you want to edit");
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToShortTimeString();
            timer1.Start();
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            Random_Referance();
        }

        private void ReferanceTB_TextChanged(object sender, EventArgs e)
        {
            string com = "select * from [gymdata] where referanceid ='" + ReferanceTB.Text + "' ";
            Connection.Open();
            SqlCommand sc = new SqlCommand(com, Connection);
            Connection.Close();
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            int count = dt.Rows.Count;
            if (count == 1)
            {
                SaveBtn.Enabled = false;
            }
            else
            {
                SaveBtn.Enabled = true;
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if(SearchTB.Text != "")
            {
                string com = "select * from [gymdata] where referanceid like'" + SearchTB.Text + "%' or roomnumber like '" + SearchTB.Text + "%' or name like '" + SearchTB.Text + "%' and date between'" + FromDateDTP.Value.ToString() + "' and '" + ToDateDTP.Value.ToString() + "' ";
                Connection.Open();
                SqlCommand sc = new SqlCommand(com, Connection);
                sc.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                
                Connection.Close();

                if (dt.Rows.Count >= 1)
                {
                    GymDataGrid.DataSource = dt;
                    label22.Text = "";
                    label22.Visible = false;
                    
                }
                else
                {
                    GymDataGrid.DataSource = null;
                    label22.Text = "No guest data found...!";
                    label22.Visible = true;
                }
                TotalHeadCount();
                TowelCount();
                WaterBottlesCount();
                AdultCount();
                MaleCount();
                FemaleCount();
            }
            else
            {
                GymDataGrid.DataSource = null;
                label22.Text = "Data table is empty...!";
                label22.Visible = true;
                TotalHeadCount();
                TowelCount();
                WaterBottlesCount();
                AdultCount();
                MaleCount();
                FemaleCount();

            }
            
        }

        private void TitleCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            TitleTB.Text = TitleCB.SelectedItem.ToString();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string com = "select * from [gymdata] where date between'" + FromDateDTP.Value.ToString() + "' and '" + ToDateDTP.Value.ToString() + "' ";
            Connection.Open();
            SqlCommand sc = new SqlCommand(com, Connection);
            sc.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GymDataGrid.DataSource = dt;

            if (dt.Rows.Count >= 1)
            {
                label22.Text = "";
                label22.Visible = false;
            }
            else
            {
                label22.Text = "No guest data found..!";
                label22.Visible = true;
            }

            Connection.Close();
            TotalHeadCount();
            TowelCount();
            WaterBottlesCount();
            AdultCount();
            MaleCount();
            FemaleCount();

        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to export data to Excel sheet?", "EXPORT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                DataObject data = GymDataGrid.GetClipboardContent();
                if (data != null) Clipboard.SetDataObject(data);
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlApp.Visible = true;
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook;
                Microsoft.Office.Interop.Excel.Worksheet xlSheet;
                object Mdata = System.Reflection.Missing.Value;
                xlWorkbook = xlApp.Workbooks.Add(Mdata);
                xlSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkbook.Worksheets.get_Item(1);
                Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlSheet.Cells[1, 1];
                xlr.Select();

                xlSheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            }
            else
            {
                dialog = DialogResult.No;
            }
        }

        private void MembersIDCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            MemberIDTB.Text = MembersIDCB.SelectedItem.ToString();
        }

        private void MemberIDTB_TextChanged(object sender, EventArgs e)
        {
            string com = "select * from [gymmembers] where membershipid like'" + MemberIDTB.Text + "%' ";
            string com3 = "select * from [inhouseguests] where roomno ='" + MemberIDTB.Text + "' ";

            Connection.Open();
            SqlCommand sc = new SqlCommand(com, Connection);
            SqlCommand sc3 = new SqlCommand(com3, Connection);
            Connection.Close();
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            SqlDataAdapter sda3 = new SqlDataAdapter(sc3);
            DataTable dt = new DataTable();
            DataTable dt3 = new DataTable();
            sda.Fill(dt);
            sda3.Fill(dt3);

            if (MemberIDTB.Text != "")
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    TitleTB.Text = (dt.Rows[i]["title"].ToString());
                    NameTB.Text = (dt.Rows[i]["name"].ToString());
                }
                for (int i = 0; i < dt3.Rows.Count; i++)
                {
                    TitleTB.Text = (dt3.Rows[i]["title"].ToString());
                    NameTB.Text = (dt3.Rows[i]["firstname"].ToString() + " " + dt3.Rows[i]["lastname"].ToString());
                }
                if (dt.Rows.Count != 1 && dt3.Rows.Count != 1)
                {
                    TitleTB.Text = "";
                    NameTB.Text = "";
                }
            }
            
            else
            {
                TitleTB.Text = "";
                NameTB.Text = "";
            }

        }

        private void TotalBtn_Click(object sender, EventArgs e)
        {
            TotalHeadCount();
        }

        private void CountTowelBtn_Click(object sender, EventArgs e)
        {
            TowelCount();
        }

        private void TowelCountLB_Click(object sender, EventArgs e)
        {

        }

        private void HeadCountLB_Click(object sender, EventArgs e)
        {

        }

        private void WaterBottlesBtn_Click(object sender, EventArgs e)
        {
            WaterBottlesCount();
        }

        private void RoomListCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            MemberIDTB.Text = RoomListCB.SelectedItem.ToString();
        }

        private void ExportPDFBtn_Click(object sender, EventArgs e)
        {
            /*if (GymDataGrid.Rows.Count > 1)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "GymData";
                bool ErrorMessage = false;
                if(save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch(Exception ex)
                        {
                            //ErrorMessage = true;
                            //MessageBox.Show("Cannot write the data" + ex.Message);
                            //throw;
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pdftable = new PdfPTable(GymDataGrid.Columns.Count);
                            pdftable.DefaultCell.Padding = 2;
                            pdftable.WidthPercentage = 100;
                            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach(DataGridViewColumn col in GymDataGrid.Columns)
                            {
                                PdfPCell pdfcell = new PdfPCell(new Phrase(col.HeaderText));
                                pdftable.AddCell(pdfcell);

                            }
                            foreach(DataGridViewRow viewRow in GymDataGrid.Rows)
                            {
                                foreach(DataGridViewCell dcell in viewRow.Cells)
                                {
                                    pdftable.AddCell(dcell.Value.ToString());


                                }
                            }

                            FileStream fileStream = new FileStream(save.FileName,FileMode.Create);
                            Document document = new Document(PageSize.A4,8f,16f,16f,8f);
                            document.Open();
                            document.Add(pdftable);
                            document.Close();
                            fileStream.Close();
                            MessageBox.Show("Data exported.!");
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Error while exporting the data"+ ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No record Found","info");
            }*/
        }

        private void TimeOutTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime TimeIN = Convert.ToDateTime(TimeINTB.Text);
                DateTime TimeOut = Convert.ToDateTime(TimeOutTB.Text.Trim());

                TimeSpan WorkoutDu = TimeOut - TimeIN;
                float DU = ((float)WorkoutDu.TotalHours);
                TimeSpan DU2 = WorkoutDu.Duration();
                float DU1 = ((float)WorkoutDu.TotalMinutes);

                if (DU < 1)
                {
                    textBox1.Text = DU1.ToString() + "Mins";
                }
                else
                {
                    //textBox1.Text =Math.Round(DU).ToString() + "Hrs"; 
                    textBox1.Text = DU2.ToString().Remove(5) + "Hrs";
                }
            }
            catch
            {

            }


        }

        private void GymDataGrid_Click(object sender, EventArgs e)
        {
            try
            {
                TowelCountLB.Text = GymDataGrid.SelectedRows[0].Cells[8].Value.ToString();
                AdultsHCLB.Text = GymDataGrid.SelectedRows[0].Cells[9].Value.ToString();
                MaleHCLB.Text = GymDataGrid.SelectedRows[0].Cells[10].Value.ToString();
                FemaleHCLB.Text = GymDataGrid.SelectedRows[0].Cells[11].Value.ToString();
                WaterBottlesLB.Text = GymDataGrid.SelectedRows[0].Cells[12].Value.ToString();
                HeadCountLB.Text = AdultsHCLB.Text;
            }
            catch
            {
                MessageBox.Show("Data Row is empty..!");
            }
            
        }
    }
}

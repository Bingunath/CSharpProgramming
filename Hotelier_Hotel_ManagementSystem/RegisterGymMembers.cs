﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotelier_Hotel_ManagementSystem
{
    public partial class RegisterGymMembers : Form
    {
        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BinguTech\source\repos\Hotelier_Hotel_ManagementSystem\Hotelier_Hotel_ManagementSystem\DataBase\Hotelierbase.mdf;Integrated Security=True");
        //SqlConnection Connection = new SqlConnection(SqlConnectionClass.ConnectionString);
        public RegisterGymMembers()
        {
            InitializeComponent();
        }
        
        private void RegisterGymMembers_Load(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToShortDateString();
            MessageLB.Text = "There are no Gym Membership renewals";
            AutoGeneratedCode();
            Display();
            Display2();
            MemberID_List();
            MemberShipPlanList();
            Random_Referance();
            Seriel();
            MembershipRenewals();
            TotalGymMembers();
        }
        public void MemberID_List()
        {
            MemIDCB.Items.Clear();
            string com = "select * from [gymmembers]";
            Connection.Open();
            SqlCommand sc = new SqlCommand(com, Connection);
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Connection.Close();
            int cnt = dt.Rows.Count;
            for (int i= 0;i<cnt; i++)
            {
                MemIDCB.Items.Add(dt.Rows[i]["membershipid"].ToString());
            }
        }
        public void MemberShipPlanList()
        {
            MembPlanCB.Items.Clear();
            string com = "select * from [membershipplan]";
            Connection.Open();
            SqlCommand sc = new SqlCommand(com, Connection);
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Connection.Close();
            int cnt = dt.Rows.Count;
            for (int i = 0; i < cnt; i++)
            {
                MembPlanCB.Items.Add(dt.Rows[i]["membershipplan"].ToString());
                MembPlanCB.Sorted = true;
            }
        }
        public void Display()
        {
            string comm = "select * from [gymmembers]";
            Connection.Open();
            SqlCommand sc = new SqlCommand(comm, Connection);
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MemberGrid.DataSource = dt;
            Connection.Close();
        }
        public void TotalGymMembers()
        {
            string comm = "select * from [gymmembers]";
            Connection.Open();
            SqlCommand sc = new SqlCommand(comm, Connection);
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //MemberGrid.DataSource = dt;
            Connection.Close();

            label29.Text = "Total Registered Gym Members: " + ((dt.Rows.Count)-1).ToString();
        }
        public void Display2()
        {
            string comm = "select * from [gymmembership]";
            Connection.Open();
            SqlCommand sc = new SqlCommand(comm, Connection);
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            PaymentsGrid.DataSource = dt;
            Connection.Close();
        }
        
        public void AutoGeneratedCode()
        {
            string USERID;
            Connection.Open();
            string Query = "select * from [gymmembers]";
            SqlCommand cmd = new SqlCommand(Query, Connection);
            Connection.Close();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                
                int user = Int32.Parse(dt.Rows[i]["membershipid"].ToString().Remove(0, 5).Trim());
                //DateTime date = DateTime.Today ;
                USERID = (user + 1).ToString("MPMHG0000"); // + date;
                MemIDTB.Text = USERID.ToString();
                if (dt.Rows[i]["membershipid"].ToString() == "")
                {

                    MemIDTB.Text = "MPMHG0001";

                }
                /*else
                {
                    USERID = ("0001");
                }*/

            }



        }
        public void Random_Referance()
        {
            Random Number = new Random();
            int Number1 =Number.Next(0000000, 1000000);
            RefIDTB.Text = Number1.ToString();
            
        }
        public void Seriel()
        {
            Random Number = new Random();
            int Number1 = Number.Next(0000000000, 1000000000);
            SerielNOTB.Text = Number1.ToString();
        }
        private void MemIDTB_TextChanged(object sender, EventArgs e)
        {
            string com = "select * from [gymmembers] where membershipid ='" + MemIDTB.Text + "' ";
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
        private void MembershipRenewals()
        {
            try
            {
                string com4 = "select * from [gymmembership] where expires between '"+dateTimePicker1.Value.ToString()+ "' and '" + dateTimePicker2.Value.ToString() + "' ";
                Connection.Open();
                SqlCommand sc4 = new SqlCommand(com4, Connection);
                sc4.ExecuteNonQuery();
                SqlDataAdapter sda4 = new SqlDataAdapter(sc4);
                DataTable dt4 = new DataTable();
                sda4.Fill(dt4);
                ExpireDataGrid.DataSource = dt4;
                Connection.Close();

                if (dt4.Rows.Count >= 1)
                {
                    label28.Text = dt4.Rows.Count.ToString();
                    MessageLB.Visible = false;
                }
                else
                {
                    MessageLB.Text = "There are no Gym Membership renewals";
                    MessageLB.Visible = true;
                    label28.Text = "0";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void MembershipExpired()
        {
            try
            {
                string com4 = "select * from [gymmembership] where expires between '" + dateTimePicker1.Value.ToString() + "' and '" + dateTimePicker2.Value.ToString() + "' ";
                Connection.Open();
                SqlCommand sc4 = new SqlCommand(com4, Connection);
                sc4.ExecuteNonQuery();
                SqlDataAdapter sda4 = new SqlDataAdapter(sc4);
                DataTable dt4 = new DataTable();
                sda4.Fill(dt4);
                ExpireDataGrid.DataSource = dt4;
                Connection.Close();
                if (dt4.Rows.Count >= 1)
                {
                    label28.Text = dt4.Rows.Count.ToString();
                    MessageLB.Visible = false;

                }
                else
                {
                    MessageLB.Text = "There are no Gym Membership renewals";
                    MessageLB.Visible = true;
                    label28.Text = "0";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string MwmID = MemIDTB.Text;
            string Name = NameTB.Text;
            string passport = PassportTB.Text;
            string Address = AddressTB.Text;
            string email = EmailTB.Text;
            string idno = IdnoTB.Text;
            if (MwmID == "" || Name == "" || Address == "")
            {
                MessageBox.Show("Please Fill the required fields", "Please Fill", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string com = "insert into [gymmembers] (snno,membershipid,title,name,idno,passport,dob,regdate,nationality,address,contact,email)" +
                "values('" + SerielNOTB.Text + "','" + MemIDTB.Text + "','"+TitleTB.Text+"','" + NameTB.Text + "','" + IdnoTB.Text + "','" + PassportTB.Text + "','" + DOBDTP.Value.ToString() + "','"+RegisteredDTP.Value.ToString()+"' ,'"+NationalityTB.Text+"','" + AddressTB.Text + "','" + ContactTB.Text + "','" + EmailTB.Text + "' )";
                Connection.Open();
                SqlCommand cmd = new SqlCommand(com, Connection);
                cmd.ExecuteNonQuery();
                Connection.Close();
                MemIDTB.Text = "";
                TitleTB.Text = "";
                NameTB.Text = "";
                IdnoTB.Text = "xxxxxxxxxx";
                PassportTB.Text = "xxxxxxxxxx";
                DOBDTP.ResetText();
                RegisteredDTP.ResetText();
                AddressTB.Text = "";
                ContactTB.Text = "0000000000";
                EmailTB.Text = "";
                Display();
                AutoGeneratedCode();
                Seriel();
                MemberID_List();
                TotalGymMembers();
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string com = "update [gymmembers] set snno='" + SerielNOTB.Text + "', title = '" + TitleTB.Text + "',name= '" + NameTB.Text + "', idno ='" + IdnoTB.Text + "',passport= '" + PassportTB.Text + "',dob ='" + DOBDTP.Value.ToString() + "', regdate='" + RegisteredDTP.Value.ToString() + "' ,nationality ='" + NationalityTB.Text + "',address= '" + AddressTB.Text + "',contact = '" + ContactTB.Text + "',email= '" + EmailTB.Text + "' where membershipid = '" + MemIDTB.Text + "' ";

                Connection.Open();
                SqlCommand cmd = new SqlCommand(com, Connection);
                cmd.ExecuteNonQuery();
                Connection.Close();
                MemIDTB.Text = "";
                TitleTB.Text = "";
                NameTB.Text = "";
                IdnoTB.Text = "xxxxxxxxxx";
                PassportTB.Text = "xxxxxxxxxx";
                DOBDTP.ResetText();
                RegisteredDTP.ResetText();
                AddressTB.Text = "";
                ContactTB.Text = "0000000000";
                EmailTB.Text = "";
                Display();
                AutoGeneratedCode();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void CleatBtn_Click(object sender, EventArgs e)
        {
            MemIDTB.Text = "";
            TitleTB.Text = "";
            NameTB.Text = "";
            IdnoTB.Text = "xxxxxxxxxx";
            PassportTB.Text = "xxxxxxxxxx";
            DOBDTP.ResetText();
            RegisteredDTP.ResetText();
            AddressTB.Text = "";
            NationalityTB.Text = "";
            ContactTB.Text = "0000000000";
            EmailTB.Text = "";
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string com = "delete from [gymmembers] where membershipid = '" + MemIDTB.Text + "' ";
            Connection.Open();
            SqlCommand cmd = new SqlCommand(com, Connection);
            cmd.ExecuteNonQuery();
            Connection.Close();
            MemIDTB.Text = "";
            TitleTB.Text = "";
            NameTB.Text = "";
            IdnoTB.Text = "xxxxxxxxxx";
            PassportTB.Text = "xxxxxxxxxx";
            DOBDTP.ResetText();
            RegisteredDTP.ResetText();
            AddressTB.Text = "";
            ContactTB.Text = "0000000000";
            EmailTB.Text = "";
            Display();
            AutoGeneratedCode();
            MemberID_List();
            TotalGymMembers();
            Seriel();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            SerielNOTB.Text = MemberGrid.SelectedRows[0].Cells[0].Value.ToString();
            MemIDTB.Text = MemberGrid.SelectedRows[0].Cells[1].Value.ToString();
            TitleTB.Text = MemberGrid.SelectedRows[0].Cells[2].Value.ToString();
            NameTB.Text = MemberGrid.SelectedRows[0].Cells[3].Value.ToString();
            IdnoTB.Text = MemberGrid.SelectedRows[0].Cells[4].Value.ToString();
            PassportTB.Text = MemberGrid.SelectedRows[0].Cells[5].Value.ToString();
            DOBDTP.CustomFormat = MemberGrid.SelectedRows[0].Cells[6].Value.ToString();
            RegisteredDTP.CustomFormat = MemberGrid.SelectedRows[0].Cells[7].Value.ToString();
            NationalityTB.Text = MemberGrid.SelectedRows[0].Cells[8].Value.ToString();
            AddressTB.Text = MemberGrid.SelectedRows[0].Cells[9].Value.ToString();
            ContactTB.Text = MemberGrid.SelectedRows[0].Cells[11].Value.ToString();
            EmailTB.Text = MemberGrid.SelectedRows[0].Cells[10].Value.ToString();
        }

        private void TitleCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            TitleTB.Text = TitleCB.SelectedItem.ToString();
        }
        

        private void GeneratIDBtn_Click(object sender, EventArgs e)
        {
            AutoGeneratedCode();
        }

        private void SaveBtn1_Click(object sender, EventArgs e)
        {
            string MwmID = MemNoTB.Text;
            string Name = NameTB1.Text;
            string fee = FeesTB.Text;
            string charges = ChargesTB.Text;
            string Paid = PaidTB.Text;
            string Cashier = CashierTB.Text;
            int MemPlan = MembPlanCB.SelectedIndex;
            if (MwmID == "" || Name == "" || fee == "" || Cashier == "" || charges == "" || Paid == "" || MemPlan == -1)
            {
                MessageBox.Show("Please Fill the required fields", "Please Fill", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string com = "insert into [gymmembership] (refid,membershipid,membershipplan,name,vat,paiddate,expires,fees,charges,paid,balance,dueamount,collected)" +
                "values('"+RefIDTB.Text+"' ,'" + MemNoTB.Text + "','" + MembPlanCB.SelectedItem.ToString() + "','" + NameTB1.Text + "','"+VatTB.Text+"','"+PaidDateDTP.Value.ToShortDateString()+ "','"+ExpiresTB.Text+"','" + FeesTB.Text + "','"+ChargesTB.Text+"','" + PaidTB.Text + "','" +BalanceTB.Text+ "','"+DueTB.Text+"','" + CashierTB.Text + "')";
                Connection.Open();
                SqlCommand cmd = new SqlCommand(com, Connection);
                cmd.ExecuteNonQuery();
                Connection.Close();
                //MembPlanCB.SelectedIndex = -1;
                RefIDTB.Text = "";
                MemNoTB.Text = "";
                NameTB1.Text = "";
                VatTB.Text = "0";
                ExpiresTB.Text = "";
                ChargesTB.Text = "0";
                FeesTB.Text = "0";
                PaidTB.Text = "0";
                BalanceTB.Text = "0";
                DueTB.Text = "0";
                CashierTB.Text = "";
                Display2();
                Random_Referance();
                MembershipRenewals();
            }
        }

        private void DeleteBtn1_Click(object sender, EventArgs e)
        {
            string com = "delete from [gymmembership] where refid = '" + RefIDTB.Text + "' ";
            Connection.Open();
            SqlCommand cmd = new SqlCommand(com, Connection);
            cmd.ExecuteNonQuery();
            Connection.Close();
            //MembPlanCB.SelectedIndex = -1;
            RefIDTB.Text = "";
            MemNoTB.Text = "";
            NameTB1.Text = "";
            VatTB.Text = "0";
            ExpiresTB.Text = "";
            ChargesTB.Text = "0";
            FeesTB.Text = "0";
            PaidTB.Text = "0";
            BalanceTB.Text = "0";
            DueTB.Text = "0";
            CashierTB.Text = "";
            Display2();
            Random_Referance();
            MembershipRenewals();
        }

        private void ClearBtn1_Click(object sender, EventArgs e)
        {
            //MembPlanCB.SelectedIndex = -1;
            RefIDTB.Text = "";
            MemNoTB.Text = "";
            MembPlanCB.SelectedIndex = -1;
            NameTB1.Text = "";
            VatTB.Text = "0";
            ExpiresTB.Text = "";
            ChargesTB.Text = "0";
            FeesTB.Text = "0";
            PaidTB.Text = "0";
            BalanceTB.Text = "0";
            DueTB.Text = "0";
            CashierTB.Text = "";
        }

        private void UpdateBtn1_Click(object sender, EventArgs e)
        {
            string com = "update [gymmembership] set membershipplan = '" + MembPlanCB.SelectedItem.ToString() + "',name= '" + NameTB1.Text + "',vat= '"+VatTB.Text+ "',expires= '"+ExpiresTB.Text+"', fees ='" + FeesTB.Text + "',charges='"+ChargesTB.Text+"',paid= '" + PaidTB.Text + "',balance ='" + BalanceTB.Text+ "',dueamount= '"+DueTB.Text+"' where refid = '" + RefIDTB.Text + "' ";

            Connection.Open();
            SqlCommand cmd = new SqlCommand(com, Connection);
            cmd.ExecuteNonQuery();
            Connection.Close();
            MembPlanCB.SelectedIndex = -1;
            MemNoTB.Text = "";
            NameTB1.Text = "";
            FeesTB.Text = "";
            BalanceTB.Text = "";
            CashierTB.Text = "";
            Display2();
            Random_Referance();
            MembershipRenewals();
        }

        private void MemIDCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            MemNoTB.Text = MemIDCB.SelectedItem.ToString();
        }

        private void MemNoTB_TextChanged(object sender, EventArgs e)
        {
            
            string com = "select * from [gymmembers] where membershipid = '"+MemNoTB.Text+"' ";
            Connection.Open();
            SqlCommand sc = new SqlCommand(com, Connection);
            Connection.Close();
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NameTB1.Text = dt.Rows[i]["name"].ToString();
            }
        }

        private void MembPlanCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string com = "select * from [membershipplan] where membershipplan = '" + MembPlanCB.SelectedItem.ToString() + "' ";
                Connection.Open();
                SqlCommand sc = new SqlCommand(com, Connection);
                Connection.Close();
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    FeesTB.Text = dt.Rows[i]["price"].ToString();
                    DateTime PaidDate = PaidDateDTP.Value;
                    int Month = Int32.Parse(dt.Rows[i]["valid"].ToString());
                    ExpiresTB.Text = PaidDate.AddMonths(Month).ToShortDateString();

                }
            }
            catch
            {
                MessageBox.Show("Cleared Successfully..!");
                VatTB.Text = "0";
                ChargesTB.Text = "0";
                FeesTB.Text = "0";
                PaidTB.Text = "0";
                BalanceTB.Text = "0";
                DueTB.Text = "0";
            }
            
        }

        private void MembBtn_Click(object sender, EventArgs e)
        {
            GymMemberShipPlan GMP = new GymMemberShipPlan();
            GMP.Show();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void VatBtn_Click(object sender, EventArgs e)
        {
            string fee = FeesTB.Text;
            string VAT = VatTB.Text;

            int Ifee = Convert.ToInt32(fee);
            int IVAT = Convert.ToInt32(VAT);

            ChargesTB.Text = ((Ifee / 100) * IVAT+Ifee).ToString();
        }

        private void BalanceBtn_Click(object sender, EventArgs e)
        {
            string Charge = ChargesTB.Text;
            string Paid = PaidTB.Text;

            int Icharge = Int32.Parse(Charge);
            int Ipaid = Int32.Parse(Paid);

            BalanceTB.Text = (Ipaid - Icharge).ToString();
            if (Convert.ToInt32(BalanceTB.Text)  < 0)
            {
                DueTB.Text = (Icharge - Ipaid).ToString();
            }
            else if(Convert.ToInt32(BalanceTB.Text) >= 0 )
            {
                DueTB.Text = "0";
            }
        }

        private void EditBtn1_Click(object sender, EventArgs e)
        {
            RefIDTB.Text = PaymentsGrid.SelectedRows[0].Cells[0].Value.ToString();
            MemNoTB.Text = PaymentsGrid.SelectedRows[0].Cells[1].Value.ToString();
            MembPlanCB.SelectedItem = PaymentsGrid.SelectedRows[0].Cells[2].Value.ToString();
            NameTB1.Text = PaymentsGrid.SelectedRows[0].Cells[3].Value.ToString();
            VatTB.Text = PaymentsGrid.SelectedRows[0].Cells[4].Value.ToString();
            ExpiresTB.Text = PaymentsGrid.SelectedRows[0].Cells[6].Value.ToString();
            FeesTB.Text = PaymentsGrid.SelectedRows[0].Cells[7].Value.ToString();
            ChargesTB.Text = PaymentsGrid.SelectedRows[0].Cells[8].Value.ToString();
            PaidTB.Text = PaymentsGrid.SelectedRows[0].Cells[9].Value.ToString();
            BalanceTB.Text = PaymentsGrid.SelectedRows[0].Cells[10].Value.ToString();
            DueTB.Text = PaymentsGrid.SelectedRows[0].Cells[11].Value.ToString();
            CashierTB.Text = PaymentsGrid.SelectedRows[0].Cells[12].Value.ToString();
        }

        private void RegisterGymMembers_Activated(object sender, EventArgs e)
        {
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to export data to Excel sheet?", "EXPORT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                DataObject data = MemberGrid.GetClipboardContent();
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

        private void ExportBtn1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to export data to Excel sheet?", "EXPORT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                DataObject data = PaymentsGrid.GetClipboardContent();
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

        private void SearchBx1_TextChanged(object sender, EventArgs e)
        {
            string com = "select * from [gymmembers] where membershipid like'" + SearchBx1.Text + "%' or name like '" + SearchBx1.Text + "%' or idno like '" + SearchBx1.Text + "%' or passport like'" + SearchBx1.Text + "%' ";
            Connection.Open();
            SqlCommand sc = new SqlCommand(com, Connection);
            sc.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MemberGrid.DataSource = dt;

            Connection.Close();
        }

        private void SearchBx2_TextChanged(object sender, EventArgs e)
        {
            if(SearchBx2.Text == "")
            {
                Display2();
            }
            else
            {
                string com = "select * from [gymmembership] where membershipid like'" + SearchBx2.Text + "%' or name like '" + SearchBx2.Text + "%' or refid like '" + SearchBx2.Text + "%' ";
                Connection.Open();
                SqlCommand sc = new SqlCommand(com, Connection);
                sc.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                PaymentsGrid.DataSource = dt;

                Connection.Close();
            }
            
        }

        private void label23_Click(object sender, EventArgs e)
        {
            Seriel();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            Random_Referance();
        }

        private void BCodeBtn_Click(object sender, EventArgs e)
        {
            BarcodePage BP = new BarcodePage();
            BP.Show();
            
        }

        private void PaidDateDTP_ValueChanged(object sender, EventArgs e)
        {
            //Display2();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MembershipRenewals();
            //MembershipExpired();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            MembershipRenewals();
            //MembershipExpired();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Collections.Specialized;
using System.IO;
using System.Data.SqlClient;
using Dapper;

namespace Hotelier_Hotel_ManagementSystem
{
    public partial class OtpSms : Form
    {
		string rnumber;

		SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BinguTech\source\repos\Hotelier_Hotel_ManagementSystem\Hotelier_Hotel_ManagementSystem\DataBase\Hotelierbase.mdf;Integrated Security=True");
		//SqlConnection Connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\DataBase\Hotelierbase.mdf;Integrated Security = True");
		//SqlConnection Connection = new SqlConnection(SqlConnectionClass.ConnectionString);
		public OtpSms()
        {
            InitializeComponent();
        }

        private void SendOtpBTN_Click(object sender, EventArgs e)
        {
			/*String result;
			string apiKey = "NTQzODc2NGI3YTMzNGU0NDYzNTE1YTc5NTE0MTQyNjU";
			string numbers = NumberTB.Text; // in a comma seperated list
			string send = "BINGUTECH";
			string name = NameTB.Text;

			Random random = new Random();
			rnumber = (random.Next(100000, 999999)).ToString();

			string message = name + "this is your OTP Code.Use it before its expires." + rnumber;


			String url = "https://api.txtlocal.com/send/?apikey=" + apiKey + "&numbers=" + numbers + "&message=" + message + "&sender=" + sender;
			//refer to parameters to complete correct url string

			StreamWriter myWriter = null;
			HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);

			objRequest.Method = "POST";
			objRequest.ContentLength = Encoding.UTF8.GetByteCount(url);
			objRequest.ContentType = "application/x-www-form-urlencoded";
			try
			{
				myWriter = new StreamWriter(objRequest.GetRequestStream());
				myWriter.Write(url);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				myWriter.Close();
			}

			HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
			using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
			{
				result = sr.ReadToEnd();
				// Close and clean up the StreamReader
				sr.Close();
			}
			MessageBox.Show("OTP sent Successfully...!");*/

			try
			{
				string com = "select * from [users] where username ='"+NameTB.Text+"' and email='" + NumberTB.Text + "'  ";
				Connection.Open();
				SqlCommand sc = new SqlCommand(com,Connection);
				SqlDataAdapter sda = new SqlDataAdapter(sc);
				DataTable dt = new DataTable();
				sda.Fill(dt);
				Connection.Close();

				if(dt.Rows.Count == 1)
                {
					Random random = new Random();
					rnumber = (random.Next(100000, 999999)).ToString();

					MailMessage msg = new MailMessage();
					msg.From = new MailAddress("hoteliermanagements@gmail.com");
					msg.To.Add(NumberTB.Text);
					msg.Subject = "HOTELIER PASSWORD RESET CODE";
					msg.Body = NameTB.Text + " your OTP code is " + rnumber;

					SmtpClient smt = new SmtpClient();
					smt.Host = "smtp.gmail.com";
					System.Net.NetworkCredential ntcd = new NetworkCredential();
					ntcd.UserName = "hoteliermanagements@gmail.com";
					ntcd.Password = "hotelier22";
					smt.Credentials = ntcd;
					smt.EnableSsl = true;
					smt.Port = 587;
					smt.Send(msg);

					MessageBox.Show("Your code is successfully sent to the email "+NumberTB.Text , "SUCCESSFULL", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
                else
                {
					MessageBox.Show("Your details not valid", "INVALID", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}


				

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

        private void VerifyBtn_Click(object sender, EventArgs e)
        {
			if(OtpTB.Text == rnumber)
            {
				this.Hide();
				PasswordReset pr = new PasswordReset(NameTB.Text);
				pr.Show();
				
			}
            else
            {
				MessageBox.Show("Your OTP is wrong.","WRONG", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }

        private void OtpSms_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Collections.Specialized;
using System.IO;


namespace Hotelier_Hotel_ManagementSystem
{
    class OtpSender
    {
		public string sendSMS()
		{
			String result;
			string apiKey = "NTQzODc2NGI3YTMzNGU0NDYzNTE1YTc5NTE0MTQyNjU=";
			string numbers = ""; // in a comma seperated list
			string name = "BINGUTECH";
			string message = name;
			string sender = "BINGUTECH";
			

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
			catch (Exception e)
			{
				return e.Message;
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
			return result;
		}
	}
}

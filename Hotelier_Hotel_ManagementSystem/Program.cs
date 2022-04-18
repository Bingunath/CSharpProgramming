using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotelier_Hotel_ManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainPage());
            //Application.Run(new Gym());
            //Application.Run(new RegisterGymMembers());
            //Application.Run(new PoolUsage());
            //Application.Run(new GuestProfiles());
            //Application.Run(new CreateReservation());
            //Application.Run(new InHouseGuests());
            //Application.Run(new BarcodePage());
            //Application.Run(new LoadingPage());
            //Application.Run(new LoginPage());
            //Application.Run(new Users());
            //Application.Run(new LoginPage2());
            Application.Run(new OtpSms());

        }
    }
}

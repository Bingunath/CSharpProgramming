using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Managment_System
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
            //Application.Run(new BookRegistration());
            //Application.Run(new Library());
            //Application.Run(new LibraryHomeMenu());
            //Application.Run(new members());
            //Application.Run(new LoginPage());
            //Application.Run(new NewUser());
            //Application.Run(new UsersForm());
            //Application.Run(new FineCalculator());
            Application.Run(new WelcomePage());
        }
    }
}

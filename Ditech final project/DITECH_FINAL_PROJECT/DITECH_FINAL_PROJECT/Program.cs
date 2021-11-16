using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DITECH_FINAL_PROJECT
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
            Application.SetCompatibleTextRenderingDefault(true);
            //Application.Run(new Student_Registration());
            //Application.Run(new studentRegistrationForm()) ;
            Application.Run(new loginpage());
            //Application.Run(new MainMenu());
            //Application.Run(new ManageUsers());
            //Application.Run(new ManageCourses());
        }
    }
}

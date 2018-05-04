using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
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
            //Application.Run(new MainMenu());
            //Application.Run(new Signin());
            //Application.Run(new Login());
            //Application.Run(new Option_cl());
            //Application.Run(new HotelSearching());
            //Application.Run(new RoomSetting());
            //Application.Run(new Option_sv());
            Application.Run(new InvoiceAdding());
            //Application.Run(new InvoiceSearching());
            //Application.Run(new Report());
            // Application.Run(new Statistic());


            //Application.Run(new InvoiceDetail());
        }
    }
}

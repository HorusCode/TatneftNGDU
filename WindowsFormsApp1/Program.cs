using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Micron;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MicronConfig config = new MicronConfig()
            {
                DatabaseName = "ngdu",
                Host = "localhost",
                User = "root",
                Password = "",
                Port = "3306",
            };

            MicronDbContext.AddConnectionSetup(config);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Auth());
        }

        
    }
}

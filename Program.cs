using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace física_EH
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Menú());

        }
    }
}
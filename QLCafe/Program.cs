using QLCafe.Util;
using QLCafe.View;

namespace QLCafe
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            DataHelper.server = "localhost";
            DataHelper.data = "demo";
            DataHelper.uid = "sa";
            DataHelper.password = "Abcdef@123";

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmMenu());
        }
    }
}
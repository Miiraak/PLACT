using System.Diagnostics;
using System.Security.Principal;

namespace PLACT
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!IsAdministrator())
            {
                RelaunchAsAdmin();
            }
            else
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new MainForm());
            }
        }

        /// <summary>
        /// This method checks if the application is running as an administrator
        /// </summary>
        /// <returns></returns>
        private static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        /// <summary>
        /// This method relaunches the application as an administrator
        /// </summary>
        private static void RelaunchAsAdmin()
        {
            ProcessStartInfo proc = new ProcessStartInfo
            {
                UseShellExecute = true,
                WorkingDirectory = Environment.CurrentDirectory,
                FileName = Application.ExecutablePath,
                Verb = "runas"
            };

            try
            {
                Process.Start(proc);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Échec lors de la tentative de démarrage en mode administrateur : " + ex.Message);
            }

            Application.Exit();
        }
    }
}
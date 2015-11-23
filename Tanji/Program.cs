using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Security.Principal;

using Sulakore.Communication;

using Eavesdrop;

namespace Tanji
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            var windowsPrincipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            if (!windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator))
            {
                using (var tanjiProcess = new Process())
                {
                    tanjiProcess.StartInfo.Verb = "runas";
                    tanjiProcess.StartInfo.FileName = "Tanji.exe";
                    tanjiProcess.StartInfo.UseShellExecute = true;
                    tanjiProcess.Start();
                }
            }
            else
            {
                AppDomain.CurrentDomain.UnhandledException +=
                    UnhandledException;

                Eavesdropper.Terminate();
                HConnection.RestoreHosts();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainFrm());
            }
        }
        static void UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var exception = (Exception)e.ExceptionObject;
            MessageBox.Show($"Message: {exception.Message}\r\n\r\n{exception.StackTrace.Trim()}",
                "Tanji ~ Critical Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (e.IsTerminating)
            {
                Eavesdropper.Terminate();
                HConnection.RestoreHosts();
            }
        }
    }
}
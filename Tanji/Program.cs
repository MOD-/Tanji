/*
    GitHub(Source): https://GitHub.com/ArachisH/Tanji

    This file is part of Tanji.
    Copyright (C) 2015 ArachisH
    
    This code is licensed under the GNU General Public License.
    See License.txt in the project root for license information.
*/

using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Security.Principal;

using Eavesdrop;

using Sulakore.Communication;

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
                AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

                Eavesdropper.Terminate();
                HConnection.RestoreHosts();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainFrm());
            }
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            if (e.IsTerminating)
            {
                var exception = (Exception)e.ExceptionObject;

                MessageBox.Show($"Message: {exception.Message}\r\n\r\n{exception.StackTrace.Trim()}\r\n\r\nShutting down...",
                    "Tanji ~ Critical Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Eavesdropper.Terminate();
                HConnection.RestoreHosts();
            }
        }
    }
}
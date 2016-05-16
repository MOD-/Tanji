using System;
using System.Diagnostics;
using System.Windows.Forms;

using Eavesdrop;

namespace Tanji
{
    public static class Program
    {
        [STAThread]
        private static void Main()
        {
            AppDomain.CurrentDomain
                .UnhandledException += UnhandledException;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var watch = new Stopwatch();
            watch.Start();

            var ui = new MainFrm();
            watch.Stop();

            Console.WriteLine("Startup Time: " + watch.Elapsed);
            Application.Run(ui);
        }
        private static void UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var exception = (Exception)e.ExceptionObject;
            MessageBox.Show($"Message: {exception.Message}\r\n\r\n{exception.StackTrace.Trim()}",
                "Tanji ~ Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (e.IsTerminating)
                Eavesdropper.Terminate();
        }
    }
}
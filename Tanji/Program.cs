/* Copyright

    GitHub(Source): https://GitHub.com/ArachisH/Tanji

    Habbo Hotel Packet(Logger/Manipulator)
    Copyright (C) 2015 ArachisH

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation; either version 2 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License along
    with this program; if not, write to the Free Software Foundation, Inc.,
    51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.

    See License.txt in the project root for license information.
*/

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
            Eavesdropper.Terminate();
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
                HConnection.RestoreHosts();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainFrm());
            }
        }
    }
}
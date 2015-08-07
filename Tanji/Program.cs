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

// Not a test.
using System;
using System.Windows.Forms;
using System.Security.Principal;

using Eavesdrop;

using Sulakore.Communication;

namespace Tanji
{
    static class Program
    {
        private const string MUST_RUN_AS_ADMIN
            = "Tanji must be ran with administrative privileges.\r\n\r\nIf you are not being prompted to run as administrator, make sure your UAC settings are properly adjusted.";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var windowsPrincipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            if (!windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator))
            {
                MessageBox.Show(MUST_RUN_AS_ADMIN,
                    "Tanji ~ Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Eavesdropper.Terminate();
            HConnection.RestoreHosts();
            Application.Run(new MainFrm());
        }
    }
}
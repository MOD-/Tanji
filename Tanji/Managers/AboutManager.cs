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

namespace Tanji.Managers
{
    public class AboutManager
    {
        public MainFrm MainUI { get; }

        public AboutManager(MainFrm main, TabPage aboutTab)
        {
            MainUI = main;

            aboutTab.Controls["ATTanjiBtn"].Click += ATTanjiBtn_Click;
            aboutTab.Controls["ATMakecertBtn"].Click += ATMakecertBtn_Click;
            aboutTab.Controls["ATSulakoreBtn"].Click += ATSulakoreBtn_Click;
            aboutTab.Controls["ATEavesdropBtn"].Click += ATEavesdropBtn_Click;
            aboutTab.Controls["ATLogoSourceBtn"].Click += ATLogoSourcetBtn_Click;
            aboutTab.Controls["ATFlashInspectBtn"].Click += ATFlashInspectBtn_Click;

            aboutTab.Controls["ATDarkboxBtn"].Click += ATDarkboxBtn_Click;
            aboutTab.Controls["ATKekomundoBtn"].Click += ATKekomundoBtn_Click;
            aboutTab.Controls["ATDonationsBtn"].Click += ATDonationsBtn_Click;

            aboutTab.Controls["ATGithubBtn"].Click += ATGithubBtn_Click;
            aboutTab.Controls["ATTwitterBtn"].Click += ATTwitterBtn_Click;

            aboutTab.Controls["ATVersionLbl"].Text = "v" + MainUI.UpdateUI.LocalVersion;
        }

        private void ATGithubBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/ArachisH");
        }
        private void ATTwitterBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://Twitter.com/ArachisH");
        }

        private void ATDarkboxBtn_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.Darkbox.nl");
        }
        private void ATKekomundoBtn_Click(object sender, EventArgs e)
        {
            Process.Start("http://kekomundo.com/foro/index.php?c=3");
        }
        private void ATDonationsBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://pledgie.com/campaigns/30163");
        }

        private void ATTanjiBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://GitHub.com/ArachisH/Tanji");
        }
        private void ATMakecertBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://msdn.microsoft.com/en-us/library/bfsktky3(v=vs.110).aspx");
        }
        private void ATSulakoreBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/ArachisH/Sulakore");
        }
        private void ATEavesdropBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://GitHub.com/ArachisH/Eavesdrop");
        }
        private void ATLogoSourcetBtn_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.iconarchive.com/show/fs-icons-by-franksouza183/Apps-clementine-icon.html");
        }
        private void ATFlashInspectBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://GitHub.com/ArachisH/FlashInspect");
        }
    }
}
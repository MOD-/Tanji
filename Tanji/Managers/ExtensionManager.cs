﻿/* Copyright

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

using Sulakore.Extensions;
using Sulakore.Communication;

namespace Tanji.Managers
{
    public class ExtensionManager : Contractor
    {
        public MainFrm MainUI { get; }

        public ExtensionManager(MainFrm main) :
            base(main.Connection)
        {
            MainUI = main;
            MainUI.Connection.DataIncoming += DataIncoming;
            MainUI.Connection.DataOutgoing += DataOutgoing;
        }

        private void DataIncoming(object sender, InterceptedEventArgs e) => HandleIncoming(e);
        private void DataOutgoing(object sender, InterceptedEventArgs e) => HandleOutgoing(e);
    }
}
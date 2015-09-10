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
using System.Net;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;

using Tanji.Dialogs;
using Tanji.Converters;

namespace Tanji.Managers
{
    public class ConnectionManager : INotifyPropertyChanged
    {
        private readonly Action<PropertyChangedEventArgs> _onPropertyChanged;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaiseOnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (ConnectUI.InvokeRequired) { ConnectUI.Invoke(_onPropertyChanged, e); }
            else PropertyChanged?.Invoke(this, e);
        }

        public ConnectFrm ConnectUI { get; }

        private string _gameHost = string.Empty;
        public string GameHost
        {
            get { return _gameHost; }
            set
            {
                _gameHost = value;
                RaiseOnPropertyChanged(nameof(GameHost));
            }
        }

        private ushort[] _gamePorts = new ushort[0];
        [TypeConverter(typeof(GamePortsConverter))]
        public ushort[] GamePorts
        {
            get { return _gamePorts; }
            set
            {
                _gamePorts = value.Distinct().ToArray();
                RaiseOnPropertyChanged(nameof(GamePorts));
            }
        }

        private ushort _proxyPort = 8080;
        public ushort ProxyPort
        {
            get { return _proxyPort; }
            set
            {
                _proxyPort = value;
                RaiseOnPropertyChanged(nameof(ProxyPort));
            }
        }

        private bool _isModifyingFlashVariables = false;
        public bool IsModifyingFlashVariables
        {
            get { return _isModifyingFlashVariables; }
            set
            {
                _isModifyingFlashVariables = value;
                RaiseOnPropertyChanged(nameof(IsModifyingFlashVariables));
            }
        }

        private IWebProxy _remoteProxy;
        [TypeConverter(typeof(RemoteProxyConverter))]
        public IWebProxy RemoteProxy
        {
            get { return _remoteProxy; }
            set
            {
                _remoteProxy = value;
                RaiseOnPropertyChanged(nameof(RemoteProxy));
            }
        }

        private string _publicModulus;
        public string PublicModulus
        {
            get { return _publicModulus; }
            set
            {
                _publicModulus = value;
                RaiseOnPropertyChanged(nameof(PublicModulus));
            }
        }

        private int _publicExponent;
        public int PublicExponent
        {
            get { return _publicExponent; }
            set
            {
                _publicExponent = value;
                RaiseOnPropertyChanged(nameof(PublicExponent));
            }
        }

        private string _privateExponent;
        public string PrivateExponent
        {
            get { return _privateExponent; }
            set
            {
                _privateExponent = value;
                RaiseOnPropertyChanged(nameof(PrivateExponent));
            }
        }

        public ConnectionManager(ConnectFrm connect)
        {
            ConnectUI = connect;
            _onPropertyChanged = OnPropertyChanged;

            ConnectUI.CTGameHostTxt.DataBindings.Add("Text", this,
                nameof(GameHost), false, DataSourceUpdateMode.OnPropertyChanged);

            ConnectUI.CTGamePortsTxt.DataBindings.Add("Text", this,
                nameof(GamePorts), true, DataSourceUpdateMode.OnPropertyChanged);

            ConnectUI.CTRemoteProxyTxt.DataBindings.Add("Text", this,
                nameof(RemoteProxy), true, DataSourceUpdateMode.OnPropertyChanged);

            ConnectUI.HTPublicModulusTxt.DataBindings.Add("Text", this,
                nameof(PublicModulus), false, DataSourceUpdateMode.OnPropertyChanged);

            ConnectUI.HTPublicExponentTxt.DataBindings.Add("Text", this,
                nameof(PublicExponent), false, DataSourceUpdateMode.OnPropertyChanged);

            ConnectUI.HTPrivateExponentTxt.DataBindings.Add("Text", this,
                nameof(PrivateExponent), false, DataSourceUpdateMode.OnPropertyChanged);

            ConnectUI.CTProxyPortTxt.DataBindings.Add("Value", this,
                nameof(ProxyPort), false, DataSourceUpdateMode.OnPropertyChanged);

            ConnectUI.CTModifyFlashVariablesChckbx.DataBindings.Add("Checked", this,
                nameof(IsModifyingFlashVariables), false, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
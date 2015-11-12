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
        }
    }
}
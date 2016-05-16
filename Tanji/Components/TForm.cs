using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

using Tanji.Properties;

namespace Tanji.Components
{
    public class TForm : Form, INotifyPropertyChanged
    {
        public TForm()
        {
            BackColor = Color.White;
            Icon = Resources.Tanji_128;
            FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        protected void RaiseOnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }
        protected void Bind(Control control, string propertyName, string dataMember)
        {
            control.DataBindings.Add(propertyName, this,
                dataMember, false, DataSourceUpdateMode.OnPropertyChanged);
        }

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
                Invoke(handler, this, e);
        }
        #endregion
    }
}
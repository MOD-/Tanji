using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

using Tanji.Manipulators;

namespace Tanji.Components.Pages
{
    [DesignerCategory("Code")]
    public class PageControl : UserControl, INotifyPropertyChanged
    {
        [Browsable(false)]
        public IMaster Master { get; private set; }

        public PageControl()
        {
            BackColor = Color.White;
        }

        public virtual void AssignMaster(IMaster master)
        {
            Master = master;
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
                FindForm()?.Invoke(handler, this, e);
        }
        #endregion
    }
}
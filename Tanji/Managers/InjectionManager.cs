using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanji.Managers
{
    public class InjectionManager
    {
        public MainFrm MainUI { get; }

        public InjectionManager(MainFrm main)
        {
            MainUI = main;

            MainUI.ISStopAllBtn.Click += ISStopAllBtn_Click;

            MainUI.ISDestinationTxt.SelectedIndex = 1;
        }

        private void ISStopAllBtn_Click(object sender, EventArgs e)
        {
           // throw new NotImplementedException();
        }
    }
}
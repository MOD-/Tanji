using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanji.Managers
{
    public class UpdateManager
    {
        public MainFrm MainUI { get; }

        public UpdateManager(MainFrm main)
        {
            MainUI = main;
        }
    }
}
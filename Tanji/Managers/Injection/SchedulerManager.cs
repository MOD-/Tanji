using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanji.Managers.Injection
{
    public class SchedulerManager
    {
        public MainFrm MainUI { get; }

        public SchedulerManager(MainFrm main)
        {
            MainUI = main;
        }
    }
}
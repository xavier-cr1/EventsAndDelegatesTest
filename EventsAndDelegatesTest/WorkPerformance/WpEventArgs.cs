using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegatesTest.WorkPerformance
{
    public class WpEventArgs : EventArgs
    {
        public int Hours { get; set; }
        public WorkType WorkType { get; set; }

        public WpEventArgs(int hours, WorkType workType)
        {
            Hours = hours;
            WorkType = workType;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegatesTest
{
    public static class WorkPerformanceDelegate
    {
        public delegate void WorkPerformanceHandler(int hours, WorkType workType);
    }
}

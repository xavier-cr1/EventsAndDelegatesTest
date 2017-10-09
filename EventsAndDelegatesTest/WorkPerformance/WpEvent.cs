using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventsAndDelegatesTest.WorkPerformance;

namespace EventsAndDelegatesTest
{
    public class WpEvent
    {
        public event EventHandler WorkEvent;
        public event EventHandler<WpEventArgs> WorkPerformanceHandler;

        public void DoWork(int hours, WorkType workType)
        {
            for(int i = 1; i<=hours; i++)
            {
                System.Threading.Thread.Sleep(1000);
                OnWorkPerformed(i, workType);
            }
            OnWorkEventCompleted();
        }

        protected virtual void OnWorkPerformed(int hours, WorkType workType)
        {
            if (WorkPerformanceHandler is EventHandler<WpEventArgs> delegateWp)
            {
                delegateWp(this, new WpEventArgs(hours, workType));
            }
        }

        protected virtual void OnWorkEventCompleted()
        {
            if (WorkEvent is EventHandler delegateWe)
            {
                delegateWe(this, EventArgs.Empty);
            }
        }
    }
}

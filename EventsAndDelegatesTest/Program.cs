using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventsAndDelegatesTest.WorkPerformance;


namespace EventsAndDelegatesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //DELEGATE
            //var delegate1 = new WpDelegate.WorkPerformanceHandler(WorkPerformance1);
            //delegate1(5, WorkType.HeroesOfTheStorm);

            //EVENT
            var wpEventTest = new WpEvent();
            wpEventTest.WorkPerformanceHandler += new EventHandler<WpEventArgs>(WpEvent_OnWorkPerformed);
            wpEventTest.WorkEvent += new EventHandler(WpEvent_OnWorkCompleted);

            wpEventTest.DoWork(8, WorkType.HeroesOfTheStorm);
            Console.Read();
        }

        //DELEGATE signature and args -> defined delegate
        //static int WorkPerformance1(int hours, WorkType workType)
        //{
        //    Console.WriteLine($"Work Performance 1 called: + {hours}");
        //    return 0;
        //}

        //EVENT
        static void WpEvent_OnWorkPerformed(object sender, WpEventArgs e)
        {
            //callback
            Console.WriteLine(e.Hours + " " + e.WorkType);
        }

        static void WpEvent_OnWorkCompleted(object sender, EventArgs e)
        {
            //callback
            Console.WriteLine("Job done.");
        }
    }
}

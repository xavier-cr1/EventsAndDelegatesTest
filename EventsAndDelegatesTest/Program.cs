using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EventsAndDelegatesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var delegate1 = new WorkPerformanceDelegate.WorkPerformanceHandler(WorkPerformance1);
            delegate1(5, WorkType.HeroesOfTheStorm);

            Console.Read();
        }

        static void WorkPerformance1(int hours, WorkType workType)
        {
            Console.WriteLine($"Performance 1 called: + {hours}");
        }
    }
}

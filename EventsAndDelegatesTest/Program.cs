using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventsAndDelegatesTest.WorkPerformance;
using EventsAndDelegatesTest.Lambdas;

namespace EventsAndDelegatesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //DELEGATE
            var delegate1 = new WpDelegate.WorkPerformanceHandler(WorkPerformance1);
            delegate1(5, WorkType.HeroesOfTheStorm);

            //EVENT
            var wpEventTest = new WpEvent();
            wpEventTest.WorkPerformanceHandler += (s, e) => Console.WriteLine(e.Hours.ToString(), e.WorkType);
            wpEventTest.WorkEvent += new EventHandler(WpEvent_OnWorkCompleted);

            wpEventTest.DoWork(8, WorkType.HeroesOfTheStorm);
            Console.Read();

            //LAMBDA
            var wpLambdaTest = new WpEvent();
            wpLambdaTest.WorkPerformanceHandler += (s, e) => Console.WriteLine(e.Hours + " " + e.WorkType);
            wpLambdaTest.WorkEvent += (s, e) => Console.WriteLine("Job done.");

            wpLambdaTest.DoWork(8, WorkType.HeroesOfTheStorm);
            Console.Read();

            //ACTIONS
            Action<int, int> testAction = (x, y) => Console.WriteLine(x + y);
            var actions = new Actions();
            actions.DoAction(3, 4, testAction);
            Console.Read();

            //FUNC
            Func<int, int, int> funcTest = (x, y) => x + y;
            var funcs = new Funcs();
            funcs.DoFunc(3, 4, funcTest);
            Console.Read();
        }

        //DELEGATE signature and args -> defined delegate
        static int WorkPerformance1(int hours, WorkType workType)
        {
            Console.WriteLine($"Work Performance 1 called: + {hours}");
            return 0;
        }

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

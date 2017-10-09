using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegatesTest.Lambdas
{
    public class Actions
    {
        public void DoAction(int x, int y, Action<int, int> action)
        {
            action(x, y);
            Console.WriteLine("Action completed");
        }
    }
}

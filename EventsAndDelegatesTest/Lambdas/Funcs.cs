using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegatesTest.Lambdas
{
    public class Funcs
    {
        public void DoFunc(int x, int y, Func<int, int, int> func)
        {
            var funcResult = func(x, y);
            Console.WriteLine(funcResult);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        private delegate int OnjSum(int i, int j);
        public static void Main(string[] args)
        {
            Func<int, int, int> myMethod = Sum;
            Console.WriteLine("{0}", myMethod(10, 30));

        }
       static int Sum(int i, int j)
        {
            return (i + j);
        }

    }
}

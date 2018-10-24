using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ParamsTest
    {
        static void Main(string[] args)
        {
            ParamsTest p = new ParamsTest();
            Console.WriteLine(p.Sum(j : 1, i : 2));
            Console.WriteLine(p.Sum(j : 10));
            Console.WriteLine(p.Sum());
        }

         int Sum(int i=0 , int j=0)
        {
            Console.WriteLine("i={0}, j={1}", i, j);
            return i+j;
        }
    }
}

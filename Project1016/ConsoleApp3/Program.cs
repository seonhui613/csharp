using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        private int m = 88, n = 99;

        Program(int m = 0, int n = 0)
        {
            this.m = m;
            this.n = n;
        }
        static int Sum(int i = 0, int j = 0)
        {
            return i + j;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Sum(1, 2));
            Console.WriteLine(Sum(j: 7));
            Console.WriteLine(Sum());

            Program p1 = new Program();
            Console.WriteLine("m={0}, n={1}", p1.m, p1.n);

            Program p2 = new Program(1, 2);
            Console.WriteLine("m={0}, n={1}", p2.m, p2.n);








        }
    }

    class Tester
    {
       static int Minus(int i =0, int j = 0)
        {
            return i - j;
        }
    }


}

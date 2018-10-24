using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class AsTest
    {
        class Emp
        {
            public override string ToString()
            {
                return "Emp";
            }
        }
        class Programmer : Emp { }
        class Program
        {
            static void Main(string[] args)
            {
                Programmer p = new Programmer();
                Emp e = p as Emp;
                if (e != null)
                    System.Console.WriteLine(e.ToString());
            }
        }
    }
}
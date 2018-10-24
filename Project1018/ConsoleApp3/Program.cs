using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Program s = new Program();
            Action<int,int > myMethod =s.Sum;
            myMethod(10, 30);

        }
        void Sum( int i , int j)
        {
            Console.WriteLine(i + j);
        }
     
    }
}

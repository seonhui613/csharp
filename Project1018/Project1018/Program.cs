#define SOUNDCARD
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1018
{
    class Program
    {
        [Conditional("SOUNDCARD")]
        static void print()
        {
            Console.WriteLine("도레미..");
        }
        static void Main(string[] args)
        {
            print();
        }
    }
}

﻿using System;
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
            Action<int, int> myMethod = delegate (int i, int j)
            {
                Console.WriteLine(i + j);
            };
            myMethod(10, 30);

        }


    }
}

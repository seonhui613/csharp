﻿// 4. 아래와 같이 출력하는 프로그램을 작성하세요.
//  *

//  ***

//  *****

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i =1; i<=5; i=i+2)
            {
                for (int j = 0; j <i ; j++)
                {
                    
                    Console.Write("*");
                }
                Console.WriteLine();
            }
           
        }
    }
}

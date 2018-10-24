using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            int num = int.Parse(str) ;
            if (int.TryParse(str, out num)) Console.WriteLine("OK!");
            int sum = 0;


            /////////////////////////////////////////// while
            /*
            int i = 0;
            while (i++ < num)
            {
                if (i % 2 == 0)

                    sum += i;

            } 
            Console.WriteLine("while문 {0}까지의 짝수의 합은 : {1}", num, sum);
            */

            //////////////////////////////////////do while
            /*
            sum = 0; int i= 0;
            do
            {
                if (i % 2 == 0)

                    sum += i;
            } while (i++ < num);
                Console.WriteLine(" do-while문 {0}까지의 짝수의 합은 : {1}", num, sum);
            */


            ///////////////////for
            sum = 0; 
            for(int i=0; i<=num; i++)
            {
                if (i % 2 == 0)

                    sum += i;
            }
            Console.WriteLine(" for문 {0}까지의 짝수의 합은 : {1}", num, sum);
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1015
{
    class Program
    {
        static void Main(string[] args)
        {
            

            for (int i=1; i<=10; i++)
            {
                if (i % 2 == 0)
                    System.Console.WriteLine(i);
            }


            System.Console.WriteLine("------------------------2-----------------");

            string str = Console.ReadLine();
            int num = int.Parse(str);
            int sum = 0;
            System.Console.Write("10까지의 숫자: ");
            for (int i=1; i<=num; i++)
            {
              
                System.Console.Write(i);
                
                sum += i;
            }
            System.Console.WriteLine("\n");
            System.Console.WriteLine("10까지의 숫자합은:{0}", sum);

            System.Console.WriteLine("------------------------3-----------------");

            System.Console.WriteLine("Input the 10 numbers :");
            int sum2 = 0;
            float avg = 0;
            for (int i=1; i<=10; i++)
            {
                System.Console.Write("숫자-{0} :  ", i);
                string str2 = Console.ReadLine();
                int num2 = int.Parse(str2);
               

                sum2 += num2;
                avg = sum2 / 10;
            }
            System.Console.WriteLine("합:{0}", sum);
            System.Console.WriteLine("평균:{0}", avg);

            System.Console.WriteLine("----------------------------4----------------------");
            System.Console.Write("출력을 원하는 구구단 단수:");
            string str3 = Console.ReadLine();
            int num3 = int.Parse(str3);
          
                for(int j=2; j<=9; j++)
                {
                for (int i = 1; i <= num3; i++)
                {
                    System.Console.Write(i + "x" + j + "=" + (i * j)+",");
                }
                System.Console.WriteLine();
            }

        }
    }
}

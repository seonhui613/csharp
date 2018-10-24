using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        delegate int sum (int i); 
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력하세요 : ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} 까지의 합 : {1} ",num,GetSum(num));

            sum s = (i) =>
            {
                int resultSum = 0;
                for (int j = 0; j <= i; j++)
                    resultSum += j;
                return resultSum;
            };
            Console.WriteLine("{0} 까지의 합 : {1}",num, s(num));


            sum s1 = GetSum;
            Console.WriteLine( s1(num));

            
           
        }

        static int GetSum(int i)
        {
            int result = 0;
            for( int j=1; j<=i; j++)
            {
                result += j;
            }
            return result;
        }

    }
}

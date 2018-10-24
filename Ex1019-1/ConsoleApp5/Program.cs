// 6. 사용자로 부터 하나의 수를 입력받고 그수까지의 소수의 합을 구하는 프로그램을 작성하세요.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" 하나의 수를 입력하세요 : ");

            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 2; i <= num; i++)
            {
                bool flag = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {          //i를 j로 나누었을 때, 나누어 떨어지면 소수가 아님
                        flag = false;
                    }
                }
                if (flag == true)
                {
                    Console.WriteLine(i);
                    sum += i;
                    
                }
                
            }
            Console.WriteLine("============");
            Console.WriteLine("{0} 까지의 소수의 합 : {1}", num,sum);
        }
    }
}


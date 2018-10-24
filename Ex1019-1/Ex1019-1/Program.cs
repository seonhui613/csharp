// 1. 콤마로 구분해서 여러 숫자를 입력받아 합을 구하는 프로그램을 작성하세요.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1019_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 입력하세요. : ex) 1,8,4,9,6 ");
            string str = Console.ReadLine();
            string[] sArr = str.Split(new char[] { ','});
            int[] arr = Array.ConvertAll(sArr, s => int.Parse(s));

            int sum = 0;

            foreach(int i in arr)
            {
                sum += i;
               
            }
            Console.WriteLine("합 = {0}",sum);
        }
    }
}

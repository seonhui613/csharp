using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1016._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr =  new int[10];
            Console.WriteLine("정렬하고싶은 숫자 4개를 입력하세요.");
            
          
            for (int a = 0; a < 5; a++)
            {
                arr[a] = Console.Read();
                Console.WriteLine(arr[a]);
            }



            int i = 1;
            int j = 0;
            int temp = 0;
            for (i = 1; i < arr.Length; i++)
            {
                for  (j = 0; j < i; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            for (int k = 0; k < arr.Length; k++)
            {
                Console.WriteLine(arr[k]);
            }
        

        }
    }
}

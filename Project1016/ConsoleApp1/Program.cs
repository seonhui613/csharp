using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            int temp = 0;
      

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 1; i < arr.Length; j++)
                {
                    if (arr[i] >= arr[j])
                    {
                        arr[j] = temp;
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }


        }
    }
}

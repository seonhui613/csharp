using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
   class Test<T>
    {
         public T Sum(T i, T j)
        {
            return (dynamic)i + (dynamic)j;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test <int>t = new Test<int>();
            int i = 1; int j = 2;
            Console.WriteLine("{0} + {1} = {2}", i, j, t.Sum(i, j));

            Test<float> at = new Test<float>();
            float f = 1.0f; float k = 2.0f;
            Console.WriteLine("{0} + {1} = {2}", f, k, at.Sum(f, k));
                
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1016
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int mok = int.Parse(num);
            string na = "";
            int i;

            if (mok>0)
            {
                for (i = mok; i > 1; i=i/2 )
                {
                    na = (i % 2) + na;
                   
                }
             Console.WriteLine( i+ na);
             }
        }
    }
}

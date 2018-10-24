using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    enum Day1
    {
        Mon, Thes, Wednes, Thurs, Fri, Satur, Sun
    }
    enum Day2
    {
        Mon = 11, Thes, Wednes, Thurs, Fri, Satur, Sun = Mon +100
    }

    public class  EnumTest
        {
        static void Main(string[] args)
        {
            Day1 whatDay = Day1.Thes;
            Console.WriteLine("{0}", whatDay);
            Console.WriteLine("{0}", (int)whatDay);

            whatDay = (Day1)6;
            Console.WriteLine("{0}", whatDay);

            Day2 whatDay2 = Day2.Mon;
            Console.WriteLine("{0}", whatDay2);
            Console.WriteLine("{0}", (byte)whatDay2);

            whatDay2 = (Day2)111;
            Console.WriteLine("{0}", whatDay2);
        }
    }
}

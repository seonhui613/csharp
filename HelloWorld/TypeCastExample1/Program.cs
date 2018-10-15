using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCastExample1
{
    class TypeCastExample1
    {
        public static void Main()
        {
            short a = 10;    //                             0000 0000 0000 1010
            int b = a;        // 0000 0000 0000 0000 0000 0000 0000 1010
            int c = 50000;  // 0000 0000 0000 0000 1100 0011 0101 0000
            try
            {
                short d = checked( (short) c );     //                      1100 0011 0101 0000
            } catch (Exception e) {
                //Console.WriteLine("예외 : {0}", e.StackTrace);  //Short :-15536  (맨첫 글자가 1이니까 음수.
                Console.WriteLine("예외 : {0}" + e.StackTrace); 
            }
        }
    }
}

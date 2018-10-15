using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCastExample2
{
    class TypeCastExample2
    {
        public static void Main(string[] args)
        {
            int iSize = sizeof(int);
            Console.WriteLine("int형 바이트 길이 :{0}", iSize); // int형 바이트 길이 :4

            Type myType1 = typeof(int);
            Console.WriteLine("typeof(int) :{0}", myType1); // typeof(int) :System.Int32

            int i = 10;
            Type myType2 = i.GetType();
            Console.WriteLine("i.GetType() :{0}", myType2); // i.GetType() :System.Int32

            int j = 90;
            Console.WriteLine("Size of j :{0}", Marshal.SizeOf(j)); // Size of j :4
        }
    }
}

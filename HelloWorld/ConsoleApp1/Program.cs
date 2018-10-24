using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class RefType
    {
        public object value;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = a;

            Console.WriteLine("a:{0}",a); //1
            Console.WriteLine("b:{0}",b); //1

            b = 2;
            Console.WriteLine("a:{0}",a);//1
            Console.WriteLine("b:{0}",b);//2

            Console.WriteLine("-------------");

            RefType c = new RefType();
            RefType d = new RefType();

            c.value = 1;
            Console.WriteLine("c:{0}",c.value);
         
            d.value = 2;
            Console.WriteLine("c:{0}",c.value);
            Console.WriteLine("d:{0}",d.value);

            Console.WriteLine("-------------");

            int? e = null;
            //int f = e.Value; // e 가 null이니까 e.Value가 불가.

            int z;
            if (e.HasValue) z = e.Value; // e 값이 있으면 z에 null이면 0
            else z = 0;
            Console.WriteLine("value of z ={0}",z);


            int v = e ?? 0;  // e 가 null 아니면 v=e대입, null 이면 v=0
            Console.WriteLine("value of v ={0}", v);
        }
    }
}

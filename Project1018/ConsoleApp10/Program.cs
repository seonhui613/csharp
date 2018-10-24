using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
class Program
{
    delegate void Deli(string s);
    static void Main()
    {
        Deli d0 = (v) => Console.WriteLine(v);
        d0.Invoke("OJC");

        Deli d1 = new Deli(d);
        d1.Invoke("OJC");

        Deli d2 = d;
        d2.Invoke("OJC");
    }
    static void d(string s)
    {
        Console.WriteLine(s);
    }
}
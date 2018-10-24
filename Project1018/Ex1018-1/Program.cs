using System;
using System.Collections.Generic;
using System.Text;
namespace deledatetest
{
    delegate void OnjDelegate(int a, int b);
    class MainApp
    {
        static void Plus(int a, int b) { Console.WriteLine("{0} + {1} = {2}", a, b, a + b); }
        static void Minus(int a, int b) { Console.WriteLine("{0} - {1} = {2}", a, b, a - b); }
        void Multiplication(int a, int b) { Console.WriteLine("{0} * {1} = {2}", a, b, a * b); }
        void Division(int a, int b) { Console.WriteLine("{0} / {1} = {2}", a, b, a / b); }

        static void Main()
        {
            string str = Console.ReadLine();
            string[] sArr = str.Split(new char[] { ',' });
            int[] arr = Array.ConvertAll(sArr, s => int.Parse(s));



            MainApp m = new MainApp();

            OnjDelegate CallBack = (OnjDelegate)Delegate.Combine(
            new OnjDelegate(MainApp.Plus),
            new OnjDelegate(MainApp.Minus),
            new OnjDelegate(m.Multiplication),
            new OnjDelegate(m.Division));
            CallBack(arr[0], arr[1]);

            Console.WriteLine("멀티캐스팅 ->");
            OnjDelegate CallBack2 = new OnjDelegate(MainApp.Plus);
            CallBack2 += new OnjDelegate(MainApp.Minus);
            CallBack2 += new OnjDelegate(m.Multiplication);
            CallBack2 += new OnjDelegate(m.Division);
            CallBack2(arr[0], arr[1]);
        }
    }
}
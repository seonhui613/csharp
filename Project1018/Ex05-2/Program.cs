using System;
namespace Akadia.NoDelegate
{
    public class MyClass
    {
        public void Process()
        {
            Console.WriteLine("Process() begin");
            Console.WriteLine("Process() end");
        }
    }


    public class Test
    {
        private delegate void Obj();

        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.Process();
            Console.WriteLine("==============");
            Action a = myClass.Process;
            a();
        }
    }
}
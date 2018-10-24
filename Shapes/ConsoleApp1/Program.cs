using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    interface Dog
    {
        string name { get; set; }
        void jitda();

    }

    class Puddle : Dog
    {
        public string name{get; set;}
        public void jitda()
        {
            Console.WriteLine(name + "가  푸들푸들~ 짖다.");
        }

        public void work()
        {
            Console.WriteLine(name + "가  일한다.");
        }
    }
     class Jindo : Dog
    {
        public string name { get; set; }

        public void jitda()
        {
            Console.WriteLine(name + "가  진도진도~ 짖다.");
        }
        public void Run()
        {
            Console.WriteLine(name + "가  달린다.");
        }
    }
    class DogManager
    {
        static void Main(string[] args)
        {
            Dog p = new Puddle();
            p.name = "푸들이";
            p.jitda();
            ((Puddle)p).work();

            Dog j = new Jindo();
            j.name = "진돌이";
            j.jitda();
            ((Jindo)j).Run();
        }
    }
}

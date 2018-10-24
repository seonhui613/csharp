using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class EventPublisher
    {
        // public delegate void MyEventHandler();

        public event EventHandler MyEvent;
        public void Do()
        {
            if(MyEvent != null)
            {
                MyEvent(null, null);
            }
            //MyEvent?.Invoke(); // null 이면 호출x
        }
    }
    class Subscriber
    {
        static void Main(string[] args)
        {
            EventPublisher p = new EventPublisher();

            //1.0에서 이벤트 가입
            p.MyEvent += new EventHandler(doAction);
           // 2.0에서 이벤트 가입
            p.MyEvent += doAction;
            //2.0에서 delegate로 이벤트 가입
            p.MyEvent += delegate (object sender, EventArgs e)
            { Console.WriteLine("MyEvent 라는 이벤트 발생");  };
            // 3.0에서 람다식으로 이벤트 가입
            p.MyEvent += (sender, e) =>
             { Console.WriteLine("MyEvent 라는 이벤트 발생"); };
            p.Do();


        }
        static void doAction(object sender, EventArgs e)
        {
            Console.WriteLine("MyEvent 라는 이벤트 발생...");
        }
    }
}

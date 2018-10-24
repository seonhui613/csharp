// 15.  실행결과는? (먼저 예측하고 코딩해보세요.)

// 10 10 10 10 10 10 10 10 10 10
//Press a key...

using System;

using System.Threading;

class Program

{
    public static void Main(string[] args)
    {
        Thread[] t = new Thread[10];
        for (int tNum = 0; tNum < 10; tNum++)
        {
            t[tNum] = new Thread(() => {
                Thread.Sleep(new Random().Next(20));
                Console.Write(tNum + " ");
            });
            t[tNum].Start();
        }
        for (int tNum = 0; tNum < 10; tNum++)
        {
            t[tNum].Join();
        }
        Console.WriteLine("\nPress a key...");
        Console.Read();
    }
}
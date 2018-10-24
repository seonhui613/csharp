//16. 실행결과를 확인하고 코드를 완성하세요.

//[실행결과]
//Dog
//Cat
//Mouse
//Mouse

using System; 

public delegate void EventHandler();

class Program
{
    public static event EventHandler _show;

    static void Main()
    {
        // Add event handlers to Show event. 
        EventHandler e = new EventHandler(Cat);
        EventHandler e1 = new EventHandler(Dog);
        EventHandler e2 = new EventHandler(Mouse);
        EventHandler e3 = new EventHandler(Mouse);

        // Invoke the event. 
        
        e1.Invoke();
        e.Invoke();
        e2.Invoke();
        e3.Invoke();
    }

    static void Cat()
    {
        Console.WriteLine("Cat");
    }

    static void Dog()
    {
        Console.WriteLine("Dog");
    }

    static void Mouse()
    {
        Console.WriteLine("Mouse");
    }
}
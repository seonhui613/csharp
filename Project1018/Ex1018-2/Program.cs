using System;

public delegate void Callback();
class Program
{
    static void Main(string[] args)
    {
        MyClass my = new MyClass();
        my.MyMethod1();
        my.MyMethod2();
        Console.WriteLine("------------");

        //(채워주세요)
        Callback call = (Callback)Delegate.Combine(
            new Callback(my.MyMethod1),
            new Callback(my.MyMethod2));
        //(채워주세요)
        call();

    }
}

public class MyClass
{
    public MyClass() { }

    public void GetCallback(Callback callBack)
    {
        callBack();
    }

    public void MyMethod1()

    {
        Console.WriteLine("My Method 1");
    }

    public void MyMethod2()
    {
        Console.WriteLine("My Method 2");
    }

}
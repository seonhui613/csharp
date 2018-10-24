using System;

class MyBaseClass
{
    public MyBaseClass()
    {
        Console.WriteLine(">>> MyBaseClass()");
    }
    public MyBaseClass(int i)
    {
        Console.WriteLine(">>> MyBaseClass(int i)");
    }
}
class Myclass : MyBaseClass
{
    public Myclass()
    {
        Console.WriteLine(">>> MyClass()");
    }
    public Myclass(int i) : base(i)
    {
        Console.WriteLine(">>> MyClass(int i)");
    }
    public Myclass(int i, int j) 
    {
        Console.WriteLine(">>> MyClass(int i, int j)");
    }
    public Myclass(int i, int j, int k ) : base(i)
    {
        Console.WriteLine(">>> MyClass(int i, int j, int k)");
    }
    public Myclass(int i, int j, int k, int l) : this(i,j)
    {
        Console.WriteLine(">>> MyClass(int i, int j, int k, int l)");
    }
}

class Test
{
    static void Main()
    {
        Myclass m1 = new Myclass();
        Console.WriteLine("\n");
        Myclass m2 = new Myclass(1);
        Console.WriteLine("\n");
        Myclass m3 = new Myclass(1,2);
        Console.WriteLine("\n");
        Myclass m4 = new Myclass(1,2,3);
        Console.WriteLine("\n");
        Myclass m5 = new Myclass(1,2,3,4);


    }
}
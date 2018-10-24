// 11. 실행결과는? (먼저 예측하고 코딩해보세요.)
//[실행결과]
//2
//2
//2
//2
//4

//2
//2

using System;

class Program
{
    static void Main()
    {
        Func<int, int> func1 = x => x + 1;
        Func<int, int> func2 = x => { return x + 1; };
        Func<int, int> func3 = (int x) => x + 1;
        Func<int, int> func4 = (int x) => { return x + 1; };
        Func<int, int, int> func5 = (x, y) => x * y;

        Action func6 = () => Console.WriteLine();

        Func<int, int> func7 = delegate (int x) { return x + 1; };
        Func<int> func8 = delegate { return 1 + 1; };

        Console.WriteLine(func1.Invoke(1)); 

        Console.WriteLine(func2.Invoke(1));

        Console.WriteLine(func3.Invoke(1));

        Console.WriteLine(func4.Invoke(1));

        Console.WriteLine(func5.Invoke(2, 2));

        func6.Invoke();

        Console.WriteLine(func7.Invoke(1));

        Console.WriteLine(func8.Invoke());
    }
}
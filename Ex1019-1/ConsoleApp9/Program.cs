﻿// 10. 실행결과는?(먼저 예측하고 코딩해보세요.) 
// [실행결과 ]
//2
using System;

using System.Collections.Generic;



class Program

{

    static void Main()

    {

        List<int> elements = new List<int>() { 10, 20, 31, 40 };

        // ... Find index of first odd element.

        int oddIndex = elements.FindIndex(x => x % 2 != 0);

        Console.WriteLine(oddIndex);

    }

}
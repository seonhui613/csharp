//3. 사용자로 부터 두수를 입력받아 변수에 넣고 변수값을 뒤짚어서 출력하는 프로그램 입니다.

//(C# Program to Swap two Numbers)


//[결과]

//Enter the First Number : 1 

//Enter the Second Number : 2 

//After Swapping :

//First Number : 2 

//Second Number : 1 



using System;
class Program
{
    static void Main(string[] args)

    {

        int num1, num2, temp;

        Console.Write("\nEnter the First Number : ");

        num1 = int.Parse(Console.ReadLine());

        Console.Write("\nEnter the Second Number : ");

        num2 = int.Parse(Console.ReadLine());


        temp = num1;
        num1 = num2;
        num2 = temp;




        Console.Write("\nAfter Swapping : ");

        Console.Write("\nFirst Number : " + num1);

        Console.Write("\nSecond Number : " + num2);

        Console.Read();

    }
}


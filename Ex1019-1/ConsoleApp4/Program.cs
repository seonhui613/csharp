//5. 실행결과가 아래와 같다.



//Enter a Number : 123

//Reverse of Entered Number : 321

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;



namespace Program

{

    class Program

    {

        static void Main(string[] args)

        {

            int num, reverse = 0;

            Console.WriteLine("Enter a Number : ");

            num = int.Parse(Console.ReadLine());

            while (num != 0)

            {
                // 채워 주세요, 10으로 나누어서 몫, 나머지 이용
                int na = num % 10; 
                int mok = num / 10;  
                reverse = (reverse * 10) + na;
                num = mok;

            }

            Console.WriteLine("Reverse of Entered Number is : " + reverse);

            Console.ReadLine();
        }

    }

}




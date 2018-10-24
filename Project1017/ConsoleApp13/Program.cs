using System;

using System.Collections;

using System.Collections.Generic;

namespace ConsoleApplication6
{
    class Stack3<T>
    {
        int top = 0;
        T[] ar = new T[10];
     public void Push(T obj)
        {
            ar[top] = obj;
            top++;
        }
        public T Pop()
        {
            top--;
            return ar[top];
        }
    }
    class StackTest
    {
        static void Main()
        {
            Stack3<int> s1 = new Stack3<int>();
            s1.Push(1);
            s1.Push(2);
            s1.Push(3);
            Console.WriteLine(s1.Pop());
            Console.WriteLine(s1.Pop());
            Console.WriteLine(s1.Pop());

            Stack3<string> s2 = new Stack3<string>();
            s2.Push("KOREA");
            s2.Push("대한민국");
            s2.Push("서울");
            Console.WriteLine(s2.Pop());
            Console.WriteLine(s2.Pop());
            Console.WriteLine(s2.Pop());

            

        }
    }
}
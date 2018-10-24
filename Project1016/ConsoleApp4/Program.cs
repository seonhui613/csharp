using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Emp
    {
         // c#은 접근제어자가 private다.

        public string Name
        {
            get; //자동 구현 속성

            set;
           
        }

    }


    class EmpTest
    { 
        static void Main(string[] args)
        {
            Emp e = new Emp();
            e.Name= "홍길동";
            Console.WriteLine(e.Name);
        }
    }
}


// public
// internal  : 같은 프로젝트 안에서. 같은 어셈블리
// protected : 자식도 접근 가능
// private : 접근 불가( 기본값) 안쓰면 private으로 정의.
// 속성은 변수처럼 사용. get, set
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, String> onj = new Dictionary<string, string>();
            onj.Add("김길동", "서울");
            onj.Add("홍길동", "광주");
            onj.Add("박길동", "부산");

            try
            {
                onj.Add("김길동", "서울");
            }
            catch
            {
                Console.WriteLine("키값 중복 !!!!!!!!!!!!!!!!!");
            }
            Console.WriteLine("For key = \"name\", value={0}", onj["홍길동"]);
            onj["박길동"]="제주";
            Console.WriteLine("For key = \"name\", value={0}", onj["박길동"]);
            if (!onj.ContainsKey("최길동"))
            {
                onj.Add("최길동", "하와이");
                Console.WriteLine("Value added for key = \"name\", value={0}", onj["최길동"]);
            }
            Console.WriteLine();

            foreach(KeyValuePair<String,String> d in onj)
            {
                Console.WriteLine("Key = {0}, Value ={1}", d.Key, d.Value);
            }
            Console.WriteLine();
            SortedList<String,String> s = new SortedList<String,String>(onj);

            foreach (KeyValuePair<String, String> d in s)
            {
                Console.WriteLine("Key = {0}, Value ={1}", d.Key, d.Value);
            }
        }
    }
}

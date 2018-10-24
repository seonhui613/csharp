using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myFavor =
            {
                "Apple,banana,StrawBerry",
                "Baseball,Football,Soccur",
                "Programming,Design,Assembly",
            };
            var favorite =
                    from m in myFavor
                    let favor = m.Split(',')
                    from word in favor
                    let w = word.ToLower()
                    where w[0] == 'a'
                    select word;

            foreach(var w in favorite)
            {
                Console.WriteLine("A로 시작되는 단어 : {0}", w);
            }
        }
    }
}

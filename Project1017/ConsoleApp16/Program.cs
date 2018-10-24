using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication6
{
    class Goods
    {
        public int goodsno { get; set; }
        public string gname { get; set; }
        public int danga { get; set; }

        public Goods(int goodsno, string gname, int danga)
        {
            this.goodsno = goodsno;
            this.gname = gname;
            this.danga = danga;
        }

        public override String ToString()
        {
            return "Goods [상품번호=" + goodsno + ", 상품명=" + gname + ", 단가=" + danga + "]";
        }
    }

    class Cart
    {
        public Goods goods { get; set; }
        public int count { get; set; }
        public int sum { get; set; }

        public override String ToString()
        {
            return "Cart [Goods=" + goods + ", count=" + count + ", sum=" + sum + "]";
        }
    }

    class CartTest
    {
        static void Main()
        {
            //여기를 채우세요.... 
            SortedList<int, Cart> cart = new SortedList<int, Cart>();

            cart.Add(1, new Cart() { goods = new Goods(1001, "볼펜", 2000), count=2, sum=4000 });
            cart.Add(2, new Cart() { goods = new Goods(1002, "연필", 500), count=3, sum=1500 });
            cart.Add(3, new Cart() { goods = new Goods(1003,"딸기", 6000), count=2, sum=12000 });

            foreach (KeyValuePair< int, Cart > c in cart)
            {
                Console.Write("{0} : {1} : {2} : {3} : {4} : {5}  ", c.Key, c.Value.goods.goodsno, c.Value.goods.gname, c.Value.goods.danga, c.Value.count, c.Value.sum );
                Console.WriteLine();
            }
        }
    }
}
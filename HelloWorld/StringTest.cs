using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class StringTest
    {
        static void Main(string[] args)
        {
            //DoStringTest();

            //少量字符串时，尽量不要用，StringBuilder本身是有一定性能开销的；
            //大量字符串连接使用StringBuilder时，应该设置一个合适的容量；
            //StringBuilder sb1 = new StringBuilder();
            //Console.WriteLine("Capacity={0}; Length={1};", sb1.Capacity, sb1.Length); //输出：Capacity=16; Length=0;   //初始容量为16 
            //sb1.Append('a', 12);    //追加12个字符
            //Console.WriteLine("Capacity={0}; Length={1};", sb1.Capacity, sb1.Length); //输出：Capacity=16; Length=12;  
            //sb1.Append('a', 20);    //继续追加20个字符，容量倍增了
            //Console.WriteLine("Capacity={0}; Length={1};", sb1.Capacity, sb1.Length); //输出：Capacity=32; Length=32;  
            //sb1.Append('a', 41);    //追加41个字符，新容量=32+41=73
            //Console.WriteLine("Capacity={0}; Length={1};", sb1.Capacity, sb1.Length); //输出：Capacity=73; Length=73;


            object a = "123";
            object b = "123";
            Console.WriteLine(System.Object.Equals(a, b));
            Console.WriteLine(System.Object.ReferenceEquals(a, b));
            string sa = "123";
            Console.WriteLine(System.Object.Equals(a, sa));
            Console.WriteLine(System.Object.ReferenceEquals(a, sa));
        }

        //public static void DoStringTest()
        //{
        //    var aa = "000";
        //    SetStringValue(aa);
        //    Console.WriteLine(aa);
        //}

        //private static void SetStringValue(string aa)
        //{
        //    aa += "111";
        //}

        public static void Fun()
        {
            string s1 = "123";
            string s2 = s1 + "abc";
            string s3 = "123abc";
            Console.WriteLine(s2 == s3);
            Console.WriteLine(System.Object.ReferenceEquals(s2, s3));
        }
    }
}

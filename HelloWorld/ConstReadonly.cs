using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class ConstReadonly
    {
        public static void Test()
        {
            //test readonly&const
            TestConstReadonly c = new TestConstReadonly();
            //c.j = 11;

            Console.WriteLine(c.j);
            Console.WriteLine(TestConstReadonly.i);
        }
    }

    class TestConstReadonly
    {
        //cannot be marked as static（只能在声明中初始化）
        public /*static*/ const int i = 10;


        //声明或者构造函数中初始化
        public readonly int j;

        public readonly int k = 9;

        public TestConstReadonly()
        {
            j = 8;
        }
    }
}

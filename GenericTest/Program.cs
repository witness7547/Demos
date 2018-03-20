//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace GenericTest
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            ArrayList animals = new ArrayList();
//            animals.Add(1);//boxing
//            //animals.Add(new Dog());
//            //animals.Add(new Cat());

//            foreach (int item in animals)
//            {
//                Console.WriteLine(item);//unboxing
//            }


//            List<int> mylist = new List<int>();
//            mylist.Add(1);//no boxing

//            //cannot convert from 'GenericTest.Program.Cat' to 'int'
//            //mylist.Add(new Cat());
//        }

//        class Dog
//        {

//        }

//        class Cat
//        {

//        }
//    }
//}

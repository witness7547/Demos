using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentCollectionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //ConcurrentBag<string> myBag = new ConcurrentBag<string>();

            //myBag.Add("0");
            //myBag.Add("1");
            //myBag.Add("2");
            //myBag.Add("4");
            //myBag.Add("3");

            //foreach (var item in myBag)
            //{
            //    Console.WriteLine(item);
            //}


            ConcurrentDictionary<string, int> myDic = new ConcurrentDictionary<string, int>();
            myDic.TryAdd("1", 100);
            myDic.TryAdd("2", 103);
            myDic.TryAdd("3", 100);

            //myDic.TryAdd("1", "!");
            //Func<string, string, string> myFunc = (a, b) => { return a + b; };

            myDic.AddOrUpdate("3", 999, (key, value) => value + 1);

            //// Construct a ConcurrentDictionary
            //ConcurrentDictionary<int, int> cd = new ConcurrentDictionary<int, int>();

            //// Bombard the ConcurrentDictionary with 10000 competing AddOrUpdates
            //Parallel.For(0, 10000, i =>
            //{
            //    // Initial call will set cd[1] = 1.  
            //    // Ensuing calls will set cd[1] = cd[1] + 1
            //    cd.AddOrUpdate(1, 1, (key, oldValue) => oldValue + 1);
            //});

            //Console.WriteLine("After 10000 AddOrUpdates, cd[1] = {0}, should be 10000", cd[1]);

            //// Should return 100, as key 2 is not yet in the dictionary
            //int value = cd.GetOrAdd(2, (key) => 100);
            //Console.WriteLine("After initial GetOrAdd, cd[2] = {0} (should be 100)", value);

            //// Should return 100, as key 2 is already set to that value
            //value = cd.GetOrAdd(2, 10000);
            //Console.WriteLine("After second GetOrAdd, cd[2] = {0} (should be 100)", value);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 4, 5, 6, 3, 2, 1 };
            int[] arr = { 4, 5, 6, 1, 2, 3 };

            //Bubble.Sort(arr, arr.Length);

            Insert.Sort(arr, arr.Length);

            //Selection.Sort(arr, arr.Length);

            Print(arr);
        }

        static void Print(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}

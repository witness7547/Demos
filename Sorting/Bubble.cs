using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Bubble
    {
        /// <summary>
        /// Bubble sorting
        /// 稳定
        /// 时间复杂度：O(n*n)
        /// 基于比较
        /// 空间复杂度：原地排序，O（1）
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        public static void Sort(int[] arr, int n)
        {
            int count = 0;
            for(int i = 0; i< n; i++)
            {
                bool flag = false;//用于判断是否已经有序的标志

                for (int j = 0; j < (n-i-1); j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        flag = true;
                    }
                }

                if (flag == false)
                {
                    break;
                }
                count++;
            }

            Console.WriteLine("Count = " + count.ToString());
        }
    }
}

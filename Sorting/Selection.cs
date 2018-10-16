using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Selection
    {
        /// <summary>
        /// Selection sorting
        /// 不稳定
        /// 时间复杂度：O(n*n)
        /// 基于比较
        /// 空间复杂度：原地排序，O（1）
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        public static void Sort(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                int min = i;
                for (int j = i+1; j < n; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                if (min != 0)
                {
                    int temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                }
            }
        }
    }
}

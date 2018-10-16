using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Insert
    {
        /// <summary>
        /// Inserting sort
        /// 稳定
        /// 时间复杂度：O(n*n)
        /// 基于比较
        /// 空间复杂度：原地排序，O（1）
        /// 扩展：折半插入，希尔排序等
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        public static void Sort(int[] arr, int n)
        {
            for (int i = 0; i < (n-1); i++)
            {
                int tmp = arr[i];
                int j = i - 1;
                //查找插入位置（此处从后往前查找）
                for (; j >= 0; j--)
                {
                    if (tmp < arr[j])
                    {
                        arr[j+1] = arr[j];//移动数据
                    }
                    else
                    {
                        break;
                    }
                }

                arr[j+1] = tmp;//插入数据
            }
        }
    }
}

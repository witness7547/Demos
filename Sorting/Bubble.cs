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

        /// <summary>
        /// 原地排序
        /// 稳定
        /// 时间复杂度
        /// 最好情况下为O(n)
        /// 最坏和平均为O(n^2)
        /// 
        /// 有序度 = 满序度 - 逆序度；
        /// 排序时交换一次则有序度加一，逆序度减一
        /// </summary>
        /// <param name="a"></param>
        /// <param name="len"></param>
        public static void BubbleSort(int[] a, int len)
        {
            if (len <= 0)
            {
                return;
            }

            for (int i = 0; i < len - 1; i++)
            {
                bool flag = false;//若某次冒泡过程中无交换则已经排好序

                for (int j = 0; j < (len - 1 - i); j++)
                {
                    if (a[j] > a[j+1])
                    {
                        int tmp = a[j];
                        a[j+1] = a[j];
                        a[j] = tmp;
                    }
                    else
                    {
                        flag = true;
                    }
                }

                if (flag)
                {
                    break;
                }
            }
        }
    }
}

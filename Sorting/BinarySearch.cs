/*********************************************************************************** 
*        Filename :Class3 
*        Description :  
*        Date:2018/6/18 16:31:29 
 *       Machinename:PC-201305061330 
*        Created by: <T> Zhen Wang
*        All rights reserved 
* 
*       ChangeLog: 
*       2014/5/15 16:31:29: 
 *          Created! 
************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class BinarySearch
    {
        public static int Search(int[] a, int value)
        {
            if (a.Length <= 0)
                return -1;

            int n = a.Length;
            int low = 0, high = n - 1, mid;

            while (low <= high)
            {
                mid = low + (high - low)/2;
                if (value == a[mid])
                {
                    return mid;
                }
                else if(value < a[mid])
                {
                    high = mid - 1;
                }
                else if(value > a[mid])
                {
                    low = mid + 1;
                }

            }

            return -1;

        }

    }
}

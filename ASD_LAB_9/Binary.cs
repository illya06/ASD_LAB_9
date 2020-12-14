using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD_LAB_9
{
    class Binary
    {
        public static int binSearch(int[] arr, int val, int left, int right)
        {
            if(left > right)
            {
                return -1;
            }

            int mid = (left + right) / 2;
            if (arr[mid] == val)
            {
                return mid;
            }
            else if(arr[mid] < val)
            {
                return binSearch(arr, val, mid + 1, right);
            }
            else
            {
                return binSearch(arr, val, left, mid - 1);
            }
        }
    }
}

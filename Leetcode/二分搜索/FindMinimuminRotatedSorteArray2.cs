using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class FindMinimuminRotatedSorteArray2
    {
        public int FindMin(int[] nums)
        {
            int length = nums.Length;
            int beg = 0;
            int end = length - 1;
            int mid = 0;
            while (beg < end)
            {
                if (nums[beg] < nums[end])
                    break;  
                mid = (beg + end) / 2;
                if (nums[beg] > nums[mid])
                {
                    end = mid;//闭区间（也有可能mid是最小值）
                }
                else if (nums[mid] > nums[end])
                {
                    beg = mid + 1;//开区间，因此+1（mid不可能是最小值）
                }
                else//这种情况是nums[beg]=nums[mid]=nums[end]，因为此时nums[end]<nums[beg]
                {
                    beg++;
                }
            }
            return nums[beg];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //包含重复的元素
    public class FindMinimuminRotatedSorteArray
    {
        public int FindMin(int[] nums)
        {
            int length = nums.Length;
            int beg = 0;
            int end = length - 1;//闭区间，注意-1
            int mid = 0;
            while (beg < end)
            {
                if (nums[beg] < nums[end])//如果成立代表数组是有序的，直接退出循环
                    break;
                mid = (beg + end) / 2;
                if (nums[beg] > nums[mid])//这里面将两个元素的特殊情况包括在内
                {
                    end = mid;
                }
                else
                {
                    beg = mid + 1;
                }
            }
            return nums[beg];
        }
    }

    /*参考博客地址:http://blog.csdn.net/loverooney/article/details/40921751*/
}

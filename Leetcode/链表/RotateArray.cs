using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    /*LeetCode:https://leetcode.com/problems/rotate-array/*/
    class RotateArray
    {
        //向右翻转数组
        public void Rotate(int[] nums, int k)
        {
            int length = nums.Length;
            k = k % length;
            if (k > 0)
            {
                swap(nums, 0, length - k - 1);
                swap(nums, length - k, length - 1);
                swap(nums, 0, length - 1);
            }
        }

        //翻转一个数组从start--end的下标
        public void swap(int[] nums, int start, int end)
        {
            int temp;
            while (start < end)
            {
                temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }
    }
}

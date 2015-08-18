using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.数组
{
    //LeetCode 31:https://leetcode.com/problems/next-permutation/
    //记住这道题的思路
    class NextPermutation
    {
        static void Main11(string[] args)
        {
            int[] nums = new int[] { 1, 1 };
            NextPermutationSolution(nums);
        }
        public static void NextPermutationSolution(int[] nums)
        {
            int length = nums.Length;
            if (length == 1)
                return;
            int pos1 = length - 2;
            //从后面找出第一个左边小于右边的数的位置
            while (pos1 >= 0 && nums[pos1] >= nums[pos1 + 1])
            {
                pos1--;
            }
            //如数组是降序的，那就直接翻转
            if (pos1 < 0)
            {
                Reverse(nums, 0, length - 1);
                return;
            }
            //从后面找出第一个比pos位置的数大的数
            int pos2 = length - 1;
            while (pos2 > pos1 && nums[pos2] <= nums[pos1])
            {
                pos2--;
            }
            //开始交换pos1 pos2的位置
            Swap(nums, pos1, pos2);
            //开始翻转数组，将pos1后面的数组反转
            Reverse(nums, pos1 + 1, length - 1);
        }

        private static void Swap(int[] nums, int index1, int index2)
        {
            int temp = nums[index1];
            nums[index1] = nums[index2];
            nums[index2] = temp;
        }

        private static void Reverse(int[] nums, int begin, int end)
        {
            while (begin < end)
            {
                Swap(nums, begin, end);
                begin++;
                end--;
            }
        }
    }
}

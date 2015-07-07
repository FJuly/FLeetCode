using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    /*LeetCode:https://leetcode.com/problems/majority-element/*/
    class MajorityElement
    {
        public int MajorityElementSolution(int[] nums)
        {
            //int length=nums.Length;
            //Dictionary<int, int> dic = new Dictionary<int, int>();
            //for (int i = 0; i < nums.Length; i++)//循环两次的时间复杂度
            //{
            //    if (!dic.Keys.Contains(nums[i]))
            //    {
            //        dic.Add(nums[i], 1);
            //    }
            //    else {
            //        dic[nums[i]]++;
            //    }
            //}
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (dic[nums[i]] > (length / 2))
            //    {
            //        return nums[i];
            //    }
            //}
            //return 0;

            //空间复杂度为1的算法
            /*
             *算法思路：
             *每次扔掉两个不同的数，众数不变
             */
            int count = 1, x = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (count == 0)
                {
                    x = nums[i];
                    count = 1;
                }
                else if (x == nums[i])
                    count++;
                else
                {
                    count--;
                }
            }
            return x;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class MaximumSubarray
    {
        /*使用动态规划，leeetcode:https://leetcode.com/problems/maximum-subarray/*/
        //思路：统计以i结尾的最大子数组的和，递推公式：以i结尾的最大的和是以i-1结尾的最大的和加上或者不加上i
        //也可以使用前缀和解决
        public int MaxSubArray(IList<int> nums)
        {
            int pre = nums[0];
            int max = nums[0];
            //int[] dp = new int[nums.Count];
            //dp[0] = nums[0];
            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i] > (nums[i] + pre))
                {
                    pre = nums[i];
                }
                else
                {
                    pre = pre + nums[i];
                }
                if (pre > max)
                    max = pre;

                //dp[i] = Math.Max(nums[i], dp[i - 1] + nums[i]);
            }
            return max;
        }
    }
}

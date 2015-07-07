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
        /*看一下分治的解法*/
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

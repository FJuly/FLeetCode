using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.动态规划
{
    //跟求最大子序列的问题是一样的，不过要保存两个变量，因为要负负得正
    class MaximumProductSubarray
    {
        public int MaxProduct(int[] nums)
        {
            //纪录两个数
            int preMin = nums[0];
            int preMax = nums[0];
            int Max = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                int temp = preMax * nums[i];
                preMax = Math.Max(Math.Max(nums[i], preMin * nums[i]), preMax * nums[i]);
                preMin = Math.Min(Math.Min(nums[i], preMin * nums[i]),temp);    
                if (preMax > Max)
                    Max = preMax;
            }
            return Max; 
        }
    }
}

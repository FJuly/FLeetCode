using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    /*这一题参考。。。。*/
    class SingleNumberII
    {
        public int singleNumber(int[] nums)
        {
            int[] digits = new int[32];
            for (int i = 0; i < 32; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    digits[i] += (nums[j] >> i) & 1;
                }
            }
            int res = 0;
            for (int i = 0; i < 32; i++)
            {
                res += (digits[i] % 3) << i;
            }
            return res;
        }
    }
}
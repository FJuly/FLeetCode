using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //使用哈希表,LeetCode 128:https://leetcode.com/problemset/algorithms/
    //使用哈希，解法比较巧妙，很容易理解
    class LongestConsecutiveSequence
    {
        public int LongestConsecutiveSolution(int[] nums)
        {
            int length = nums.Length;
            HashSet<int> set = new HashSet<int>();
            int max=0;
            foreach(int cur in nums)
                set.Add(cur);

            foreach (int cur in nums)
            {
                int len=1;
                int left = cur - 1;
                int right = cur + 1;
                while (set.Contains(left))
                {
                    len++;
                    set.Remove(left);
                    left--;
                }
                while (set.Contains(right))
                {
                    len++;
                    set.Remove(left);
                    right++;
                }

                max = max > len ? max : len;
            }
            return max;
        }
    }
}

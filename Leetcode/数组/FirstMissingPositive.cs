using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.数组
{
    public class FirstMissingPositive
    {
        /*按照七月算法的视频的思路来写的*/
        public int firstMissingPositive(int[] nums)
        {
            int length = nums.Length;
            if (length == 1)
                return 0;
            for (int i = 0; i < length; )
            {
                Console.WriteLine(i.ToString());
                if (nums[i] == i + 1)
                    ++i;
                else if ((nums[i] > length) || (nums[i] <= 0))//去除不可能的元素
                {
                    Console.WriteLine(nums[i].ToString());
                    nums[i] = nums[--length];
                }
                else if ((nums[nums[i] - 1] == nums[i]) || (nums[i] <= i))
                {
                    Console.WriteLine(nums[i].ToString());
                    nums[i] = nums[--length];
                }
                else
                {
                    /*将元素放到正确的位置*/
                    int temp = nums[i];
                    nums[i] = nums[nums[i] - 1];
                    nums[temp - 1] = temp;
                }
            }
            return length + 1;
        }
    }
}

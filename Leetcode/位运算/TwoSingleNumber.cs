using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    /*
     * 题目描述：一个数组，所有元素都出现了两次，只有两个数只出现了一次，求这两个数
     * 
     */
    public class TwoSingleNumber
    {
        public void TwoSingleNumberSolution(int[] nums)
        {

            

            int xXory = 0;
            /*这个循环是为了找出x y不相同的一位*/
            for (int i = 0; i < nums.Length; i++)
            {
                xXory = xXory ^ nums[i];
            }
            int mask = 1;
            for (; (xXory & mask) == 0; mask = (mask << 1)) ;
            int x = 0, y = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if ((nums[i] & mask) == 0)
                    x = x ^ nums[i];
                if ((nums[i] & mask) == 1)
                    y = y ^ nums[i];
            }
            Console.WriteLine("x是:"+x);
            Console.WriteLine("y是："+y);
        }
    }
}

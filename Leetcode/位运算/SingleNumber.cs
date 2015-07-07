using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    /*可使用位运算位运算中的异或运算。leetcode:https://leetcode.com/problems/single-number/*/
    /*参考博客：http://blog.csdn.net/heathyhuhu/article/details/12744407*/

    /*接下来一题的参考博客：http://blog.csdn.net/jiadebin890724/article/details/23306837*/
    public class SingleNumber
    {
        public int singleNumber(int[] A)
        {
            if (A.Length <= 1)
            {
                return A[0];
            }
            int result = A[0];
            for (int i = 1; i < A.Length; i++)
            {
                result = result ^A[i];
            }
            return result;
        }
    }
}

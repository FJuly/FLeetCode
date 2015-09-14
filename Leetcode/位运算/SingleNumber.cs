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
        static void Main11(string[] args)
        {
            int a = int.Parse("80000000", System.Globalization.NumberStyles.HexNumber);//负数右移动时会最高位会保持不变，即符号位会不变
            a=a-1;
            Console.WriteLine(a.ToString("X"));
        }


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

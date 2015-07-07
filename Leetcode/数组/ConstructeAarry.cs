using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    /*
     * 题目描述：给定一个数组a[N],我们希望构造数组b[N]，
     * 其中b[i]=a[0]*a[1]*...*a[N-1]/a[i]。
     * 在构造过程：不允许使用除法；要求：O(1)空间复杂度和O(n)时间复杂度；
     * 除遍历计数器与a[N] b[N]外，不可使用新的变量(包括栈临时变量、对空间和全局静态变量等)；
     */
    class ConstructeAarry
    {
        public void ConstructeAarrySolution(double[] nums)
        {
            int length = nums.Length;
            double[] result = new double[length];//存放结果
            //先计算后缀积
            for (int i = length - 1; i >= 0; i--)
            {
                result[i] = nums[i] * (i == length - 1 ? 1 : result[i + 1]);
            }
            //再计算前缀积，就会得出结果
            double j=1.0;
            for (int i = 0; i < length; j *= nums[i++])
            {
                result[i] = j * (i == length - 1 ? 1 : result[i + 1]);
            }
        }
    }



    /*
     * 题目描述：现有一个数组，里面包含了正数和负数，取其中若干个连续的数，要求这些数的和的绝对值最小 
     * 对数组A[1....N],做和运算S[1...N],其中S[1] = A[1]; S[2] = A[1]+A[2];...;S[N]=A[1]+A[2]+A[3]+...+A[N]
     * 把所有和在数轴上表示出来，则最小值只会出现在相邻两个数之间，故需要排序，所以算法的时间复杂度主要取决于排序的时间复杂度
     * 在这里使用快速排序算法
     */



    /*两头扫的算法：http://blog.csdn.net/doc_sgl/article/details/12462151*/
}

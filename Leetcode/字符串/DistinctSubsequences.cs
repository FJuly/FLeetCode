using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.字符串
{
    //LeetCode 116:https://leetcode.com/problems/distinct-subsequences/
    class DistinctSubsequences
    {
        public int NumDistinct(string s, string t)
        {
            int len = t.Length;
            int[] nums = new int[len];
            for (int i = 0; i < s.Length; i++)
            {
                //之前是按照正序匹配会出现问题，倒着匹配就没有什么问题了
                for (int j = t.Length - 1; j >= 0; j--)
                {
                    if (t[j] == s[i])
                    {
                        nums[j] += (j == 0 ? 1 : nums[j - 1]);
                    }
                }
            }
            return nums[len - 1];
        }
    }
    //01 附加问题：最小平均值子数组
    //给定一个数组，求一个至少包含两个元素的子数组，满足平均值最小。输出子数组的起点，多个的时候输出最小的
    //分析：如果最优解长度为偶数，我们把它拆成长度为2的若干段
    //如果最优解长度为奇数(>2),我们把它拆成长度为2的若干段，和一段长度为3的段
    //最优解中每一段的平均值都相等！
    //结论： 只考虑长度为2和3的段就可以了。可以“滑动窗口”，也可以直接计算，因为2和3是常数……


    //02 附加问题：环形最大子数组的和，其中求最大子数组的和可以使用动态规划
    /*
     * [1，-2，3，5，-1，2]中最大子数组去掉的是-2，
     * 而[8，-10，60，3，-1，-6]中最大子数组排除的是-10，
     * 这两个有什么特点？没错，这两个数都是两个数组中“最小”的，
     * 所以，我们找最大子数组的对偶问题——最小子数组，有了最小子数组的值，
     * 总值减去它不就可以了么？但是我又想，这个对偶问题只能处理这种跨界的特殊情况吗？
     * 答案是肯定的，如果最大子数组跨界，那么剩余的中间那段和就一定是最小的，而且和必然是负的；
     * 相反，如果最大子数组不跨界，那么总值减去最小子数组的值就不一定是最大子数组和了，
     * 例如上面我们的例子[8，-10，60，3，-1，-6]，最大子数组为[8 | 60，3，-1，-6]，
     * 而最小子数组和为[-10]，显然不能用总值减去最小值。
     */
}

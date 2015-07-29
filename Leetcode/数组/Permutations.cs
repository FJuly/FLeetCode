using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.数组
{
    //回溯算法，LeetCode 46:https://leetcode.com/problemset/algorithms/
    class Permutations
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            List<IList<int>> list = new List<IList<int>>();
            PerRecur(nums, 0, nums.Length - 1, list);
            return list;
        }


        public void PerRecur(int[] nums, int m, int n, List<IList<int>> list)
        {
            if (m == n)
            {
                list.Add(nums.ToList());
            }
            else
            {
                for (int j = m; j <= n; j++)
                {
                    if (IsSwap(nums, m, j))
                    {
                        swap(nums, m, j);// 每次循环交换第一个数和第i个数
                        PerRecur(nums, m + 1, n,list);//m+1....n的全排列
                        swap(nums, j, m);// 再交换回来
                    }
                }
            }
        }

        public void swap(int[] nums, int index1, int index2)
        {
            int temp = nums[index1];
            nums[index1] = nums[index2];
            nums[index2] = temp;
        }


        //去除重复
        public bool IsSwap(int[] nums, int begin, int end)
        {
            while (begin < end)
            {
                if (nums[begin] == nums[end])
                    return false;
                begin++;
            }
            return true;
        }
    }
}

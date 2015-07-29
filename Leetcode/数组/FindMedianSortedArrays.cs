using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.数组
{
    class FindMedianSortedArrays
    {
        //LeetCode:https://leetcode.com/problems/median-of-two-sorted-arrays/
        //最好的解法比较难理解~
        //现在这种算法虽然可以通过，但是时间复杂度不符合要求
        public double FindMedianSortedArraysSolution(int[] nums1, int[] nums2)
        {
            int len1 = nums1.Length;
            int len2 = nums2.Length;
            int[] nums3 = new int[len1 + len2];
            int i = 0, j = 0;
            int cur = 0;
            while (i < len1 && j < len2)
            {
                if (nums1[i] < nums2[j])
                {
                    nums3[cur] = nums1[i];
                    i++;
                }
                else
                {
                    nums3[cur] = nums2[j];
                    j++;
                }
                cur++;
            }
            while (i < len1)
            {
                nums3[cur] = nums1[i];
                i++;
                cur++;
            }
            while (j < len2)
            {
                nums3[cur] = nums2[j];
                j++;
                cur++;
            }
            if ((len2 + len1) % 2 == 0)
            {
                return (nums3[(len1 + len2) / 2] + nums3[(len1 + len2) / 2 - 1]) / 2;
            }
            else
            {
                return nums3[(len1 + len2) / 2];
            }
        }
    }
}

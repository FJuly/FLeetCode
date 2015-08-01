using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.数组
{
    /*这道题考的就是思维：LeetCode 11：https://leetcode.com/problems/container-with-most-water/*/
    //每次更新下标的时候，到底更新i还是更新j呢？这道题挺有意思的地方在于，更新的标准不是通常所理解的i或者j哪个一定更好就更新哪个，
    //而是哪个可能更好就更新哪个，或者说，如果更新i一定会更差，那么就更新j看看不会不变好。
    //当i==j的时候，不管更新是哪个，最大值都不会超过指针在i和j的时候
    class ContainerWithMostWater
    {
        //采用指针两边扫
        public int MaxArea(int[] height)
        {
            int start, end;
            start = 0;
            end = height.Length - 1;
            int maxrarea = 0;
            while (start < end)
            {
                int area = 0;//当前的面积
                area = (end - start) * (height[start] > height[end] ? height[end] : height[start]);
                maxrarea = maxrarea > area ? maxrarea : area;
                if (height[start] > height[end])
                    end--;
                else
                    start++;
            }
            return maxrarea;
        }
    }
}

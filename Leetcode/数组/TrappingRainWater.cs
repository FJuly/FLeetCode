using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.数组
{
    /*Trapping Rain Water LeetCode 42:https://leetcode.com/problems/trapping-rain-water/*/
    //很容易理解
    class TrappingRainWater
    {
        public int Trap(int[] height)
        {
            int[] left = new int[height.Length];
            int max = 0;
            int area = 0;//代表面积
            for (int i = 0; i < height.Length; i++)
            {
                max = max > height[i] ? max : height[i];
                left[i] = max;
            }

            int MaxRight = 0;

            for (int i = height.Length - 1; i > 0; i--)
            {
                int TrapHeight = 0;
                MaxRight = MaxRight > height[i] ? MaxRight : height[i];//右边当前元素的最大值
                TrapHeight = (MaxRight > left[i] ? left[i] : MaxRight) - height[i];
                if (TrapHeight > 0)
                    area += TrapHeight;
            }
            return area;
        }
    }
}

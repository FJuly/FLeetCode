using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    /*LeerCode：https://leetcode.com/problems/largest-rectangle-in-histogram/*/
    public class LargestRectangleinHistogram
    {
        public int LargestRectangleArea(int[] height)
        {
            
            int length = height.Length;
            if (length == 0)
                return 0;
            int area = 0;
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < length; i++)
            {
                while (stack.Count != 0 && height[i] <= height[stack.Peek()])
                {
                    //开始计算面积
                    int h = height[stack.Peek()];
                    stack.Pop();
                    area = Math.Max(area, h * (i - 1 - (stack.Count == 0 ? -1 : stack.Peek())));//这里的下表是i-1
                }
                stack.Push(i);
            }
            while (stack.Count != 0)
            {
                int h = height[stack.Peek()];
                stack.Pop();
                area = Math.Max(area, h * (length - 1 - (stack.Count == 0 ? -1 : stack.Peek())));//注意这里的下标识length-1
            }
            return area;
        }
    }
}

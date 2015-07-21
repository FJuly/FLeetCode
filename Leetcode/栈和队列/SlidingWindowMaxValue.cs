using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.栈和队列
{
    //滑动窗口最大值
    /*
     * 题目描述：给定一个数组a［0..n],还有一个值k，计算数组b［i］ = max(a[i – k + 1.. i]) 注意认为负数下标对应值是无穷小
     */
    class SlidingWindowMaxValue
    {
        //方法1：使用大根堆实现
        public int[] Solution1(int[] a)
        {
            //怎么找到a[i-k]这个数，使用索引堆/*http://blog.sina.com.cn/s/blog_4dff87120100su10.html 优先级队列*/
            //维护一个K大小的堆

            return null;
        }

        //方法2：滑动窗口，新的值和旧的值，这就滑动窗口的思想 LeetCode:https://leetcode.com/problems/sliding-window-maximum/
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            //Queue<int> queue = new Queue<int>();
            int length = nums.Length;

            List<int> list = new List<int>();//使用list模拟队列
       

            if (nums==null||length < k - 1||k<=0)
            {
                return new int[0];
            }
            int[] result = new int[length - k + 1];
            //过期时间在于k
            for (int i = 0; i < length; i++)
            {
                while (list.Count!=0&&(i - list[0]) >= k)
                {
                    list.RemoveAt(0);//移除队头
                }
                while (list.Count != 0 && nums[i] > nums[list[list.Count - 1]])//这里尤其要注意nums[list[list.Count-1]]
                {
                    list.RemoveAt(list.Count-1);//移除队尾
                }
                list.Add(i);
                if (i >= k - 1)
                {
                    result[i - k + 1] = nums[list[0]];
                }
            }
            return result;
        }
    }
}

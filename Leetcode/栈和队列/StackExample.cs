using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    /// <summary>
    /// 栈的基本知识
    /// </summary>
    class StackExample
    {
        /// <summary>
        /// 给定出两组元素，看是否可以通过出栈和入栈得到第二组元素
        /// </summary>
        /// <param name="num1">给定的一个数组</param>
        /// <param name="num2">将要得到的序列</param>
        /// <returns></returns>
        public bool IsStackMatch(int[] num1, int[] num2)
        {
            Stack<int> stack = new Stack<int>();
            int length = num1.Length;
            int cur = 0;//记录num1入栈的下标
            for (int i = 0; i < length; i++)
            {
                if (cur > length)
                    break;
                if (stack.Count == 0)//栈空
                {
                    stack.Push(num1[cur]);
                    cur++;
                }
                while (stack.Peek() != num2[i])//如果栈顶元素不等于num2[i]，就将num1中的元素入栈
                {
                    if (cur >= length)
                        break;
                    stack.Push(num1[cur]);
                    cur++;
                }
                if (stack.Peek() == num2[i])
                    stack.Pop();
            }
            if (stack.Count == 0)//如果栈空则代表可以匹配
                return true;
            else
                return false;
        }
    }

    //问题1：使用两个队列实现一个队列，出栈也就是两个队列来回倒，q1为空，q2不为空，
    //现在要出栈，即将q1里面除了最后一个元素其他全部的元素放到q2中，即可实现出栈操作，入栈操作很简单，只要向不是空的队列里面放置元素就行了

    //问题2：使用两个栈实现一个队列，其实也是两边来回倒，但是栈是先进后出，所以倒两次栈的顺序也就变成了队列的顺序，这是跟两个队列实现一个栈不同的地方。
    //s1 s2,入栈总是入s1，出栈的话如果s2不空，则出s2，如果s2为空，则将s1里面的元素全放到s2中，然后s2再出

    //问题3：栈中实现一个getMin()函数，比较有意思
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.链表
{
    //LettCode 138:https://leetcode.com/problems/copy-list-with-random-pointer/
    class CopyListwithRandomPointer
    {
        public RandomListNode CopyRandomList(RandomListNode head)
        {
            //使用hash，关键是hash存储什么
            if (head == null)
                return null;
            RandomListNode temp = head;
            Dictionary<RandomListNode, RandomListNode> dic = new Dictionary<RandomListNode, RandomListNode>();
            RandomListNode newHead = new RandomListNode(temp.label);
            RandomListNode first = newHead;
            dic.Add(temp, newHead);
            temp = temp.next;
            while (temp != null)
            {
                RandomListNode node = new RandomListNode(temp.label);
                dic.Add(temp, node);
                first.next = node;
                first = node;
                temp = temp.next;
            }

            temp = head;
            RandomListNode temp1 = newHead;

            while (temp != null)
            {
                if (head.random == null)
                    temp1.random = null;
                else
                {
                    temp1.random = dic[temp.random];
                }
                temp = temp.next;
                temp1 = temp1.next;
            }
            return newHead;
        }
    }

    public class RandomListNode
    {
        public int label;
        public RandomListNode next, random;
        public RandomListNode(int x) { this.label = x; }
    };
}

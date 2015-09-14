using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.链表
{
    class ReverseLinkedListII
    {
        static void Main11(string[] args)
        {
            
            ListNode node1 = new ListNode(1);
            ListNode node2 = new ListNode(2);
            ListNode node3 = new ListNode(3);
            node1.next = node2;
            node2.next = node3;
            ReverseBetween(node1,3,3);

        }

        public static ListNode ReverseBetween(ListNode head, int m, int n)
        {
            //记录断开链表的四个位置
            ListNode ansFirst = null;
            ListNode first = null;
            ListNode end = null;
            ListNode ansEnd = null;
            ListNode ansHead = head;

            int i = 1;
            while (head != null)
            {
                if (i == m - 1)
                    ansFirst = head;
                if (i == m)
                    first = head;
                if (i == n)
                    end = head;
                if (i == n + 1)
                    ansEnd = head;
                i++;
                head = head.next;
            }
            end.next = null;
            //开始翻转链表，采用头插法
            ListNode temp = null;
            ListNode localHead = null;
            while (first != null)
            {
                temp = first.next;
                first.next = localHead;
                localHead = first;
                first = temp;
            }//翻转完成

            first = localHead;
            while (localHead.next != null)
            {
                localHead = localHead.next;
            }
            end = localHead;

            //再次将链表接上
            if (ansFirst!=null)
                ansFirst.next = first;
            end.next = ansEnd;
            if (m == 1)
                return first;
            else
                return ansHead;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

}

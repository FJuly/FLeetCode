using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.链表
{
    //很简单的过程,head1存放小于x的节点，head2存放大于x的节点，注意细节问题
    //https://leetcode.com/problems/partition-list/
    class PartitionList
    {
        static void Main11(string[] args)
        {

        }

        //较为简洁的代码
        public static ListNode Partition(ListNode head, int x)
        {
            ListNode head1 = new ListNode(0), head2 = new ListNode(0);
            ListNode small = head1;
            ListNode big = head2;
            if (head == null)
                return head;
            while (head != null)
            {
                if (head.val < x)
                {
                    small.next = head;
                    head = head.next;
                    small = small.next;
                    small.next = null;
                }
                else
                {
                    big.next = head;
                    head = head.next;
                    big = big.next;
                    big.next = null;
                }
            }
            small.next = head2.next;    
            return head1.next;
        }
    }

    //接下来的题目：
    //1. https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/
    //2. https://leetcode.com/problems/remove-element/
    //3. https://leetcode.com/problems/substring-with-concatenation-of-all-words/
}

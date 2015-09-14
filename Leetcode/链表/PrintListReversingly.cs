using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.链表
{
    //从尾到头打印链表
    class PrintListReversingly
    {
        static void Main11(string[] args)
        {
            //ListNode node1 = new ListNode(1);
            //ListNode node2 = new ListNode(2);
            //ListNode node3 = new ListNode(3);
            //node1.next = node2;
            //node2.next = node3;
            //PrintListReversingly_Recursively(node1);
            int a = 112;    
            a = a & 1;//使用
        }
        //使用递归打印，跟使用栈一样
        public static void PrintListReversingly_Recursively(ListNode head)
        {
            if (head == null)
                return;
            if (head != null)
            {
                PrintListReversingly_Recursively(head.next);
                Console.WriteLine(head.val);
            }
        }
    }
}

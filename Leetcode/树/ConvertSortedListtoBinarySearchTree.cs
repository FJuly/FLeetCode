using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.树
{
    //LeetCode 109:https://leetcode.com/problemset/algorithms/
    class ConvertSortedListtoBinarySearchTree
    {
        private ListNode current = null;
        public TreeNode SortedListToBST(ListNode head)
        {
            current = head;
            int length = 0;
            while (head != null)
            {
                length++;
                head = head.next;
            }
            if (length == 0)
                return null;
            return help(1,length);
        }

        //模拟中序遍历构造二叉树
        private TreeNode help(int begin,int end)
        {
            if (begin > end)//这里的判断很重要，跟数组很像
                return null;
            int mid = (begin + end) / 2;
            TreeNode left=help(begin,mid-1);//按照中序遍历的顺序先构造左子树
            TreeNode node = new TreeNode(current.val);
            node.left = left;
            current = current.next;
            node.right = help(mid + 1, end);//再构造右子树
            return node;
        }
    }


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.树
{
    //LeetCode:https://leetcode.com/problems/flatten-binary-tree-to-linked-list/
    //Flatten Binary Tree to Linked List 114
    //前序遍历，last是链表最后一个节点，然后使用前序遍历，遍历一个节点就在last插入这个节点
    //在遍历的过程中树的结构会被打乱，所以中间变量也就是left right会被保存下来
    class FlattenBinaryTreetoLinkedList
    {
        private TreeNode last = null;
        public void Flatten(TreeNode root)
        {
            if (root == null)
                return;
            if (last != null)
            {
                last.left = null;
                last.right = root;
            }
            last = root;
            TreeNode left = root.left;
            TreeNode right = root.right;
            if (left != null)
            {
                Flatten(left);
            }
            if (right != null)
            {
                Flatten(right);
            }
        }
    }
}

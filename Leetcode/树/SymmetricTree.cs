using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.树
{
    //LeetCode:
    //直接比较对称位置：left的right和right的left比较，left的left和right的right比较
    class SymmetricTree
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
                return false;
            return help(root.left, root.right);
        }

        private bool help(TreeNode node1, TreeNode node2)
        {
            if (node1 == null && node2 == null)
                return true;
            if (node1 == null || node2 == null)
                return false;
            return (node1.val == node2.val) && (help(node1.left, node2.right)) && (help(node1.right, node2.left));
        }

        //相似的一道题，将一颗二叉树转成它的镜像，剑指offer面试题19题
        public void MirrorRecursively(TreeNode head)
        {
            if (head == null)
                return;
            if (head.left == null && head.right == null)
                return;

            TreeNode temp = head.right;

            head.left = head.right;
            head.right = temp;

            if (head.left != null)
                MirrorRecursively(head.left);
            if (head.right != null)
                MirrorRecursively(head.right);
        }
    }
}

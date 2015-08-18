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
    }
}

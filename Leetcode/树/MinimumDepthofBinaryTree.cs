using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.树
{
    //LeetCode 111: https://leetcode.com/problems/minimum-depth-of-binary-tree/
    class MinimumDepthofBinaryTree
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            int MinDepth = 0;
            MinDepth = NodeDepth(root);
            return MinDepth;
        }

        private int NodeDepth(TreeNode node)
        {
            if (node == null)
                return 0;
            //左边节点的最小深度
            int left = NodeDepth(node.left);
            //右边节点的最小深度
            int right = NodeDepth(node.right);
            if (left == 0) return right + 1;
            if (right == 0) return left + 1;
            return Math.Min(left, right) + 1;
        }
    }
}

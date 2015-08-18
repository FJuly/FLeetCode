using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.树
{
    //二叉树搜索树定义,中序遍历的思想
    class ValidateBinarySearchTree
    {
        private TreeNode pre=null;
        public bool IsValidBST(TreeNode root)
        {
            if (root == null)
                return true;
            return Inorder(root);
        }

        //可以看懂里面的逻辑，但是不是很理解为什么这样写，先放这里
        public bool Inorder(TreeNode node)
        {
            if (node == null)
                return true;
            if (!Inorder(node.left)) return false;
            if (pre != null && node.val <= pre.val) return false;
            pre = node;
            return Inorder(node.right);
        }
    }
}

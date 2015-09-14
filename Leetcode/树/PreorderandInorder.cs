using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.树
{
    //挺难理解的，LeetCode 105：https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/
    //参考博客：http://blog.163.com/zhe_wang_2009/blog/static/17228212120114482457713/
    class PreorderandInorder
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            TreeNode node = Make(preorder, inorder, 0, preorder.Length - 1, 0, inorder.Length - 1);
            return node;
        }

        private TreeNode Make(int[] preorder, int[] inorder, int prebegin, int preend, int inbegin, int inend)
        {
            //递归结束条件
            if (prebegin > preend)
                return null;

            int i = inbegin;
            while (preorder[prebegin] != inorder[i])
                i++;
            TreeNode node = new TreeNode(inorder[i]);
            node.left = Make(preorder, inorder, prebegin + 1, prebegin + i - inbegin, inbegin, i - 1);
            node.right = Make(preorder, inorder, prebegin + i - inbegin + 1, preend, i + 1, inend);
            return node;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; } 
    }
}

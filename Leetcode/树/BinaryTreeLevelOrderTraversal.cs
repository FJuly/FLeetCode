using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.树
{
    //利用队列实现二叉树的层序遍历,思路很简单
    //LeetCode 102
    class BinaryTreeLevelOrderTraversal
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            if (root == null)
                return null;
            List<IList<int>> level = new List<IList<int>>();
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            int length = q.Count;
            while (length != 0)
            {
                List<int> list = new List<int>();
                for (int i = 1; i <= length; i++)
                {
                    TreeNode node = q.Dequeue();
                    list.Add(node.val);
                    if (node.left != null)
                        q.Enqueue(node.left);
                    if (node.right != null)
                        q.Enqueue(node.right);
                }
                if (list.Count != 0)
                    level.Add(list);
                length = q.Count;
            }
            return level;
        }
    }
}

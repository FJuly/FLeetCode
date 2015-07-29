using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{

    /*题目链接:https://leetcode.com/submissions/detail/25266270/*/
    public class PathSum
    {
        public int pathSum = 0;

        public bool HasPathSum(TreeNode root, int sum)
        {

            return Traverse(root, sum);
        }

        public bool Traverse(TreeNode root, int sum)
        {
            if (root == null)
            {
                return false;
            }
            /*代表是叶子节点*/
            if (root.left == null && root.right == null)
            {
                pathSum = pathSum + root.val;
                if (pathSum == sum)
                    return true;
                else
                {
                    pathSum = pathSum - root.val;
                    return false;
                }
            }
            pathSum = pathSum + root.val;
            /*如果左右节点都返回false，则将这个节点去除，并返回false*/
            if (false == Traverse(root.left, sum) && false == Traverse(root.right, sum))
            {
                pathSum = pathSum - root.val;
                return false;
            }
            else
            {
                return true;//左右节点只要有一个节点返回true，则就返回true
            }
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

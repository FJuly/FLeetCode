using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.树
{
    //leetCode 100:https://leetcode.com/problems/same-tree/
    //判断两颗二叉树是不是一样，这种写法比较好
    class SameTree
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return true;
            else if (p == null || q == null)
                return false;
            return (p.val == q.val) && IsSameTree(p.left, q.left) && IsSameTree(p.right,q.right);
        }
    }
}

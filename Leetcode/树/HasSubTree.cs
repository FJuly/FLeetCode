using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.树
{
    class HasSubTree
    {
        public bool HasSubTreeSolution(TreeNode mainHead, TreeNode subHead)
        {
            //二叉树中递归结束条件可以是很多种
            bool result = false;
            if (mainHead != null && subHead != null)
            {
                if (mainHead.val == subHead.val)
                {
                    result = IsSame(mainHead, subHead);
                }
                if (!result)
                    result = HasSubTreeSolution(mainHead.left, subHead);
                if (!result)
                    result = HasSubTreeSolution(mainHead.right, subHead);
            }
            return result;
        }

        private bool IsSame(TreeNode mainHead, TreeNode subHead)
        {
            if (subHead == null)
                return true;
            if (mainHead == null)
                return false;
            return (mainHead.val == subHead.val) && IsSame(mainHead.left, subHead.left) && IsSame(mainHead.right, subHead.right);
        }
    }
}

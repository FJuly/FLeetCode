using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.树
{
    //树的遍历和动态规划的思想，比较好理解
    class BinaryTreeMaximumPathSum
    {
        public int MaxPathSum(TreeNode root)
        {
            int Max = root.val;
            RootValue(root, ref Max);
            return Max;
        }

        private int RootValue(TreeNode root, ref int Max)
        {
            if (root == null)
                return 0;
            int rootmax = root.val;
            int left = RootValue(root.left, ref Max);
            int right = RootValue(root.right, ref Max);
            //求出以root为节点的最大值
            rootmax = Math.Max(rootmax, root.val + left);
            rootmax = Math.Max(rootmax, root.val + right);

            //为什么不对！！！我知道了，root父亲的最大值不可能出现这种情况root.val + right + left，多画点图就明白了
            Max = Math.Max(Math.Max(rootmax,Max), root.val + right + left);

            //求到现在这个root节点为止的最大值
            //Max = Math.Max(rootmax, Max);
            return rootmax;
        }
    }
}

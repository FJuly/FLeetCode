using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.树
{
    //LeetCode 108:https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/
    //使用二分法即可
    class ConvertSortedArraytoBinarySearchTree
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums.Length == 0)
                return null;
            return help(nums, 0, nums.Length - 1);
        }

        private TreeNode help(int[] nums, int begin, int end)
        {
            if (begin < end)
                return null;
            int mid = (begin + end) / 2;
            TreeNode node = new TreeNode(nums[mid]);
            node.right = help(nums, mid + 1, end);
            node.left = help(nums, begin, mid - 1);
            return node;
        }

    }
}

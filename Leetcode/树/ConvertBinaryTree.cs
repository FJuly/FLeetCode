using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.树
{
    //将一颗二叉排序树转成双向链表
    class ConvertBinaryTree
    {
        public static void Main11()
        {
            TreeNode node1 = new TreeNode(2);
            TreeNode node2 = new TreeNode(1);
            TreeNode node3 = new TreeNode(3);
            node1.left = node2;
            node1.right = node3;
            Convert(node1);
            Console.ReadLine();
        }
        private static TreeNode last = null;//代表链表最后一个节点
        public static void Convert(TreeNode node)
        {
            if (node == null)
                return;
            if (node.left != null)
                Convert(node.left);
            //链表指向下一个节点使用left，指向上一个节点是用right
            node.left = last;
            if (last != null)
                last.right = node;
            last = node;
            if (node.right != null)
                Convert(node.right);
        }
    }
}

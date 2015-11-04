using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.树
{

    //给定一个后续序列，判断是不是一个二叉排序树的后续遍历
    class VerifySequenceOfBST
    {
        public static void Main11()
        {
            int[] num = {7,4,6,5};
            bool result=VerifySequenceOfBSTSolution(num,0,3);
        }
        public static bool VerifySequenceOfBSTSolution(int[] array,int begin,int end)
        {
            if (begin == end)
                return true;
            int root = array[end];
            int i = begin;
            for (; array[i] < root; i++) ;
            int j=i;
            for (; j < end; j++)
            {
                if (array[j] < array[end])
                    return false;
            }
            bool left = true;
            if (i > begin)
            {
                left=VerifySequenceOfBSTSolution(array,begin,i-1);
            }
            bool right = true;
            if (i < end)
            {
                right = VerifySequenceOfBSTSolution(array,i,end-1);
            }
            return left && right;
        }
    }
}










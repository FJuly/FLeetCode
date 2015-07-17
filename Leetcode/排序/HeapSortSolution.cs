using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
   /// <summary>
   /// 堆排序实现
   /// </summary>
    public class HeapSortSolution
    {
        public int[] HeapSort(int[] arry)
        {
            /*建立堆*/
            int length = arry.Length;
            for (int i = length / 2; i > 0; i--)
            {
                HeapAdjust(arry, i, length);//i为逻辑上的位置，实际位置是i-1，这样是为了利用完全二叉树的性质
            }

            /*开始排序*/
            for (int i = length; i > 1; i--)
            {
                Swap(arry,i,1);
                HeapAdjust(arry,1,i-1);
            }
            return arry;
        }

        /*堆排序的核心*/
        private void HeapAdjust(int[] arry, int s, int m)
        {
            int temp = arry[s-1];
            int j;
            for (j = 2 * s; j <= m; j = 2 * j)
            {
                if (j < m && arry[j-1] < arry[j])
                    j = j + 1;
                if (arry[j-1] <= temp)
                    break;
                arry[s-1] = arry[j-1];
                s = j;
            }
            //这种写法比较巧妙
            arry[s-1] = temp;
        }

        private void Swap(int[] arry, int index1, int index2)
        {
            int temp = arry[index1-1];
            arry[index1-1] = arry[index2-1];
            arry[index2-1] = temp;
        }
    }
}

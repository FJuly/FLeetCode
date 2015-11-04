using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.数组
{
    //求数组逆序对的数目
    class InversePairs
    {
        public static int sum = 0;

        public static void Main11()
        {
            int[] num = {7,5,6,4 };
            MergeSort(num,0,3); 
        }
        //先写一个归并排序，先写递归的排序，再写一个迭代的
        public static void MergeSort(int[] num, int begin, int end)
        {
            if (begin == end)
                return;
            int mid = (begin + end) / 2;
            MergeSort(num, begin, mid);
            MergeSort(num, mid + 1, end);
            //开始合并
            Merge(num,begin,mid,end);
        }


        private static void Merge(int[] num, int begin, int mid, int end)
        {
            //这里需要一个辅助的数组
            int[] helpNum = new int[end - begin + 1];
            int i = begin, j = mid + 1;
            int cur = 0;//用作辅助数组的下标
            while (i <= mid && j <= end)
            {
                if (num[i] <= num[j])
                {
                    helpNum[cur] = num[i];
                    i++;
                }else
                {
                    helpNum[cur] = num[j];
                    sum+=(j - mid);
                    j++;

                }
                cur++;
            }

            while (i <= mid)
            {
                helpNum[cur] = num[i];
                i++;
                cur++;
            }
            while (j <= end)
            {
                helpNum[cur] = num[j];
                j++;
                cur++;
            }
            //将数组复制会原数组
            i = 0;
            for (; begin <= end; begin++, i++)
            {
                num[begin] = helpNum[i];
            }
        }
    }
}
 
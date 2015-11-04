using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.数组
{
    class GetLeastNumbers
    {

        public static void Main11()
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int key = GetLastNumbers(num, 7);
        }

        //找到第k小的数
        public static int GetLastNumbers(int[] num, int k)
        {
            int begin = 0, end = num.Length - 1;
            int index = Partition(num, begin, end);
            while (index != k)
            {
                if (index < k)
                {
                    begin = index + 1;
                    index = Partition(num, begin, end);
                }
                if (index > k)
                {
                    end = index - 1;
                    index = Partition(num, begin, end);
                }
            }
            return index;
        }

        //partition过程
        private static int Partition(int[] num, int begin, int end)
        {
            int pivot = num[begin];//选举第一个作为中心点
            while (begin < end)
            {
                while (begin < end && num[end] >= pivot)
                    end--;
                num[begin] = num[end];
                while (begin < end && num[begin] <= pivot)
                    begin++;
                num[end] = num[begin];
            }
            num[begin] = pivot;
            return begin;
        }
    }
}

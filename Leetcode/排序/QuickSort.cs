using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.排序
{
    class QuickSort
    {
        public static void Main()
        {
            int[] num = {5,2,5,6,7,8,2,3,4,5,6,9,1};
            QuickSortSolution(num,0,12);
        }
        private static  int partition(int[] array, int low, int high)
        {
            int temp = low;
            //选取中心点 pivotkey
            int pivotkey = array[low];//暂且定为第一个元素,可以随机选取
            //开始partition
            while (low < high)
            {
                while (low < high && array[high] >= pivotkey)//
                    high--;
                Swap(array, low, high);

                while (low < high && array[low] <= pivotkey)
                    low++;
                Swap(array, low, high);//当low==high的时候也会交换,不过没什么关系

            }
            //Swap(array,temp,low);
            return low;
        }


        private static void Swap(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        public static void QuickSortSolution(int[] array, int start, int end)
        {
            int pivot;
            while (start < end)//尾递归优化时注意这是一个while，没有优化时候是if
            {
                pivot = partition(array, start, end);
                QuickSortSolution(array, start, pivot - 1);
                ///QuickSortSolution(array, pivot + 1, end);
                start = pivot + 1;//尾递归优化
            }
        }
    }
}
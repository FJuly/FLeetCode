using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    /*桶排序 元素间的最大距离*/
    public class MaximumGap
    {
        public int maximumGap(int[] nums)
        {
            int length = nums.Length;
            if (length < 2)
                return 0;
            /*List里面放的是值类型是怎么样的*/
            //List<Bucket> buckets = new List<Bucket>(length + 1);
            Bucket[] buckets = new Bucket[length + 1];

            //初始化数组
            for (int i = 0; i < length + 1; i++)
            {
                buckets[i].min = int.MaxValue;
                buckets[i].max = int.MinValue;
            }

            //找出最大值和最小值
            int min = nums[0], max = nums[0];
            for (int i = 1; i < length; i++)
            {
                if (nums[i] > max)
                    max = nums[i];
                if (nums[i] < min)
                    min = nums[i];
            }
            /*将每个元素放入到正确的桶中*/
            int dis = (max - min) / length + 1;//这个距离怎么去定
            for (int i = 0; i < length; i++)
            {
                int cur;
                if (nums[i] == max)//最大值的时候特殊处理
                {
                    cur = length;
                }
                else
                {
                    cur = (nums[i] - min)/dis;//获取桶的下标

                }
                /*当桶中只有一个元素的收最大值和最小值的值是一样的*/
                if (buckets[cur].max < nums[i])
                    buckets[cur].max = nums[i];
                if (buckets[cur].min > nums[i])
                    buckets[cur].min = nums[i];
            }

            /*扫每一个桶 找出最大值,为什么需要length+1只桶，因为length+1只桶内只需要保持一个最大值和最小值就行了，就不需要进行排序了*/
            int MaxGap = 0, previous = 0;//previous来记录前一个桶，这种处理方法比较好
            for (int i = 1; i < buckets.Length; i++)
            {
                if (buckets[i].min == int.MaxValue)//代表是空桶
                    continue;
                if ((buckets[i].min - buckets[previous].max) > MaxGap)
                {
                    MaxGap = buckets[i].min - buckets[previous].max;
                }
                previous = i;
            }
            return MaxGap;
        }
    }

    public struct Bucket
    {
        public int min;//存储每个桶中的最小值
        public int max;//存储每个桶中的最大值
    }
}

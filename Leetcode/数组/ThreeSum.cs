using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class ThreeSum
    {
        /*算法的核心在于两边扫*/
        public IList<IList<int>> ThreeSumSolution(int[] nums, int target)
        {
            IList<IList<int>> list = new List<IList<int>>();//泛型接口的协变和逆变
            int length = nums.Length;
            //对数组进行一个排序，使用快排算法
            Array.Sort(nums);
            int pre = int.MaxValue;
            for (int i = 0; i < length-2; i++)
            {
                if (nums[i] == pre)
                {
                    continue;
                }
                else
                {
                    pre = nums[i];//记录下这次的数字，排重之用
                    //在i...length中找出和为target-nums[i]的两个数
                    int head = i + 1;
                    int tail = length - 1;
                    /*后两个元素也有可能重复，排除重复*/
                    int preHead = int.MaxValue;
                    int preTail = int.MaxValue;
                    while (head < tail)
                    {
                        if ((nums[head] + nums[tail]) == (target - nums[i]))
                        {
                            if (preHead != nums[head] || preTail != nums[tail])
                            {
                                IList<int> firstList = new List<int>();
                                firstList.Add(nums[i]);
                                firstList.Add(nums[head]);
                                firstList.Add(nums[tail]);
                                list.Add(firstList);
                                preHead = nums[head];
                                preTail = nums[tail];
                            }
                            head++;
                            tail--;
                            continue;
                        }
                        else if ((nums[head] + nums[tail]) > (target - nums[i]))
                        {
                            tail--;
                        }
                        else
                        {
                            head++;
                        }
                    }
                }
            }
            return list;
        }
    }
}

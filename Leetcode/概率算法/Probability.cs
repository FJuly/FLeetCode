using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Leetcode.概率算法
{
    class Probability
    {
        static void Main11(string[] args)
        {
            int[] arry = new int[100];
            int[] weight = new int[100];
            Random radom = new Random();
            for (int i = 0; i < 100; i++)
            {
                arry[i] = i;
                weight[i] = radom.Next(100);
            }

            while (true)
            {
                int result = WeightSamp(arry,weight);
                Console.WriteLine(result);
                Thread.Sleep(100);
            }
        }
        //问题1：假设一个随机数发生器rand7均匀产生1到7之间的随机整数，如何构造rand10，均匀产生1-10之间的随机整数？
        //解决方法一：1-7之间有4个奇数，3个偶数，我们扔掉一个奇数,比如7，这样剩余3个奇数，
        //3个偶数产生的概率相同——我们构造了一个0-1整数的均匀产生器，用它产生4个bit，对应表示整数0..15, 保留1..10就可以了
        public static int Arand10()
        {
            Random radom = new Random();
            int result = 0;
            int i = 0;//循环计数使用的
            int cur = radom.Next(8);
            while (cur != 7)
            {
                if (cur % 2 == 0)
                {
                    result = (result << 1) | 0;
                }
                else
                {
                    result = (result << 1) | 1;
                }
                cur = radom.Next(8);
                i++;
                if (i == 4)
                {
                    if (result <= 10)//result<10丢掉
                        break;
                    else
                    {
                        result = 0;
                        i = 0;
                    }
                }
            }
            return result;
        }

        //解决方法二：我们把1-7减去1，变为0-6。产生一个两位的七进制数，对应0-48，
        //我们把40-48扔掉（因为这只有9个数），其余按照个位数字分类，0-9对应我们要的1-10
        public static int Brand10()
        {
            Random radom = new Random();
            int cur1 = radom.Next(8);
            int cur2 = radom.Next(8);
            int result = cur1 * 7 + cur2;
            while (result > 40)
            {
                cur1 = radom.Next(8);
                cur2 = radom.Next(8);
                result = cur1 * 7 + cur2;
            }
            result = result % 10 + 1;
            return result;
        }

        //问题二：不均匀随机数发生器构造均匀
        //一个随机数发生器，不均匀，以概率p产生0，以(1-p)产生1， (0<p<1),构造一个均匀的随机数发生器 
        //分析：产生两次，(0,1)的概率与(1,0)的概率相同都是p * (1 – p)。
        //现在想要构造1-10之间的随机数，则可以使用4位，当随机数产生（1，0）的时候产生1，当随机数产生（0，1）的时候产生0即可


        //问题三：水库（Reservoir）采样
        //题目描述：流入若干个对象（整数），事先不知道个数。如何随机取出k个 （k小于总数）？
        //解决方法：用一个数组a保存k个数 a[0..k -1]
        //对于第i个元素(i = 1,2,…)，如果i <= k： 则a[i -1]存放这个元素
        //否则：产生随机数x = rand() % i
        //若x < k,则用a[x]存放这个元素（扔掉之前的元素）
        //简单证明：假设目前已经流入n > k个元素
        //第i( i <= k)个元素被选中的可能性，1 * k / (k + 1) * (k + 1) / (k + 2) *…*(n -1) / n = k / n（第一次被选中的概率*以后不被换掉的概率）
        //第i (i > k)个元素被选中的可能性，k / i * i / (i + 1) * (i + 1) / (i + 2) *…* (n – 1) / n = k / n（第一次选中的概率*以后不被换掉的概率）
        public static int[] Reservoir(int k)
        {
            int[] arry = new int[k];
            Flow flow = new Flow();
            int i = 0;
            while (!flow.IsEnd())
            {
                int cur = flow.GetNext();
                if (i < k)
                {
                    arry[i] = cur;
                    i++;
                }
                else
                {
                    int random = (new Random().Next()) % i;
                    if (random < k)
                    {
                        arry[random] = cur;
                        i++;
                    }
                }
            }
            return arry;
        }

        //问题四：用数组a[0..n -1]随机产生一个全排列,算法导论上的题目，上面有证明
        public static int[] RndomShuffle(int n)
        {
            int[] arry = new int[n];
            for (int i = 0; i < n; i++)
            {
                arry[i] = i;
            }

            for (int i = 0; i < n; i++)
            {
                int index = new Random().Next() % (n - i) + i;
                Swap(arry, index, i);
            }
            return arry;
        }

        public static void Swap(int[] arry, int index1, int index2)
        {
            int temp = arry[index1];
            arry[index1] = arry[index2];
            arry[index2] = temp;
        }


        //问题5：带权采样问题
        //给定n种元素，再给定n个权值，按权值比例随机抽样一个元素。为了方便我们可以假设权值全是整数
        //比较好的解法：先按1/m的概率随机选择一种元素
        //再产生随机数根据权值决定能否选择这种元素，如果能则选取它并结束，否则返回（1）
        //Pi1 = Wi / Wtot  或Pi2 ＝Wi  / Wmax 无关紧要（正比于Wi）
        //证明：
        public static int WeightSamp(int[] arry, int[] weight)
        {
            int result = 0;
            int length = arry.Length;
            int max = weight.Max();//找出最大的权重
            Random radom = new Random();
            while (true)
            {
                int cur1 = radom.Next(length);//随机选取一个数
                int cur2 = radom.Next(max + 1);
                if (weight[cur1] <= cur2)
                {
                    result = cur1;
                    break;
                }
            }
            return result;
        }
    }

    //模拟数据流
    public class Flow
    {
        private int[] arry;
        private int cur = -1;

        public Flow()
        {
            arry = new int[100];
            for (int i = 0; i < 100; i++)
            {
                arry[i] = i;
            }
        }

        public int GetNext()
        {
            cur++;
            return arry[cur];
        }

        public bool IsEnd()
        {
            if (cur < 99)
                return false;
            else
                return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    /*参考资料:http://zh.wikipedia.org/wiki/%E7%B7%A8%E8%BC%AF%E8%B7%9D%E9%9B%A2*/
    public class EditDistance
    {
        public int MinDistance(string word1, string word2)
        {
            int length1 = word1.Length;
            int length2 = word2.Length;
            int[,] dis = new int[length1 + 1, length2 + 1];
            int i = 0, j = 0;
            for (i = 0; i <= length1; i++)
            {
                for (j = 0; j <= length2; j++)
                {
                    /*i==0表示这个字符串为空*/
                    if (i == 0)
                    {
                        dis[i, j] = j;
                    }
                    else if (j == 0)
                    {
                        dis[i, j] = i;
                    }
                    else
                    {
                        dis[i, j] = Math.Min(dis[i - 1, j] + 1, Math.Min(dis[i, j - 1] + 1, (word1.Substring(i - 1, 1).Equals(word2.Substring(j - 1, 1))) ? dis[i - 1, j - 1] : dis[i - 1, j - 1] + 1));
                    }
                }
            }
            return dis[length1, length2];
        }
    }
}

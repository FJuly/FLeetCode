using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ClimbingStairs
    {
        /*即为斐波那契数列*/
        public int ClimbStairs(int n)
        {
            int n1=1, n2=2;
            if (n == 1)
                return n1;
            if (n == 2)
                return n2;
            int current = 0;
            for (int i = 3; i <=n; i++)
            {
                current = n1 + n2;
                n1 = n2;
                n2 = current;
            }
            return current;
        }
    }
}

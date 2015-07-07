using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    /*leetcode 64题，使用动态规划,题目链接：https://leetcode.com/problems/minimum-path-sum/*/
    public class MinimumPathSum
    {
        public int MinPathSum(int[,] grid)
        {
            int row = grid.GetLength(0);//行数
            int column = grid.GetLength(1);//列数
            int i = 0, j = 0;
            int[,] MinResult = new int[row, column];
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < column; j++)
                {
                    if (i == 0)
                    {
                        if (j == 0)
                            MinResult[i, j] = grid[0, 0];
                        else
                        {
                            MinResult[i, j] = MinResult[i, j - 1] + grid[i, j];
                        }
                    }
                    else
                    {
                        if (j == 0)
                        {
                            MinResult[i, j] = MinResult[i - 1, j] + grid[i, j];
                        }
                        else
                        {
                            MinResult[i, j] = Math.Min(MinResult[i - 1, j], MinResult[i, j - 1]) + grid[i, j];
                        }
                    }
                }
            }

            return MinResult[i - 1, j - 1];
        }
    }
}

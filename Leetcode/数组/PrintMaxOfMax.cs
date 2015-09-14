using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.数组
{
    //打印1到n位数最大值的所有数,非常巧妙
    class PrintMaxOfNDigits
    {
        public static void Main11()
        {
            PrintMaxOfNDigitsSolution(3);
        }
        public static void PrintMaxOfNDigitsSolution(int n)
        {
            //n代表n位数
            char[] num = new char[n];
            PrintMaxOfNDigitsRecursively(num, 0, n);
        }

        private static void PrintMaxOfNDigitsRecursively(char[] num, int index, int n)
        {
            if (index == n)
            {
                foreach (char c in num)
                {
                    Console.Write(c.ToString());
                }
                Console.WriteLine();
                return;
            }
            for (int i = 0; i < 10; i++)
            {
                num[index] = char.Parse(i.ToString());
                PrintMaxOfNDigitsRecursively(num, index+1, n);
            }
        }
    }
}

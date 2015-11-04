using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class TEST
    {
        static void Main(string[] args)
        {
            //"SoriEYVzZDtnWCFAKUONgPaplIybQHmM"
            //"SoriEYVzZDtnWCFAKUONgPaplIybQHmM"

            //string line;
            while (true)
            {
                string line;
                line = Console.ReadLine();
                HashSet<char> hash = new HashSet<char>();

                StringBuilder sb = new StringBuilder();
                foreach (char c in line)
                {
                    if (!hash.Contains(c))
                    {
                        hash.Add(c);
                        sb.Append(c);
                    }
                }
                Console.WriteLine(sb.ToString());
            }
            //string line;
            //while ((line = System.Console.ReadLine()) != null)
            //{
            //    int n = Convert.ToInt32(line);
            //    int[] array = new int[n];
            //    for (int i = 0; i < n; i++)
            //    {
            //        array[i] = i;
            //    }
            //    int cur = 0;
            //    int count = 0;
            //    int j = 0;
            //    int len = n;
            //    while (len > 0)
            //    {
            //        if (array[j] != -1)
            //        {
            //            count++;
            //            if (count == 3)
            //            {
            //                array[j] = -1;
            //                len--;
            //                count = 0;
            //                cur = j;
            //            }
            //        }
            //        j++;
            //        if (j == n)
            //            j = 0;
            //    }
            //    Console.WriteLine(cur);
            //}
        }
    }
}

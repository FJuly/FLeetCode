using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class LongestPalindrome
    {
        /*哇咔咔，好恶心！！！思路很简单~ LeetCode 5:https://leetcode.com/submissions/detail/34485975/*/
        public string LongestPalindromeSolution(string s)
        {
            if (string.IsNullOrEmpty(s))
                return null;
            string LongestStr="";
            int max=0;
            for (int i = 0; i < s.Length; i++)
            {
                int len1,len2;
                len1 = Palindrome(s,i,i);
                len2 = Palindrome(s, i, i+1);
                if (len1 >= len2)
                {
                    if (max < len1)
                    {
                        max = len1;
                        int dis = len1 / 2;
                        LongestStr = s.Substring(i-dis,len1);//这里的i-dis自己推导一下
                    }
                }
                else
                {
                    if (max < len2)
                    {
                        max = len2;
                        int dis = len2 / 2;
                        LongestStr = s.Substring(i - dis + 1, len2);
                    }
                }
            }
            return LongestStr;
        }

        //返回以i为中心或者以i、i+1为中心的回文串长度
        public int Palindrome(string s,int first,int second)
        {
            //secon为最后一个
            if (second >= s.Length)
                return 0;
            //如果是i、i+1且不想等，长度为0
            if (first != second && s[first] != s[second])
                return 0;
            while (first>=0&&second<s.Length&&s[first] == s[second])
            {
                first--;
                second++;
            }
            return second - first-1;
        }
    }
}

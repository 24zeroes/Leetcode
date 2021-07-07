using System;

namespace N_9_PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().IsPalindrome(10));
        }
    }
    
    public class Solution 
    {
        public bool IsPalindrome(int x)
        {
            var s = x.ToString();
            var left = 0;
            var right = s.Length - 1;
            var error = false;
            while (right > left)
            {
                if (s[left] != s[right])
                {
                    error = true;
                    break;
                }

                right -= 1;
                left += 1;
            }
            
            return !error;
        }
    }
}
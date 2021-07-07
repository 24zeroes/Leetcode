using System;

namespace N_7_ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().Reverse(-123));
        }
    }
    
    public class Solution 
    {
        public int Reverse(int x)
        {
            var str = x.ToString();
            var belowZero = false;
            if (str[0] == '-')
            {
                str = str.Substring(1, str.Length - 1);
                belowZero = true;
            }

            var result = "";
            
            for (int i = str.Length - 1; i >= 0; i--)
            {
                result += str[i];
            }

            if (!int.TryParse(result, out var resultInt))
            {
                return 0;
            }
            
            if (belowZero)
            {
                resultInt *= -1;
            }
            return resultInt;
        }
    }
}
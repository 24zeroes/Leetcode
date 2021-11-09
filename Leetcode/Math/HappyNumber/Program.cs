using System;
using System.Collections.Generic;

namespace HappyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            var r = s.Solve(123);
            Console.WriteLine("Hello World!");
        }
        
    }

    class Solution
    {
        private int getNext(int n)
        {
            var res = 0;
            while (n != 0)
            {
                var digit = n % 10;
                n = n / 10;
                res += digit * digit;
            }

            return res;
        }
        public bool Solve(int n)
        {
            var map = new Dictionary<int, bool>();
            while (n != 1 && !map.ContainsKey(n))
            {
                map[n] = true;
                n = getNext(n);
            }

            return n == 1;
        }
    }
}
using System;

namespace SumOfTwoIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            s.Solve(2, 3);
            Console.WriteLine("Hello World!");
        }
    }

    class Solution
    {
        public int Solve(int a, int b)
        {
            while (b != 0)
            {
                int carry = a & b;
                a = a ^ b;
                b = carry << 1;
            }
            return a;
        }
    }
}
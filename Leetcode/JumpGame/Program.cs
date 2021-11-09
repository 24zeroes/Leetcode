using System;

namespace JumpGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            var r = s.Solve(new[] {3, 2, 1, 1, 4});
            Console.WriteLine("Hello World!");
        }
    }

    class Solution
    {
        public bool Solve(int[] inp)
        {
            var lastGoodPosition = inp.Length - 1;
            for (var i = inp.Length - 1; i >= 0; i--)
            {
                if (i + inp[i] >= lastGoodPosition)
                {
                    lastGoodPosition = i;
                }
            }

            return lastGoodPosition == 0;
        }
    }
}
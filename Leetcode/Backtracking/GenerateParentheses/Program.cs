using System;
using System.Collections.Generic;

namespace GenerateParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            var result = solution.Solve(3);
            Console.WriteLine("End");
        }
    }

    class Solution
    {
        private List<string> Result { get; set; }
        private int N { get; set; }
        public List<string> Solve(int n)
        {
            Result = new List<string>();
            N = n;
            SolveInternal(0, 0, "");
            return Result;
        }

        public void SolveInternal(int open, int close, string cur)
        {
            if (open + close == 2 * N)
            {
                Result.Add(cur);
            }

            if (open < N)
            {
                SolveInternal(open + 1, close, cur + "(");
            }

            if (close < open)
            {
                SolveInternal(open, close + 1, cur + ")");
            }
        }
    }
}
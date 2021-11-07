using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace LetterCombinationsPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            var r1 = s.Solve("");
            Console.WriteLine("Hello World!");
        }
    }

    class Solution
    {
        private Dictionary<char, string> Map = new Dictionary<char, string>
        {
            {'2', "abc"},
            {'3', "def"},
            {'4', "ghi"},
            {'5', "jlk"},
            {'6', "mno"},
            {'7', "pqrs"},
            {'8', "tuv"},
            {'9', "wxzy"}
        };
        private IList<string> Result { get; set; }
        private string Input { get; set; }
        
        public IList<string> Solve(string input)
        {
            Result = new List<string>();
            Input = input;

            Generate(0, new char[Input.Length]);
            return Result;
        }

        private void Generate(int l, char[] cur)
        {
            if (l == Input.Length)
            {
                var s = new string(cur);
                if (s != "")
                {
                    Result.Add(s);
                }
                
                return;
            }

            var key = Map[Input[l]];
            foreach (var ch in key)
            {
                cur[l] = ch;
                Generate(l + 1, cur);
            }
        }
    }
}
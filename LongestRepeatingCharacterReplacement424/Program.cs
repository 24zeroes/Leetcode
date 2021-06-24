using System;
using System.Collections.Generic;

namespace LongestRepeatingCharacterReplacement424
{
    public class TestCase
    {
        public string S { get; set; }
        public int K { get; set; }
    }
    
    class Program
    {
        public static TestCase Example1 = new TestCase {S = "ABAB", K = 2};
        public static TestCase Example2 = new TestCase {S = "AABABBA", K = 1};
        
        static void Main(string[] args)
        {
            var s = new Solution();
            Console.WriteLine(s.CharacterReplacement(Example2.S, Example2.K));
        }
    }
    public class Solution 
    {
        public int CharacterReplacement(string s, int k)
        {
            var left = 0;
            var seen = new Dictionary<char, int>();
            var result = 0;
            var maxLettersCount = 0;

            for (int right = 0; right < s.Length; right++)
            {
                if (!seen.ContainsKey(s[right]))
                {
                    seen.Add(s[right], 0);
                }
                seen[s[right]] += 1;

                maxLettersCount = Math.Max(seen[s[right]], maxLettersCount);

                while (right - left + 1 - maxLettersCount > k)
                {
                    var toRemove = s[left];
                    seen[toRemove] -= 1;

                    maxLettersCount = Math.Max(seen[toRemove], maxLettersCount);
                    left += 1;
                }

                result = Math.Max(result, right - left + 1);
            }
            
            return  result;
        }
    }
}
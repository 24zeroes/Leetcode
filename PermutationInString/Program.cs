using System;
using System.Collections.Generic;
using System.Linq;

namespace PermutationInString
{
    public class TestCase
    {
        public string S1 { get; set; }
        public string S2 { get; set; }
    }
    class Program
    {        
        public static TestCase Example1 = new TestCase {S1 = "ab", S2 = "eidbaooo"};
        public static TestCase Example2 = new TestCase {S1 = "ab", S2 = "eidboaoo"};
        public static TestCase Example3 = new TestCase {S1 = "ab", S2 = "ba"};
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().CheckInclusion(Example1.S1, Example1.S2));
        }
    }
    
    public class Solution 
    {
        public bool CheckInclusion(string s1, string s2)
        {
            if (s1.Length > s2.Length)
            {
                return false;
            }
            var checkHash = new Dictionary<char, int>();
            foreach (var ch in s1)
            {
                if (!checkHash.ContainsKey(ch))
                {
                    checkHash.Add(ch, 0);
                }
                checkHash[ch] += 1;
            }

            var currentHash = new Dictionary<char, int>();
            var left = 0;
            for (int right = 0; right < s2.Length; right++)
            {
                var ch = s2[right];

                if (!currentHash.ContainsKey(ch))
                {
                    currentHash.Add(ch, 0);
                }
                currentHash[ch] += 1;

                if (right - left + 1 == s1.Length)
                {
                    if (currentHash.Count == checkHash.Count && !currentHash.Except(checkHash).Any())
                    {
                        return true;
                    }

                    currentHash[s2[left]] -= 1;
                    if (currentHash[s2[left]] == 0)
                    {
                        currentHash.Remove(s2[left]);
                    }

                    left += 1;
                }
            }

            return false;
        }
    }
}
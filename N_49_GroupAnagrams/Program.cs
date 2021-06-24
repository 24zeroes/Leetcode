using System;
using System.Collections.Generic;

namespace N_49_GroupAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().GroupAnagrams(new [] {"eat","tea","tan","ate","nat","bat"}));
        }
    }
    public class Solution 
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var hashMaps = new Dictionary<char, int>[strs.Length];
            for (int i = 0; i < strs.Length; i++)
            {
                hashMaps[i] = new Dictionary<char, int>();
                foreach (var ch in strs[i])
                {
                    if (!hashMaps[i].ContainsKey(ch))
                    {
                        hashMaps[i].Add(ch, 0);
                    }

                    hashMaps[i][ch] += 1;
                }
            }

            var added = new bool[strs.Length];
            var result = new List<List<string>>();
            
            for (int i = 0; i < strs.Length; i++)
            {
                if (added[i] == true)
                {
                    continue;
                }
                result
                for (int j = 0; j < strs.Length; j++)
                {
                    
                }
            }

            return null;
        }
    }
}
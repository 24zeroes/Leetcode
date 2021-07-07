using System;
using System.Runtime;
namespace MinimumSizeSubarraySum209
{
    public class TestCase
    {
        public int Target { get; set; }
        public int[] Nums { get; set; }
    }
    
    
    class Program
    {
        public static TestCase Example1 = new TestCase {Nums = new[] {2, 3, 1, 2, 4, 3}, Target = 7};
        public static TestCase Example2 = new TestCase {Nums = new[] {1,4,4}, Target = 4};
        public static TestCase Example3 = new TestCase {Nums = new[] {1,1,1,1,1,1,1,1}, Target = 11};
        
        static void Main(string[] args)
        {
            var solution = new Solution();
            var result = solution.MinSubArrayLen(Example2.Target, Example2.Nums);
            Console.WriteLine(result);
        }
    }
    
    public class Solution 
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            var left = 0;
            var currentSum = 0;
            var minLength = int.MaxValue;
            var result = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                currentSum += nums[right];
                while (currentSum >= target)
                {
                    minLength = Math.Min(minLength, right - left + 1);
                    result = minLength;

                    currentSum -= nums[left];
                    left += 1;
                }
            }
            
            return result;
        }
    }
}
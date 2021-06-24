using System;

namespace ShortestSubarrayWithSumAtLeastK862
{
    public class TestCase
    {
        public int Target { get; set; }
        public int[] Nums { get; set; }
    }
    class Program
    {
        public static TestCase Example1 = new TestCase {Nums = new[] {1}, Target = 1};
        public static TestCase Example2 = new TestCase {Nums = new[] {1, 2}, Target = 4};
        public static TestCase Example3 = new TestCase {Nums = new[] {2, -1, 2}, Target = 3};
        public static TestCase Example4 = new TestCase {Nums = new[] {17, 85, 150, -45, -21}, Target = 150};
        public static TestCase Example5 = new TestCase {Nums = new[] {84,-37,32,40,95}, Target = 167};
        static void Main(string[] args)
        {
            var s = new Solution();
            Console.WriteLine(s.ShortestSubarray(Example5.Nums, Example5.Target));
        }
    }
    
    public class Solution 
    {
        public int ShortestSubarray(int[] nums, int k)
        {
            var minLength = int.MaxValue;
            
            var left = 0;
            var sum = 0;
            
            for (int right = 0; right < nums.Length; right++)
            {
                sum += nums[right];
                
                while (sum >= k)
                {
                    minLength = Math.Min(right - left + 1, minLength);
                    sum -= nums[left];
                    left += 1;
                }
            }
            
            return minLength == int.MaxValue ? -1 : minLength;
        }
    }
}
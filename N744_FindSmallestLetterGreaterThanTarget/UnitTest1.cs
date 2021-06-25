using NUnit.Framework;

namespace N744_FindSmallestLetterGreaterThanTarget
{
    public class Tests
    {
        private Solution Solution { get; set; }
        
        [SetUp]
        public void Setup()
        {
            Solution = new Solution();
        }

        [Test]
        public void Test1()
        {
            var result = Solution.NextGreatestLetter(new char[] { 'c', 'f', 'j'}, 'a');
            Assert.AreEqual('c', result);
        }
        
        [Test]
        public void Test2()
        {
            var result = Solution.NextGreatestLetter(new char[] { 'c', 'f', 'j'}, 'c');
            Assert.AreEqual('f', result);
        }
        
        [Test]
        public void Test3()
        {
            var result = Solution.NextGreatestLetter(new char[] { 'c', 'f', 'j'}, 'd');
            Assert.AreEqual('f', result);
        }
        
        [Test]
        public void Test4()
        {
            var result = Solution.NextGreatestLetter(new char[] { 'c', 'f', 'j'}, 'g');
            Assert.AreEqual('j', result);
        }
        
        [Test]
        public void Test5()
        {
            var result = Solution.NextGreatestLetter(new char[] { 'c', 'f', 'j'}, 'j');
            Assert.AreEqual('c', result);
        }
    }

    public class Solution
    {
        public char NextGreatestLetter(char[] letters, char target)
        {
            var left = 0;
            var right = letters.Length - 1;
            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                
                if (letters[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return letters[left % letters.Length];
        }
    }
}
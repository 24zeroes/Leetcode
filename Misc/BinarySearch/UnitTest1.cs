using NUnit.Framework;

namespace BinarySearch
{
    public class Tests
    {
        private int[] Input = {0, 5, 7, 10 ,17, 19, 31};

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var bs = new BinarySearch();
            var result = bs.GetItemIndex(Input, 5);
            Assert.AreEqual(1, result);
        }
    }

    public class BinarySearch
    {
        public int GetItemIndex(int[] arr, int k)
        {
            var l = 0;
            var r = arr.Length;
            var mid = 0;

            while (l < r)
            {
                mid = l + (r - l) / 2;

                if (arr[mid] == k)
                {
                    return mid;
                }

                if (arr[mid] > k)
                {
                    r = mid - 1;
                }
                else
                {
                    l = mid - 1;
                }
            }

            return -1;
        }
    }
}
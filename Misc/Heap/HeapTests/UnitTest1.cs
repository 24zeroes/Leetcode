using Heap;
using NUnit.Framework;

namespace HeapTests
{
    public class Tests
    {
        private MinHeap Heap { get; set; }
        
        [SetUp]
        public void Setup()
        {
            Heap = new MinHeap(100, new []{35, 7, 8, 12, 13, 2, 3}); 
        }

        [Test]
        public void InitializeTest()
        {
            for (int i = 0; i <= Heap.LastNodeIndex; i++)
            {
                if (Heap.Nodes[i] > Heap.GetLeftChild(i) ||
                    Heap.Nodes[i]> Heap.GetRightChild(i))
                {
                    Assert.Fail();
                }
            }
            
            Assert.Pass();
        }
        
        [Test]
        public void InsertTest()
        {
            Heap.Insert(-1);
            for (int i = 0; i <= Heap.LastNodeIndex; i++)
            {
                if (Heap.Nodes[i] > Heap.GetLeftChild(i) ||
                    Heap.Nodes[i]> Heap.GetRightChild(i))
                {
                    Assert.Fail();
                }
            }
            
            Assert.Pass();
        }
        
        [Test]
        public void PopTest()
        {
            Heap.Pop();
            for (int i = 0; i <= Heap.LastNodeIndex; i++)
            {
                if (Heap.Nodes[i] > Heap.GetLeftChild(i) ||
                    Heap.Nodes[i]> Heap.GetRightChild(i))
                {
                    Assert.Fail();
                }
            }
            
            Assert.Pass();
        }
        
        [Test]
        public void KthSmallestTest()
        {
            // k = 3
            Heap.Pop();
            Heap.Pop();
            Heap.Pop();
            Heap.Pop();
            Heap.Pop();
            Heap.Pop();
            
            Assert.AreEqual(35, Heap.Nodes[0]);
        }
    }
}
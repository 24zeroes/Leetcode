using System;
using System.Collections.Generic;

namespace Heap
{
    public class MinHeap
    {
        public int[] Nodes { get; protected set; }
        public int LastNodeIndex { get; set; }
        
        public int GetLeftChild(int index) => GetLeftChildIndex(index) > Nodes.Length ? int.MinValue : Nodes[GetLeftChildIndex(index)];
        public int GetRightChild(int index) =>  GetRightChildIndex(index) > Nodes.Length ? int.MinValue : Nodes[GetRightChildIndex(index) ];
        public int GetLeftChildIndex(int index) => (index * 2) + 1 > Nodes.Length ? -1 : (index * 2) + 1;
        public int GetRightChildIndex(int index) =>  (index * 2) + 2 > Nodes.Length ? -1 : (index * 2) + 2;
        public MinHeap(int heapMaxSize, int[] init = null)
        {
            Nodes = new int[heapMaxSize];
            for (int i = 0; i < heapMaxSize; i++)
            {
                Nodes[i] = int.MaxValue;
            }

            LastNodeIndex = -1;

            if (init != null)
            {
                foreach (var element in init)
                {
                    Insert(element);
                }
            }
        }

        public int Insert(int key)
        {
            LastNodeIndex += 1;
            Nodes[LastNodeIndex] = key;

            return Push(LastNodeIndex);
        }

        public int Pop()
        {
            var result = Nodes[0];
            
            Nodes[0] = Int32.MaxValue;
            Drawn(0);
            
            LastNodeIndex -= 1;
            return result;
        }

        private int Drawn(int index)
        {
            var leftChild = GetLeftChild(index);
            var rightChild = GetRightChild(index);
            while (leftChild != int.MinValue &&
                   rightChild != int.MinValue)
            {
                var targetIndex = -1;
                if (Compare(index, GetLeftChildIndex(index)) && Compare(index, GetRightChildIndex(index)))
                {
                    if (leftChild > rightChild)
                    {
                        targetIndex = GetRightChildIndex(index);
                    }
                    else
                    {
                        targetIndex = GetLeftChildIndex(index);
                    }
                    
                    Swap(index, targetIndex);
                    index = targetIndex;
                    leftChild = GetLeftChild(index);
                    rightChild = GetRightChild(index);
                    continue;
                }

                if (Compare(index, GetLeftChildIndex(index)))
                {
                    targetIndex = GetLeftChildIndex(index);
                    Swap(index, targetIndex);
                    index = targetIndex;
                    leftChild = GetLeftChild(index);
                    rightChild = GetRightChild(index);
                    continue;
                }
                
                if (Compare(index, GetRightChildIndex(index)))
                {
                    targetIndex = GetRightChildIndex(index);
                    Swap(index, targetIndex);
                    index = targetIndex;
                    leftChild = GetLeftChild(index);
                    rightChild = GetRightChild(index);
                    continue;
                }

                break;
            }

            return index;
        }

        private int Push(int pos)
        {
            while (pos / 2 >= 0 && Compare(pos / 2, pos))
            {
                Swap(pos / 2, pos);
                pos = pos / 2;
            }

            return pos;
        }

        private void Swap(int pos1, int pos2)
        {
            var tmp = Nodes[pos1];
            Nodes[pos1]= Nodes[pos2];
            Nodes[pos2] = tmp;
        }

        private bool Compare(int index1, int index2)
        {
            return Nodes[index1] > Nodes[index2];
        }
    }
    
}
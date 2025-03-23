using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312ST10202241
{
    public class PriorityQueue<TElement, TPriority> where TPriority : IComparable
    {
        private List<(TElement Element, TPriority Priority)> _elements = new List<(TElement, TPriority)>();
     
        public int Count => _elements.Count;

        public void Enqueue(TElement element, TPriority priority)
        {
            _elements.Add((element, priority));
            HeapifyUp(_elements.Count - 1); // Maintain heap order by bubbling up
        }

        public TElement Dequeue()
        {
            if (_elements.Count == 0)
                throw new InvalidOperationException("The queue is empty");

            var element = _elements[0].Element;
            _elements[0] = _elements[_elements.Count - 1];// Move last element to the top
            _elements.RemoveAt(_elements.Count - 1);
            HeapifyDown(0); // Maintain heap order by bubbling down

            return element;
        }

        private void HeapifyUp(int index)
        {
            while (index > 0)
            {
                int parentIndex = (index - 1) / 2;
                if (_elements[index].Priority.CompareTo(_elements[parentIndex].Priority) >= 0)
                    break;

                Swap(index, parentIndex);
                index = parentIndex;
            }
        }

        private void HeapifyDown(int index)
        {
            while (index < _elements.Count)
            {
                int leftChild = 2 * index + 1;
                int rightChild = 2 * index + 2;
                int smallest = index;

                if (leftChild < _elements.Count && _elements[leftChild].Priority.CompareTo(_elements[smallest].Priority) < 0)
                    smallest = leftChild;
                if (rightChild < _elements.Count && _elements[rightChild].Priority.CompareTo(_elements[smallest].Priority) < 0)
                    smallest = rightChild;

                if (smallest == index)
                    break;

                Swap(index, smallest);
                index = smallest;
            }
        }

        private void Swap(int indexA, int indexB)
        {
            var temp = _elements[indexA];
            _elements[indexA] = _elements[indexB];
            _elements[indexB] = temp;
        }
    }
}

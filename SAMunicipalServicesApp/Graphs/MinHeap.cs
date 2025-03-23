using System;
using System.Collections.Generic;

public class MinHeap
{
    private readonly List<ServiceRequest> heap = new List<ServiceRequest>();

    public void Insert(ServiceRequest request)
    {
        heap.Add(request);
        HeapifyUp(heap.Count - 1);
    }

    public List<ServiceRequest> GetAll()
    {
        return new List<ServiceRequest>(heap); // Return all items without removing
    }

    private void HeapifyUp(int index)
    {
        while (index > 0)
        {
            int parent = (index - 1) / 2;
            if (heap[index].SubmittedDate >= heap[parent].SubmittedDate)
                break;

            Swap(index, parent);
            index = parent;
        }
    }

    private void Swap(int index1, int index2)
    {
        var temp = heap[index1];
        heap[index1] = heap[index2];
        heap[index2] = temp;
    }
}

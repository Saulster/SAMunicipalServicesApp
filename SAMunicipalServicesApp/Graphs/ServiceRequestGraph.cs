using System;
using System.Collections.Generic;

public class ServiceRequestGraph
{
    private readonly Dictionary<int, List<int>> adjacencyList = new Dictionary<int, List<int>>();
    public Dictionary<int, List<int>> GetGraph()
    {
        return adjacencyList;
    }

    public void AddEdge(int fromRequestId, int toRequestId)
    {
        if (!adjacencyList.ContainsKey(fromRequestId))
            adjacencyList[fromRequestId] = new List<int>();

        adjacencyList[fromRequestId].Add(toRequestId);
    }

    public List<(int From, int To)> GetEdges()
    {
        var edges = new List<(int From, int To)>();
        foreach (var key in adjacencyList.Keys)
        {
            foreach (var value in adjacencyList[key])
            {
                edges.Add((key, value));
            }
        }
        return edges;
    }
}

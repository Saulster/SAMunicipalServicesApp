using System;
using System.Collections.Generic;

namespace PROG7312ST10202241
{
    // Class representing an edge in the Minimum Spanning Tree (MST)
    public class EdgeMST
    {
        public int From { get; } // Source node of the edge
        public int To { get; }   // Destination node of the edge
        public int Weight { get; } // Weight of the edge

        public EdgeMST(int from, int to, int weight)
        {
            From = from;
            To = to;
            Weight = weight;
        }
    }

    // Class to compute the Minimum Spanning Tree
    public class MST
    {
        private readonly List<EdgeMST> edges = new List<EdgeMST>(); // List of all edges in the graph

        // Add an edge to the graph
        public void AddEdge(int from, int to, int weight)
        {
            edges.Add(new EdgeMST(from, to, weight));
        }

        // Compute the Minimum Spanning Tree using Kruskal's algorithm
        public List<EdgeMST> GetMinimumSpanningTree()
        {
            var mst = new List<EdgeMST>(); // List to store edges in the MST
            edges.Sort((e1, e2) => e1.Weight.CompareTo(e2.Weight)); // Sort edges by weight

            var parent = new Dictionary<int, int>();
            foreach (var edge in edges)
            {
                // Initialize each node as its own parent (disjoint set)
                if (!parent.ContainsKey(edge.From)) parent[edge.From] = edge.From;
                if (!parent.ContainsKey(edge.To)) parent[edge.To] = edge.To;
            }

            foreach (var edge in edges)
            {
                int root1 = FindRoot(parent, edge.From);
                int root2 = FindRoot(parent, edge.To);

                // Add edge to MST if it doesn't form a cycle
                if (root1 != root2)
                {
                    mst.Add(edge);
                    parent[root1] = root2; // Union of two sets
                }
            }

            return mst; // Return the edges in the MST
        }

        // Helper method to find the root of a node (disjoint set find)
        private int FindRoot(Dictionary<int, int> parent, int node)
        {
            while (parent[node] != node)
            {
                parent[node] = parent[parent[node]]; // Path compression
                node = parent[node];
            }
            return node;
        }
    }
}

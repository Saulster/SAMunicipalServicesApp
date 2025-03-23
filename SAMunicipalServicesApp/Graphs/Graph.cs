using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312ST10202241
{
    public class Graph
    {
        private int vertices;
        private List<int>[] adjacencyList;

        public Graph(int vertices)
        {
            this.vertices = vertices;
            adjacencyList = new List<int>[vertices];

            for (int i = 0; i < vertices; i++)
                adjacencyList[i] = new List<int>();
        }

        public void AddEdge(int source, int destination)
        {
            adjacencyList[source].Add(destination);
            adjacencyList[destination].Add(source);
        }

        public void BreadthFirstSearch(int startVertex)
        {
            bool[] visited = new bool[vertices];
            Queue<int> queue = new Queue<int>();

            visited[startVertex] = true;
            queue.Enqueue(startVertex);

            while (queue.Count > 0)
            {
                int currentVertex = queue.Dequeue();
                Console.WriteLine($"Visited {currentVertex}");

                foreach (var neighbor in adjacencyList[currentVertex])
                {
                    if (!visited[neighbor])
                    {
                        visited[neighbor] = true;
                        queue.Enqueue(neighbor);
                    }
                }
            }
        }

        public void MinimumSpanningTree()
        {
            // Implemented using Prim's Algorithm
            bool[] inMST = new bool[vertices];
            int[] keys = new int[vertices];
            int[] parent = new int[vertices];

            for (int i = 0; i < vertices; i++)
            {
                keys[i] = int.MaxValue;
                parent[i] = -1;
            }

            keys[0] = 0;

            for (int count = 0; count < vertices - 1; count++)
            {
                int minIndex = -1;
                int minValue = int.MaxValue;

                for (int v = 0; v < vertices; v++)
                {
                    if (!inMST[v] && keys[v] < minValue)
                    {
                        minValue = keys[v];
                        minIndex = v;
                    }
                }

                inMST[minIndex] = true;

                foreach (var neighbor in adjacencyList[minIndex])
                {
                    if (!inMST[neighbor] && 1 < keys[neighbor])
                    {
                        keys[neighbor] = 1;
                        parent[neighbor] = minIndex;
                    }
                }
            }

            Console.WriteLine("Edges in Minimum Spanning Tree:");
            for (int i = 1; i < vertices; i++)
            {
                Console.WriteLine($"{parent[i]} - {i}");
            }
        }
    }
}

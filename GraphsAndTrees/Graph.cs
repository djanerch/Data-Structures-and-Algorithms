using System;
using System.Collections.Generic;

namespace GraphsAndTrees
{
    class Graph
    {
        private int numVertices;
        private Dictionary<int, List<int>> adjList;

        public Graph(int numVertices)
        {
            this.numVertices = numVertices;
            adjList = new Dictionary<int, List<int>>();

            for (int i = 0; i < numVertices; i++)
            {
                adjList.Add(i, new List<int>());
            }
        }

        public void AddEdge(int src, int dest)
        {
            adjList[src].Add(dest);
            adjList[dest].Add(src);
        }

        public void PrintGraph()
        {
            for (int i = 0; i < numVertices; i++)
            {
                Console.Write("Vertex " + i + ": ");
                foreach (int j in adjList[i])
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

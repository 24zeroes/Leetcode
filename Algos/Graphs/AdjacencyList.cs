//Rextester.Program.Main is the entry point for your code. Don't change it.
//Microsoft (R) Visual C# Compiler version 2.9.0.63208 (958f2354)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Graph
    {
        private int VertexNumber {get; set;}
        private List<List<Edge>> Edges {get; set;}
        
        public Graph(int v)
        {
            VertexNumber = v;
            Edges = new List<List<Edge>>();
        }
        
        public void AddEdge(int fromVertexId, Edge edge)
        {
            if (Edges[fromVertexId] == null)
            {
                Edges[fromVertexId] = new List<Edge>();
            }
            Edges[fromVertexId].Add(edge);
        }
        
    }
    
    public class Edge
    {
        public int VertexId {get; set;}
        public int EdgeWeight {get; set;}
    }
}
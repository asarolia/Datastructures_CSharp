/*
  Graph is a data structure that contains - Node/Vertex and Edges. There are various types of graphs like - 
  Directed, Undirected, Weighted, Unweighted, Cyclic and Acyclic. 

  There are various pattern to represent graphs, mainly - 
1) Edge List -  
Const graph = [[0,2],[2,3],[2,1],[1,3]] 

2) Adjacency List  
Const graph = [ [2], [2,3], [0,1,3],[1,2]] , here index value represent the Vertex and array values where it is connected to

3) Adjacency Matrix , used to reprent the N vertex in N*N matrix with connection is defined as 1 and no connection as 0

Simplest way to represent Vertex , with edges in concept only 

=> Adjacency List
class Vertex<T>
{
    private T data;
    private LinkedList<Vertex<T>> neighbors;  // Here, linked list only contains other vertexes which are connected to given vertex
}

=> Edge/Incident List

class Edge<T>
{
    private Vertex<T> node1;
    private Vertex<T> node2;
    private int edgeWeight;
}

class Vertex<T>
{
    private T data;
    private LinkedList<Edge<T>> neighbors;
}

=> Adjacency Matrix 

class Vertex<T>
{
    private int index;
    private T data;
}

class Graph<T>
{
    List<Vertex<T>> vertices;
    bool[][] edges = new bool[10][10];
}



 */

using System;
using System.Collections.Generic;

namespace Graphs
{
    public class Graph
    {
        // Every graph will have Node or Vertex
        private Vertex vertices;
        // Array to store all Vertex objects  for traversal
        private Vertex[] vArray;
        private int defaultsize = 10;
        private int nodeCount;
        public Graph()
        {
            this.vertices = null;
            nodeCount = 0;
            vArray = new Vertex[defaultsize];
            
        }

        public void AddVertex(int value)
        {
            vertices = new Vertex(value);
            vArray[nodeCount] = vertices;
            nodeCount++;
        }

        public void AddEdge(Vertex source, Vertex dest)
        {
            source.connectedVertices.Add(dest);

        }

        public void TraverseGraph()
        {
            for(int i = 1; i<=this.nodeCount;i++)
            {
                Console.WriteLine("Graph vertex :"+ vertices[i]);
                Console.WriteLine("Connected vertices :");

                foreach (var item in vertices[i].CONNECTEDVERTICES)
                {
                    Console.Write(" "+ item +" ");
                }

            }
        }



    }

    // vertex class to hold the properties of a vertex
    public class Vertex 
    { 
        // variable to hold the vertex value
       private int vertexValue;
       public int VERTEXVALUE
       {
           get { return this.vertexValue; }
           set { this.vertexValue = value; }
       }

       // Linked list to hold the connected vertices 
       public List<Vertex> connectedVertices;

      

       public Vertex(int value)
       {
           this.vertexValue = value;
           this.connectedVertices = new List<Vertex>();
       }
      
       

    }
}

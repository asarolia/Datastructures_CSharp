using System;

namespace Graphs
{
    public class Graph
    {
        // Every graph will have Node or Vertex
        private Vertex vertices;
        private int nodeCount;

        public Graph()
        {
            
        }


    }

    // vertex class to hold the properties of a vertex
    class Vertex 
    { private int vertexValue;
        public int VERTEXVALUE
        {
            get { return vertexValue; }
            set { vertexValue = value; }
        }
        
        public Dictionary<string,object> properties;

    }
}

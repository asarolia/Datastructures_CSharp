/*
 Tree data structures are used to capture hierarchial information about data. Most common tree data structures are 

 => Binary Tree - a tree DS whose parent node can have only 0 or 2 childrens and only one root node
 => Binary Search Tree - a tree DS whose left child node value is always less and right child node value is greater than parent node respectively. 
 => Binary Heap - It has 2 variations : 1) Min heap(where parent node value is less than all child nodes in tree and recursively true for other child node trees)
                  2) Max-heap ( where parent node value is greater than all its child nodes and recursively true for child node trees)


 Binary tree has 2 forms - 

 1) Perfect Binary Tree : A parent node has 0 or 2 children
 2) Full binary Tree : A parent node can have 0,1,or 2 child nodes



 */
using System;
using System.Collections.Generic;

namespace Trees
{
    public class BinarySearchTree
    {
        private TreeNode root;
        private TreeNode item;
        private TreeNode current;
        private TreeNode previous;
        private int treeHeight;
        private int treeNodes;

        public BinarySearchTree(int value)
        {
            this.root = new TreeNode(value);
            this.current = this.root;
            this.treeHeight = 1;
            this.treeNodes = 1;
        }

        public void PrintTree()
        {
            this.current = this.root;
            this.previous = this.root;

            TraverseTree(this.current);
            
        }
        public void TraverseTree(TreeNode currentItem)
        {
            if(currentItem != null)
            {
                
                Console.WriteLine("Current Node : {0} ; Left Node: {1} , Right Node: {2}",currentItem.NODEVALUE, currentItem?.LEFTNODE?.NODEVALUE,currentItem?.RIGHTNODE?.NODEVALUE);
                TraverseTree(currentItem.LEFTNODE);
                TraverseTree(currentItem.RIGHTNODE);
            }
        }

        public void Insert(int value)
        {
            this.current = this.root;
            DirectionCheck(value);        
        }

        public void Remove(int value)
        {
            this.current = this.root;
            this.previous = this.root;
            DirectionSearch(value, "root");

        }

        private void DirectionSearch(int value, string s)
        {
            Console.WriteLine("Current node value:{0} and Value:{1}",this.current.NODEVALUE,value);
            if(this.current.NODEVALUE == value)
            {
                // means we have found the value to be removed
                    switch (s)
                    {
                        case "root":
                            // only root thus make it null
                            this.root = null;   
                            Console.WriteLine("Removed {0} from root",value);
                        break;
                        case "left":
                           // 1. Check if leaf node  i.e. no further childs then delete it
                            if(this.current.RIGHTNODE == null && this.current.LEFTNODE == null)
                            {
                                this.previous.LEFTNODE = null;
                                Console.WriteLine("Removed {0} from left of {1}",value, this.previous.NODEVALUE);
                            
                            }else{

                                // 2. check if only single child
                                if(this.current.RIGHTNODE == null)
                                {
                                    this.previous.LEFTNODE = this.current.LEFTNODE;
                                    Console.WriteLine("Removed {0} from left of {1}",value, this.previous.NODEVALUE);
                                    
                                }
                                if(this.current.LEFTNODE == null)
                                {
                                    this.previous.LEFTNODE = this.current.RIGHTNODE;
                                    Console.WriteLine("Removed {0} from right of {1}",value, this.previous.NODEVALUE);
                                
                                }
                                //3. If both right and left node available then pick successor from left 
                                if(this.current.RIGHTNODE !=null && this.current.LEFTNODE != null)
                                {
                                    this.previous.LEFTNODE = this.current.LEFTNODE;
                                    this.current.LEFTNODE.RIGHTNODE = this.current.RIGHTNODE;
                                    Console.WriteLine("Removed {0} new parent is {1}",value, this.current.LEFTNODE.NODEVALUE);

                                }
                                
                            }
                            
                        break;
                        case "right":
                           // 1. Check if leaf node  i.e. no further childs then delete it
                            if(this.current.RIGHTNODE == null && this.current.LEFTNODE == null)
                            {
                                this.previous.RIGHTNODE = null;
                                Console.WriteLine("Removed {0} from right of {1}",value, this.previous.NODEVALUE);
                            
                            }else{

                                // 2. check if only single child
                                if(this.current.RIGHTNODE == null)
                                {
                                    this.previous.RIGHTNODE = this.current.LEFTNODE;
                                    Console.WriteLine("Removed {0} from left of {1}",value, this.previous.NODEVALUE);
                                    
                                }
                                if(this.current.LEFTNODE == null)
                                {
                                    this.previous.RIGHTNODE = this.current.RIGHTNODE;
                                    Console.WriteLine("Removed {0} from right of {1}",value, this.previous.NODEVALUE);
                                
                                }
                                //3. If both right and left node available then pick successor from left 
                                 if(this.current.RIGHTNODE !=null && this.current.LEFTNODE != null)
                                 {
                                     this.previous.RIGHTNODE = this.current.RIGHTNODE;
                                     this.current.RIGHTNODE.LEFTNODE = this.current.LEFTNODE;
                                     Console.WriteLine("Removed {0} new parent node is {1}",value, this.current.RIGHTNODE.NODEVALUE);

                                 }
                                
                            }
                        break;
                    
                        
                    }
                           
            }
            else{

                if(this.current.NODEVALUE > value)
            {
                Console.WriteLine("Searching left of :"+this.current.NODEVALUE);
                SearchLeft(value);
  
            }else{
                Console.WriteLine("Searching right of :"+this.current.NODEVALUE);
                SearchRight(value);
                
            }


            }
            
        }
        private void SearchLeft(int value)
        {
            if(this.current.LEFTNODE != null)
            {
                this.previous = this.current;
                this.current = this.current.LEFTNODE;
                DirectionSearch(value, "left");
            }else{
                Console.WriteLine("Left nodes end of tree, searched value : {0} not found",value);
            }
        }
        private void SearchRight(int value)
        {
            if(this.current.RIGHTNODE != null)
            {
                this.previous = this.current;
                this.current = this.current.RIGHTNODE;
                DirectionSearch(value, "right");
            }else{
                Console.WriteLine("Right node end of tree, searched value : {0} not found",value);
            }
        }

        private void DirectionCheck(int value)
        {
             if(this.current.NODEVALUE == value)
            {
                Console.WriteLine("Duplicate Node not allowed.");
                return;

            }
            
            if (this.current.NODEVALUE > value)
            {
                GoLeft(value);
            }else
            {
                GoRight(value);
            }
        }

        private void GoLeft(int value)
        {
            if(this.current.LEFTNODE != null)
            {
                this.current = this.current.LEFTNODE;
                DirectionCheck(value);
            }else{
                InsertNode(value,"Left");
            }

        }
         private void GoRight(int value)
        {
             if(this.current.RIGHTNODE != null)
            {
                this.current = this.current.RIGHTNODE;
                DirectionCheck(value);
            }else{
                InsertNode(value, "Right");
            }
        }

        private void InsertNode(int value,string s)
        {
             this.item = new TreeNode(value);

            switch (s)
            {
                case "Left":
                this.current.LEFTNODE = this.item;
                this.treeNodes++;
                this.treeHeight++;
                break;
                case "Right":
                this.current.RIGHTNODE = this.item;
                this.treeNodes++;
                this.treeHeight++;
                break;
            
            }
        }

            // function to implement BFS & DFS
            //       19
            //  12        25
            // 6   13   20    26
            // BFS -   { 19, 12, 25, 6, 13, 20, 26}
            // DFS (In order)  - { 6, 12, 13, 19, 20,25, 26, 19 }
            
        // Iterative appraoch for BFS    
        public void BreadthFirstSearch()
        {
            // This function should start from root and keep on traversing all nodes from left to right at each level
            // Start from root
            TreeNode currentNode = this.root;
            // Array list to store the BFS nodes 
            List<int> op = new List<int>();
            // Queue to store the nodes at each level
            Queue<TreeNode> myQ = new Queue<TreeNode>();
            // push the first/root element in Queue
            myQ.Enqueue(currentNode);
            

            // Now, continue to process the contents from Queue

            while(myQ.Count > 0)
            {
                // Dequeue the current first item from Queue
                TreeNode fetched = myQ.Dequeue();
                // push the node value to output list also
                op.Add(fetched.NODEVALUE);
                if(fetched.LEFTNODE != null)
                {
                    myQ.Enqueue(fetched.LEFTNODE);
                }
                if(fetched.RIGHTNODE != null)
                {
                    myQ.Enqueue(fetched.RIGHTNODE);
                }
            } 


            Console.WriteLine("BFS Output:");

            // Display the output 
            foreach (var item in op)
            {
                Console.Write(item + " ");
            }
             


        }
     
        // recursive approach 
        public string BreadthFirstSearchRecursive()
        {
            // Queue to store 
            Queue<TreeNode> myQ = new Queue<TreeNode>();

            // Output list
            List<int> op = new List<int>();

            // set the root node 
            TreeNode currentNode = this.root;

            myQ.Enqueue(currentNode);

            return BFSRecursiveTraverse(myQ,op);
            


        }

        private string BFSRecursiveTraverse(Queue<TreeNode> myQ, List<int> op)
        {
            string result = "";
            // base condition , when to stop the recursive call
            if (myQ.Count > 0)
            {
                // fetch the node from queue
                TreeNode fetched = myQ.Dequeue();
                // push the node value on output list
                op.Add(fetched.NODEVALUE);
                // check if any left or right child
                if(fetched.LEFTNODE != null)
                {
                    myQ.Enqueue(fetched.LEFTNODE);
                }
                if(fetched.RIGHTNODE != null)
                {
                    myQ.Enqueue(fetched.RIGHTNODE);
                }

                BFSRecursiveTraverse(myQ,op);
                
            }

            // process the output list
            foreach (var item in op)
            {
                result = result + " " + item.ToString();
            }


         return result;   
        }
    }

    // class for Node structure
    public class TreeNode
    {
        private int nodeValue;
        private TreeNode leftNode;
        private TreeNode rightNode;

        public TreeNode(int value)
        {
            this.nodeValue = value;
            this.leftNode = null;
            this.rightNode = null;
        }

        public int NODEVALUE 
        {
            get{
                return this.nodeValue;
            }

            set {
                this.nodeValue = value;
            }

        }

        public TreeNode LEFTNODE{
            get{
                return this.leftNode;
            }
            set 
            {
                this.leftNode = value;
            }
        }
        public TreeNode RIGHTNODE{
            get{
                return this.rightNode;

            }
            set 
            {
                this.rightNode = value;
            }
        }
    }

    // class for Queue operation for BFS and DFS 

     
}

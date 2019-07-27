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

        

        

    }

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
}

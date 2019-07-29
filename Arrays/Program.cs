using System;
using System.Text;
using HashTable;
using LinkedList;
using Queues;
using Stacks;
using Trees;


namespace Arrays
{
    class Program
    {
       // public static int[] inputArray = {1,3,9,4};
      //  public static int targetSum = 8;
      //  public static string name = "test for string reversal";

        public static string[] arr1 = {"1","3","18","25"};

        public static string[] arr2 = {"23","35","35","96"};

        private static string inputCode = "MadAm23";
         
        static void Main(string[] args)
        {
            // Google Interview Exercise 

                // GoogleInterview gobj = new GoogleInterview();
                // gobj.NaiveSolution(inputArray, targetSum);
                // Console.WriteLine(gobj.IdentifyPairSum(inputArray,targetSum));

            // Reverse a string    

             //   ReverseString robj = new ReverseString();
             //   Console.WriteLine(robj.NaiveReverseMe(name));
             //   Console.WriteLine(robj.BetterReverseMe(name));

            // Merge Sorted Arrays
              //  MergedArray mobj = new MergedArray();
              //  mobj.NaiveMerge(arr1,arr2);

              //  Console.WriteLine("Charcter code :" + string.Join("",Encoding.ASCII.GetBytes("A")));

            //  My HashTable Implementation 
             //   HashClass myHashTable = new HashClass(5) ;
             //   myHashTable.SetValue("grapes",1000);
             //   myHashTable.GetValue("grapes");

            // Google interview for first repeating character
            //    GoogleInterview2 robj = new GoogleInterview2();
            //    robj.PrintRecurringElement();

            // My Singly Linked List implementation 
              //  LinkedListClass myLinkedList = new LinkedListClass(10);
              //  myLinkedList.AppendNode(25);
              //  myLinkedList.AppendNode(5);
              //  myLinkedList.PrePend(4);
              //  myLinkedList.PrePend(1);
              // //  myLinkedList.PrintAllNodes();
              //  myLinkedList.Insert(3,100);
              // // myLinkedList.PrintAllNodes();
              //  myLinkedList.Remove(25);
              //  myLinkedList.PrintAllNodes();
              //  myLinkedList.ReverseList();
              //  myLinkedList.PrintAllNodes();

               // My Doubly Linked List implementation 
              //  DoublyLinkedList mydLinkedList = new DoublyLinkedList(10);
              //  mydLinkedList.AppendNode(25);
              //  mydLinkedList.AppendNode(5);
              //  mydLinkedList.PrePend(4);
              //  mydLinkedList.PrePend(1);
              //   mydLinkedList.PrintAllNodes();
              //  mydLinkedList.Insert(3,100);
              //  mydLinkedList.PrintAllNodes();
              //  mydLinkedList.Remove(25);
              //   mydLinkedList.Remove(1);
              //   mydLinkedList.Remove(5);
              //  mydLinkedList.PrintAllNodes();

              // My stacks implementation using LinkedList as ADT
              // LinkedStack mystack = new LinkedStack(50);
              // mystack.push(35);
              // mystack.push(5);
              // mystack.push(69);
              // mystack.push(24);
              // mystack.peek();
              // mystack.pop();
              // mystack.peek();
              // mystack.pop();
              // mystack.print();

              //My Queue implementation using LinkedList as ADT
              // Queue myqueue = new Queue(50);
              // myqueue.Enqueue(35);
              // myqueue.Enqueue(5);
              // myqueue.Enqueue(69);
              // myqueue.Enqueue(24);
              // myqueue.Dequeue();
              // myqueue.Dequeue();
              // myqueue.peek();
              // myqueue.Dequeue();
              // myqueue.Print();

              // My Binary search tree implementation using LinkedList as ADT
              //  BinarySearchTree bstobj = new BinarySearchTree(41);
              //  bstobj.Insert(65);
              //  bstobj.Insert(20);
              //  bstobj.Insert(50);
              //  bstobj.Insert(91);
              //  bstobj.Insert(99);
              //  bstobj.Insert(72);
              //  bstobj.Insert(29);
              //  bstobj.Insert(11);
              //  bstobj.Insert(32);
              //  bstobj.PrintTree();
              //  Console.WriteLine("After New Insert:");
              //  bstobj.Insert(24);
              //  bstobj.PrintTree();
              //  Console.WriteLine("Remove:");
              //  bstobj.Remove(91);
              //  Console.WriteLine("After Remove:");
              //  bstobj.PrintTree();

              // My custom implementation around Trie data structure
                //  Trie myTrieObj = new Trie();
                //  myTrieObj.Insert("test");
                //  myTrieObj.Insert("this");
                //  myTrieObj.Insert("there");
                //  myTrieObj.Insert("answer");
                //  myTrieObj.Search("this");
                //  myTrieObj.Search("spain");

                 // Honeywell make palindrome
                 Honeywell obj = new Honeywell();
                 obj.MakePalindrome(inputCode);


        }
    }

}

using System;
using System.Text;
using HashTable;
using LinkedList;


namespace Arrays
{
    class Program
    {
       // public static int[] inputArray = {1,3,9,4};
      //  public static int targetSum = 8;
      //  public static string name = "test for string reversal";

        public static string[] arr1 = {"1","3","18","25"};

        public static string[] arr2 = {"23","35","35","96"};
         
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
              //   myLinkedList.PrintAllNodes();
              //  myLinkedList.Insert(3,100);
              //  myLinkedList.PrintAllNodes();
              //  myLinkedList.Remove(25);
              //  myLinkedList.PrintAllNodes();

               // My Doubly Linked List implementation 
               DoublyLinkedList mydLinkedList = new DoublyLinkedList(10);
               mydLinkedList.AppendNode(25);
               mydLinkedList.AppendNode(5);
               mydLinkedList.PrePend(4);
               mydLinkedList.PrePend(1);
                mydLinkedList.PrintAllNodes();
               mydLinkedList.Insert(3,100);
               mydLinkedList.PrintAllNodes();
               mydLinkedList.Remove(25);
                mydLinkedList.Remove(1);
                 mydLinkedList.Remove(5);
               mydLinkedList.PrintAllNodes();


        }
    }

}

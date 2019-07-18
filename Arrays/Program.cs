using System;

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
                MergedArray mobj = new MergedArray();
                mobj.NaiveMerge(arr1,arr2);



        }
    }

}

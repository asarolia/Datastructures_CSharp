using System;

namespace Arrays
{
    class Program
    {
        public static int[] inputArray = {1,3,9,4};
        public static int targetSum = 8;
        static void Main(string[] args)
        {
            GoogleInterview obj = new GoogleInterview();
            obj.NaiveSolution(inputArray, targetSum);

            Console.WriteLine(obj.IdentifyPairSum(inputArray,targetSum));
        }
    }
}

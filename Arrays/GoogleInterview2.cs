namespace Arrays{

    using System;
    using System.Collections.Generic;

    /*
    Problem:

    Given an array we need to identify first reccuring character, For example 

    Given an array = [2,5,1,2,3,5,1,2,4]
    it should return 2

    Given an array = [2,1,1,2,3,5,1,2,4]
    it should return 1 
    
    Given an array = [2,3,4,5]
    It should return Undefined

    Steps to follow :
    1) Identify and write down all key points 
    Q - Is it sorted array ? N ; Can it contain numeric and character? No only characters ; Is it 1 D ? Yes
    2) Confirm the inputs and outputs 
    Q - Can we hard code the input data ? Yes ; If no repeating character ? return "undefined/not found"
    3) What is the goal in terms of time and space complexity ? Time, make it as efficient as possible
    4) Talk about the naive approach to interviewer, don't code that 
       like loop through the elements in nested loops and compare each of the elements with other elements of array
       
       But, this approach is not efficient and talk about reasons like nested for loop has time complexity of O(n^2)
    
    5) Before you write better code , talk about the logic and walk through the code logic verbally
     loop through the array elements in linear way and use hash set to determine the existence of the repeated charracter


     */

    public class GoogleInterview2
    {
        private static int[] inputArray = new int[] {2,1,1,2,3,5,1,2,4};
        private static HashSet<int> elemBucket = new HashSet<int>();

        public void PrintRecurringElement()
        {
            // Loop throught the array elements and keep on adding into hash bucket after existence check
            bool flag = false;


            foreach (var item in inputArray)
            {
                if(elemBucket.Contains(item))
                {
                    Console.WriteLine("First recurring character found :"+item);
                    flag = true;
                    break;
                } else{
                    elemBucket.Add(item);
                }  
            }

            if(!flag)
            {
                Console.WriteLine("Not Found");

            }

        }


    }
}
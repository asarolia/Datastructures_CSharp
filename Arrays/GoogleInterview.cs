using System;
using System.Collections.Generic;

namespace Arrays
{
    /*

    Given a array we need to identify the pairs of 2 number whose sum is equal to 8. For example - 
//   [1,2,3,9] SUM=8    => No match pairs
//   [1,2,4,4] SUM=8    => Yes, (4,4)
// Can we repeat numbers to calculate the said sum ? No, we but number can be repeated in given array
// Data type of array elements ? is it always integer ? Yes, numbers are integer but negatives could be there but no decimal type
//Can i hard code input arrray in my program for illustration? yes
// What we should return when match pairs are found ? Return boolean first and then we will see if we can return matching pairs later
// What is the main objective for time and space complexities? Time, make it as efficient as possible

    
     */

    public class GoogleInterview
    {
                bool flag = false;
        // Naive solution with quadratic time complexities is to just loop through the elements and compare for sum via another nested loop
        public void NaiveSolution(int[] inputArray, int targetSum)
        {
            foreach(var item in inputArray)
            {
            for(int j=0 ; j<inputArray.Length-1 ; j++)
            {
                if(inputArray[j]+item == targetSum)
                {
                flag = true;
                }
            }
            }

            // validate flag if we have found the pair or not 
            if(flag){
            Console.WriteLine("Pair found with combination sum of 8");
            }else
            {
            Console.WriteLine("No Pair found with combination sum of 8");
            }
        }


        // Better method can be we can store the compliments in a hashed set and use that hash with linear flow to identify the matching pair

        public bool IdentifyPairSum(int[] inputArray, int targetSum)
        {
        // first create a empty set 
        HashSet<int> compliments = new HashSet<int>();
        int compElement = 0;

        // Now loop through elements 
        foreach(var item in inputArray)
        {
            // calculate the complement of every element
            compElement = targetSum - item;
            // Check if compliment exist in the set 
            if(compliments.Contains(compElement))
            {
            
            return true;

            }else
            {
          //  Console.WriteLine(compElement);
            compliments.Add(compElement);
            }
        }
        compliments.Clear();
        return false;
        }



    }
}

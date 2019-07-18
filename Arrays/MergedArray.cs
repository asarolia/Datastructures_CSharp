/*
Given 2 sorted array create another sorted array after merge

 */
using System;
using System.Collections;
using System.Collections.Generic;

namespace Arrays
{
    public class MergedArray
    {

        public void NaiveMerge(string[] arr1, string[] arr2)
        {
            // make sure none of array is undefined 
            if(arr1.Length >=1 && arr2.Length >= 1)
            {
                string [] mergedArr = new String[arr1.Length+arr2.Length];
                arr1.CopyTo(mergedArr,0);
                arr2.CopyTo(mergedArr,arr1.GetUpperBound(0)+1);
                Array.Sort(mergedArr);
                Console.WriteLine("Default Sort: ");

                foreach (var item in mergedArr)
                {
                    Console.Write(item+ " ");
                }

                Array.Sort(mergedArr,new CustomSort());

                Console.WriteLine("\nCustom sort using IComparer: ");

                foreach (var item in mergedArr)
                {
                    Console.Write(item+ " ");
                }



            }else{
                Console.WriteLine(" Passed array is not in proper format");
            }
        }

    }

    public class CustomSort : IComparer
    {
        public int Compare(object x, object y)
        {
            int num1;
            int num2;
            int value = 0;

            if(Int32.TryParse(x.ToString(),out num1)){

                if(Int32.TryParse(y.ToString(),out num2))
                {

                    value = processResult(num1,num2);
                }

            }
           
            return value;
            //throw new NotImplementedException();
        }

        private int processResult(int num1, int num2)
        {
            int r = 0;
           if(num1 > num2)
           {
               r = 1;

           }
           if(num1 < num2)
           {
               r = -1;

           }
           if (num1 == num2)
           {
               r= 0;
           }
           return r;
        }
    }

}

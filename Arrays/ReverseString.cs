using System;

namespace Arrays
{
    public class ReverseString
    {
        public string NaiveReverseMe(string source)
        {
            string output = "";

          //  char[] tempArray = {};
            int strLength = source.Length;

            for(int i = 0 ; i < strLength ;i++)
            {
                output = output + source[(strLength-1)-i];
            }

            // // return the reverse string 
            // for(int j = 0; j < tempArray.Length ; j++)
            // {
            //     output += tempArray[j];
            // }

            return output;
        }

        public string BetterReverseMe(string source)
        {
            char[] arr = source.ToCharArray();
            string output = String.Empty;

            Array.Reverse(arr);

            foreach (var item in arr)
            {
                output += item;
            }

            return output;

        }
    }

}

/*
Problem statement :
A millionaire from London bought a unique house which has many rooms, expensive items and many other automatic equipment. 
A journalist went to his house for interviewing him. He entered through the wrong door and came inside the house but he lost his path for 
entering the main room due the fact that there were many rooms and the house had a unique structure. He is now stuck inside the house. 
He goes from one room to another, but couldn't find the right door. He saw one automatic answering machine in a room and asked it about the way to 
go out. The machine replied that he will receive a word but he needs to make a proper pattern from that word. After entering the pattern in the 
machine, he will get the correct path from the machine. Using this way, he could come out of the house. A Word Pattern should now be made and if
 we start the word from the left letter to the right or from the right to left, then that word should be same. For making this type of pattern, 
 he can add as many letters in the word at any place.
You need to figure out, how many minimum number of characters he needs to add in the original word for making this type of a pattern.


Input Format
First line represents total number of characters in the word, which is of integer type N. 
Second line represents a word, which is of string type containing alphabets and digits only which is case-sensitive.


Constraints
3<=N<=5000

Output Format
You need to print the desired minimum number of characters needed to add in the original word.


Sample TestCase 1
Input
5
Ab3bd
Output
2
Explanation
After adding two characters 'd' after 'A' and 'A' at the last of the given word, now the word will be "Adb3bdA", Hence the output will be 2.

Pattern is create - Palindrome

Only logic implemented edge conditions I have skipped for this 

 */

using System;
using System.Text;

namespace Arrays
{
    public class Honeywell
    {
        // get the inputs from console, for our case we will use hard code string for quick test
        

        // char array to store string letters 
        public Char[] inputLetters;
        public string fwd="";
        public string bck="";

        int count = 0;

        
         public void MakePalindrome(string s)
         {
             count = 0;
             inputLetters = s.ToCharArray();
             int len = inputLetters.Length;
             for (int i =0 ; i <= (len-1)/2; i++)
             {
                 if(inputLetters[i] != inputLetters[(len-1)-i])
                 {
                     // Character mismatch append after
                     fwd = fwd + (inputLetters[i])+ inputLetters[(len-1)-i];
                     count++;
                  //   Console.WriteLine(fwd +"!="+count);
                     bck = ""+inputLetters[(len-1)-i] + inputLetters[i] + bck; 
                     count++;
                  //   Console.WriteLine(bck +"!="+count);

                 }else
                 {
                     if(i%2==0 && i !=0 )
                     {
                          fwd = fwd + inputLetters[i];

                     }else{
                        
                         fwd = fwd + inputLetters[i];
                         bck = inputLetters[i]+bck;
    
        
                     }
                     
                 }

             }

             Console.WriteLine("Palindrome String : {0}  ; Required character to make :{1} ",(fwd+bck),count);
         }


    }
}

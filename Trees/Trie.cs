namespace Trees{

using System;

public class Trie
{
    private TrieNode root;
    private TrieNode current;

    private int levels;

    public Trie()
    {
        this.root = new TrieNode('r'); // set the root node
        this.current = this.root;
        this.levels = 0;
    }

    public void Insert(string word)
    {
        this.current = this.root;
        for (int i = 0 ; i < word.Length ; i++)
        {
            int index = word[i] - 'a';  // compare the ASCII codes to get the child node index array
            this.levels++;
            if(this.current.childNodes[index] == null)
            {
                this.current.childNodes[index] = new TrieNode(word[i]); // store and create new set of Trie nodes
            }
            this.current = this.current.childNodes[index]; // point to the next level node
        }
        this.current.ENDOFWORD = true; // mark word storage complete for current Trie node

    }

    public void Search(string word)
    {
        this.current = this.root;
        bool wordFound = true;
        // loop throgh the word characters and search them in tree nodes 
        for (int i = 0; i <word.Length; i++)
        {
            int index = word[i] - 'a';

            if(this.current.childNodes[index] != null)
            {
                this.current = this.current.childNodes[index];

            }else{
                wordFound = false;
                break;
            }


        }
             if(wordFound)
            {
                Console.WriteLine("Found word : {0} in Trie tree nodes",word);
            }
            else{
                Console.WriteLine("Word : {0} not found",word);
            }

    }


}

class TrieNode
{
    // node value
    private char nodeValue;
    // reference variable to other child nodes 
    public TrieNode[] childNodes;
    // flag to identify the end of 
    private bool endOfWord;

    public TrieNode(char value)
    {
        this.nodeValue = value;
        this.endOfWord = false;
        // instantiate and set as null for child nodes
        this.childNodes = new TrieNode[26];
        for(int i = 0 ; i < 26; i ++)
        {
           this.childNodes[i] = null;     
        }
    }
    public char NODEVALUE{
        get {
           return this.nodeValue; 
        }
        set {
            this.nodeValue = value;
        }
    }
    public bool ENDOFWORD{
        get {
            return this.endOfWord;
        }
        set {
            this.endOfWord = value;
        }
    }
    
}

}
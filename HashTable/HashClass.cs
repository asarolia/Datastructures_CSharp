using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    public class HashClass
    {
        // constructor for creating hashtable using array in background
       // List<string[]> localdata;
        String [][] localdata;
        //static string [] temp = new string[2];

        public HashClass(int size)
        {
            // jagged array which will contain array like [["grapes","value"],[],[]..]
            localdata = new String[size][];
           // localdata = new List<string[]>();
        
        }

        // hash function 
        private int _Hash(string key)
        {
            int hash = 0;
            for (int i=0 ; i < key.Length ; i ++)
            {
                hash = (hash + Int32.Parse(string.Join("",Encoding.ASCII.GetBytes(key[i].ToString()))) * i) % key.Length;
            }

            return hash;

        }

        public void SetValue(string v1, int v2)
        {
            
          //  temp[0] = v1;
           // temp[1] = v2.ToString();

            int storeaddress = _Hash(v1);
            Console.WriteLine(" String : {0} and hash value {1}",v1,storeaddress);

            localdata[storeaddress] = new String[]{v1,v2.ToString()};

            //localdata.Add(temp);
            //throw new NotImplementedException();
        }

        public void GetValue(string v)
        {
            int fetchaddress = _Hash(v);

            Console.WriteLine("About to fetch elements at hash value :"+ fetchaddress);

            Console.WriteLine("{0}, {1}",localdata[fetchaddress][0],localdata[fetchaddress][1].ToString());

           // throw new NotImplementedException();
        }
    }
}


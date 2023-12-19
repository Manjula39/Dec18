using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec18Console
{
    internal class Hash
    {
        public static void HashTableFuns()
        {
            Hashtable ht1 = new Hashtable();
            ht1.Add(1, "a"); ht1.Add(2.2, 9); ht1.Add("h", "k");
            Hashtable ht2 = new Hashtable();
            ht2.Add(1, "harry"); ht2.Add(45, "tim");
            ht2.Add(33, "tom"); ht2.Add(9, "jim");
            // to access all keys
            ICollection allKeys = ht2.Keys;
            foreach (var oneKey in allKeys) { Console.WriteLine(oneKey); }
            // to access values
            ICollection allValues = ht2.Values;
            foreach (var onValue in allValues) { Console.WriteLine(onValue); }
            // how to both 
            foreach (DictionaryEntry de in ht2) { Console.WriteLine("Key is " + de.Key); Console.WriteLine("Values is " + de.Value); }
            //to search by key
            bool b1 = ht2.ContainsKey("a"); Console.WriteLine(b1);
            // to search by value
            bool b2 = ht2.ContainsValue(2); Console.WriteLine(b2);
            bool b3 = ht2.Contains(25);// pass key as parameter
            int n1 = ht2.Count;// returns number of keys
                               // ht2.CopyTo(array,arrayIndex) from ht2 to array 
            ht2.Remove(99);// by key as parameter 
        }



    }
}

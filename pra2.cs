using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec18Console
{
    internal class pra2
    {
        public class AllCollections
        {
            //arraylist
            public static void ArrayListFuns()
            {
                ArrayList ar1 = new ArrayList();
                ar1.Add("hello");
                ar1.Add(2);
                ar1.Add(3.3);
                //non generic no having fixed data type collection classes allw a=values of any data type in same object(ar1), class arrayList
                ArrayList ar2 = new ArrayList(); ar2.Add("hello");
                ar2.Add("world");
                ar2.Add("Today is monday");
                // to access and display
                // foreach(string oneValue in ar2) { }
                foreach (var item in ar2) { Console.WriteLine(item); }

            }

        }
    }

}


using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec18Console
{
    internal class Program
    {
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
                // to remove
                //   ar2.Remove("world");// value is parameter
                //   ar2.RemoveAt(1);// 1 is index number of value
                //   ar2.RemoveRange(1, 4);//(start index, number of values ) 2,3,4,5 values 
                //  ar2.Clear();//all gone
                int n1 = ar2.Capacity; Console.WriteLine("capacity " + n1);
                ar2.Capacity = 10;
                int n2 = ar2.Count; Console.WriteLine("values we saved in collection " + n2);
                ar2.Insert(1, "sai");//hello sai world today is monday start index,value
                                     // ar2.InsertRange(1,ICollectionObje)
                bool b1 = ar2.Contains("hello");
                int n3 = ar2.IndexOf("sai"); Console.WriteLine(n3);
                // collection values will take dynamic
            }


        }
    }

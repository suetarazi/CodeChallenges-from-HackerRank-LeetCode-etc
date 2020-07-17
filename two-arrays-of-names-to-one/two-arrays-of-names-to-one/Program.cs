using System;
using System.Collections;
using System.Collections.Generic;

namespace two_arrays_of_names_to_one
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
            string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
            Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
        }
    }
    public class MergeNames
    {
        public static string[] UniqueNames(string[] names1, string[] names2)
        {
            throw new NotImplementedException();
            Hashtable hashtable = new Hashtable();
            
            for(int i=0; i<names1.Length; i++)
            {
                hashtable.Add(i, names1[i]);
            }

            List<string> resultList = new List<string>();
            for(int i=0; i<names2.Length; i++)
            {
                if (hashtable.Contains(names2[i]))
                {
                    //do nothing
                }
                else
                {
                    hashtable.Add(i, names2[i]);
                }
            }
            foreach (string name in hashtable)
            {
                resultList.Add(name);
            }

            return resultList.ToArray();

        }

    }
}
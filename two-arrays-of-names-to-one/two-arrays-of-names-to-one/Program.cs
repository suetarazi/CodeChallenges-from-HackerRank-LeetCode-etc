using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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
            
            HashSet<string> hashset = new HashSet<string>();
            
            for(int i=0; i<names1.Length; i++)
            {
                hashset.Add(names1[i]);
            }

            //List<string> resultList = new List<string>();
            for (int j = 0; j < names2.Length; j++)
            {
                if (!hashset.Contains(names2[j]))
                {
                    hashset.Add(names2[j]);

                }
            }    
                return hashset.ToArray<string>();
        }

    }
}
﻿using System;
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
            
            Dictionary<int, string> hashtable = new Dictionary<int, string>();
            
            for(int i=0; i<names1.Length; i++)
            {
                hashtable.Add(i, names1[i]);
            }

            List<string> resultList = new List<string>();
            for(int j=0; j<names2.Length; j++)
            {
                if (hashtable.!Contains<string>(names2[j]))
                {
                    //do nothing
                    hashtable.Add(j, names2[j]);
                    
                }
                //else
                //{
                //    hashtable.Add(i, names2[i]);
                //}
            }
            for(int i=0; i<hashtable.Length; i++)
            {
                resultList.Add(name);
            }

            return resultList.ToArray();

        }

    }
}
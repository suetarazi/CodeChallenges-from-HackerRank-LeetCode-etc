using System;
using System.Collections.Generic;

namespace SparseArrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int[] matchingStrings(string[] strings, string[] queries)
        {
            HashSet<string> hashset = new HashSet<string>();
            foreach(string s in queries)
            {
                hashset.Add(s);
            }

            int[] resultsArr = new int[queries.Length];

            for (int i = 0; i < resultsArr.Length; i++)
            {
                foreach (string s in strings)
                {
                    int count = 0;
                    if (hashset.Contains(s))
                    {
                        count++;
                    }

                    resultsArr[i] = count;
                }
            }

            return resultsArr;
        }
    }
}

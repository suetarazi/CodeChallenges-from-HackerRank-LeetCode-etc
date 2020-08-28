using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace SockMerchant
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int n = 9;
            int[] testArr = new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            Program p = new Program();
            p.FindMatchingPairsOfSocks(n, testArr);
        }

        public int FindMatchingPairsOfSocks(int n, int[] arr)
        {
            Array.Sort(arr);
            HashSet<int> hashset = new HashSet<int>();
            int matchingPairs=0;
            
            foreach(int i in arr)
            {
                if (!hashset.Contains(i))
                {
                    hashset.Add(i);
                    Console.WriteLine($"Initially added {i}");

                }
                else if (hashset.Contains(i))
                {
                    matchingPairs++;
                    Console.WriteLine($"We found a pair {i}");
                    hashset.Remove(i);
                }
            }

            Console.WriteLine($"matching pairs = {matchingPairs}");
            return matchingPairs;

            
        }

    }
}

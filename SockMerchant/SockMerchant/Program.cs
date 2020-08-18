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
            int matchingPairs=0;
            
            for(int i = 0; i < arr.Length; i++)
            {
                helperMethod(arr[i]);

            return matchingPairs;
            }

            return -1;
        }

        public void helperMethod(int i)
        {
            int matchingPairs = 0;
            HashSet<int> hashset = new HashSet<int>();
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

    }
}

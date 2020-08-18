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
        }

        public int FindMatchingPairsOfSocks(int n, int[] arr)
        {
            Array.Sort(arr);
            HashSet<int> hashset = new HashSet<int>();
            int matchingPairs = 0;
            hashset.Add(arr[0]);
            for(int i = 0; i < arr.Length; i++)
            {
                if(hashset.Contains(i))
                {
                    hashset.Add(i);
                    matchingPairs++;
                }
            }
            
            return matchingPairs;
        }

    }
}

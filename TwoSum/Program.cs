using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;

namespace TwoSum
{
    class Program 
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] nums = new int[] { 1, 2, 1, 7, 11, 15 };
            int target = 9;
            Solution s = new Solution();
            //s.TwoSumHash(nums, target);

            //need to check result being passed from the method in the following fashion:
            //int[] result = s.TwoSumPrime(nums, target);
            //int[] result = s.TwoSumHash(nums, target);
            int[] result = s.TwoSumDictionary(nums, target);
            foreach (int num in result)
            {
                Console.WriteLine($"The result is { num }");
            }        
        }
    }

  
    public class Solution
    {
        /// <summary>
        /// Solution using two nested for loops for a runtime complexity of On^2
        /// </summary>
        /// <param name="nums">integer array</param>
        /// <param name="target">integer for two numbers to add to</param>
        /// <returns></returns>
        public int[] TwoSumPrime(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)  // N O(N^2)
            {
                for (int j = i+1; j < nums.Length; j++)  // N - O(N)
                {
                    // O(1)
                    if (nums[i] + nums[j] == target)
                    {
                        Console.WriteLine($"The numbers in the array that add to {target} are [{i}] and [{j}]");
                        int[] returnArr = new int[] { i, j };
                        return returnArr;
                    }
                }
            }
            return null;
        }

        public int[] TwoSumHash(int[] nums, int target)
        {
            Hashtable hashtable = new Hashtable();
            for(int i=0; i<nums.Length-1; i++)
            {
                hashtable.Add(i, nums[i]);
                int compliment = target - nums[i];
                //add if statement here to try and do this with only one loop
            }

            for(int i=0; i<nums.Length; i++)
            {
                int compliment = target - nums[i];
                if ((hashtable.ContainsKey(compliment)) && (hashtable.ContainsValue(compliment != i)))
                        {
                        return new int[] { i, compliment};

                        }
                
            }

            Console.WriteLine("No matches found");
            throw new Exception(message : "No matches found");
        }

        public int[] TwoSumDictionary(int[] nums, int target)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for(int i = 0; i<nums.Length; i++)
            {
                dictionary.Add(i, nums[i]);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int compliment = target - nums[i];
                if (dictionary.ContainsKey(compliment) &&  (i != dictionary[compliment]))
                {
                    return new int[] { i, dictionary[compliment] };
                }
            }

            Console.WriteLine("No matches found");
            throw new Exception(message: "No matches found");
        }

        public int[] TwoSum(int[] nums, int target)
        {
            int i = 0;
            int j = 1;

            while(i<=nums.Length-2)

             {
                while (j <= nums.Length - 1)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        Console.WriteLine($"The numbers in the array that add to {target} are [{i}] and [{j}]");
                        int[] returnArr = new int[] { i, j };
                        return returnArr;

                    }
                
                    j++;
                    
                }
            i++;
                j = i + 1;    
            }
            Console.WriteLine("No matches found");
            return null;
 
        }
    } 
}

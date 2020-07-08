using System;
using System.Globalization;
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
            int[] result = s.TwoSumPrime(nums, target);
            foreach (int num in result)
            {
                Console.WriteLine($"The result is { num }");
            }        
        }
    }

    public class Solution
    {
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

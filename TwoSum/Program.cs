using System;
using System.Globalization;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 9;
            Solution s = new Solution();
            s.TwoSum(nums, target);
        }
    }

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int i = 0;
            int j = 1;

            while(i<=nums.Length-2 && j<= nums.Length -1)

             {
                if (nums[i] + nums[j] == target)
                {
                    Console.WriteLine($"The numbers in the array that add to {target} are [{i}] and [{j}]");
                    j++;
                }

                i++;
                //int index1 = int nums.Indexof(Array nums, [i]);
                //return nums.IndexOf[i]; [i + i];
            }
                return nums;
        }
    } 
}

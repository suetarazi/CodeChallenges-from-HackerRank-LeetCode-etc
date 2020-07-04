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
                    //Console.WriteLine($"The numbers in the array that add to {target} are [{i}] and [{j}]");
                    //return i, j; 
                    j++;
                }

                i++;
                
            }
            int indexI = Array.IndexOf<int>(nums, i);
            int indexJ = Array.IndexOf<int>(nums, j);
                return [indexI, indexJ];
        }
    } 
}

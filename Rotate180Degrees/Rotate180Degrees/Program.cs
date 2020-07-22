using System;
using System.IO;

namespace Rotate180Degrees
{

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Solution s = new Solution();
            int N = 34563;
            int totalCount = s.RotatedDigits(N);
            Console.WriteLine(totalCount);
        }
    }

    public class Solution
    {
        public int RotatedDigits(int N)
        {
            string strN = N.ToString();
            //Console.WriteLine($"strN is {strN}");
            char[] charN = strN.ToCharArray();
            int count = 0;
            int totalCount = 0;

            for (int i = 0; i < charN.Length; i++)
            //Console.WriteLine($"charN characters are {n}");
            {
                //try
                //{
                    if (charN[i] == 2)
                    {
                        charN[i] = '5';
                        Console.WriteLine($"i is {i} and charN[i] is {charN[i]}");
                        count++;
                        totalCount += count;
                    }
                    else if (charN[i] == 5)
                    {
                        charN[i] = '2';
                        Console.WriteLine($"i is {i} and charN[i] is {charN[i]}");
                        count++;
                        totalCount += count;
                    }
                    else if (charN[i] == 6)
                    {
                        charN[i] = '9';
                        Console.WriteLine($"i is {i} and charN[i] is {charN[i]}");
                        count++;
                        totalCount += count;
                    }
                    else if (charN[i] == 9)
                    {
                        charN[i] = '6';
                        Console.WriteLine($"i is {i} and charN[i] is {charN[i]}");
                        count++;
                        totalCount += count;
                    }
                Console.WriteLine($"the total count is {totalCount}");
                Console.WriteLine($"count is {count}");
                return totalCount;
                    
                
                //catch (Exception ex)
                //{
                //    Console.WriteLine("No results found", ex.Message);
                //}
            }
            return count;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Data;
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
            List<string> totalCount = s.RotatedDigits(N);
            Console.WriteLine(totalCount);
        }
    }

    public class Solution
    {
        public List<string> RotatedDigits(int N)
        {
            string strN = N.ToString();
            List<string> result = new List<string>();
            //Console.WriteLine($"strN is {strN}");
            foreach (char c in strN)
            {
                Console.WriteLine($"{c} value was added to the result list");
                result.Add(Map(c));
            }

            Console.WriteLine($"We are back from the switch and the result is {result}");
            return result;
            //return int.Parse(result);

            int count = 0;
            int totalCount = 0;

        }

        public string Map(char c)
        {
            switch(c)
            {
                case '2':
                    c = '5';
                    Console.WriteLine($"2 is now {c}");
                    break;
                    
                case '5':
                    c = '2';
                    Console.WriteLine($"5 is now {c}");
                    break;
                case '6':
                    c = '9';
                    Console.WriteLine($"6 is now {c}");
                    break;
                case '9':
                    c = '6';
                    Console.WriteLine($"9 is now {c}");
                    break;
                default:
                    c = c;
                    break;
            }
            Console.WriteLine($"return statement from switch is {c.ToString()}");
            return c.ToString();
            
        }
        //            if (charN[i] == 2)
        //            {
        //                charN[i] = '5';
        //                Console.WriteLine($"i is {i} and charN[i] is {charN[i]}");
        //                count++;
        //                totalCount += count;
        //            }
        //            else if (charN[i] == 5)
        //            {
        //                charN[i] = '2';
        //                Console.WriteLine($"i is {i} and charN[i] is {charN[i]}");
        //                count++;
        //                totalCount += count;
        //            }
        //            else if (charN[i] == 6)
        //            {
        //                charN[i] = '9';
        //                Console.WriteLine($"i is {i} and charN[i] is {charN[i]}");
        //                count++;
        //                totalCount += count;
        //            }
        //            else if (charN[i] == 9)
        //            {
        //                charN[i] = '6';
        //                Console.WriteLine($"i is {i} and charN[i] is {charN[i]}");
        //                count++;
        //                totalCount += count;
        //            }
        //        Console.WriteLine($"the total count is {totalCount}");
        //        Console.WriteLine($"count is {count}");
        //        return totalCount;
                    
                
        //        //catch (Exception ex)
        //        //{
        //        //    Console.WriteLine("No results found", ex.Message);
        //        //}
        //    }
        //    return count;
        //}
    }
}


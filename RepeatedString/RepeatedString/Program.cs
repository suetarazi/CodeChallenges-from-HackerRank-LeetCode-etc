using System;
using System.Linq;

namespace RepeatedString
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string testString = "aba";
            long n = 10;
            Program p = new Program();
            CountRepeatedString(testString, n);
            
        }

        public static long CountRepeatedString(string s, long n)
        {
            //abaabaabaa
            //aba 

            long count = 0;
            
            //2. determine arrayLooping variable
            long arrayLooping = n/(s.Length);
            
            //3. determine remainderLoop variable
            long remainderLoop = n % s.Length;
            
            //1. count "a"s in string (result is 2)
                for(int j=0; j<s.Length; j++)
                {
                    if(s[j]=='a')
                    {
                        count++;
                    }
                }

            long remainderLoopCount = 0;
            for(int k=0; k<remainderLoop; k++)
            {
                if(s[k]=='a')
                {
                    remainderLoopCount++;
                }
            }

            //4. totalCount = (count * arrayLooping) + (forloop of k)
            long totalCount = (count * arrayLooping) + remainderLoopCount;
            Console.WriteLine($"the total count is {count}");
            return totalCount;
            
            //long arrLength = s.ToArray().Length;
            //string[] inputArr = Enumerable.Repeat(s, Convert.ToInt32(n)).ToArray();
            //foreach(string st in inputArr)
            //{
            //    Console.WriteLine($"{st}");
            //}

            //char[] inputChar = inputArr.ToCharArray();
            //foreach (char c in inputChar)
            //{
            //    Console.WriteLine();
            //}
            long occurancesOfA = 0;
            //for(int i=0; i<inputChar.Length; i++)
            //{
            //    if (inputArr[i] == "a")
            //    {
            //        occurancesOfA++;
            //    }
            //}

            //return occurancesOfA;
        }
    }
}

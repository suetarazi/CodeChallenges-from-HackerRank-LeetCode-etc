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
            //1. count "a"s in string (result is 2)
            //2. determine arrayLooping variable
            //3. determine remainderLoop variable
            //4. totalCount = (count * arrayLooping) + (forloop of k)

            long count = 0;
            long arrayLooping = n/(s.Length);
            long remainderLoop = n % s.Length;

            for(int i=0; i<arrayLooping; i++)
            {
                for(int j=0; j<s.Length; j++)
                {
                    if(s[j]=='a')
                    {
                        count++;
                    }
                }
            }
            for(int k=0; k<remainderLoop; k++)
            {
                if(s[k]=='a')
                {
                    count++;
                }
            }
            Console.WriteLine($"the total count is {count}");
            return count;
            
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

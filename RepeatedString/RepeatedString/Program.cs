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
            
            long arrLength = s.ToArray().Length;
            string[] inputArr = Enumerable.Repeat("s", Convert.ToInt32(n)).ToArray();

            char[] inputChar = inputArr.ToCharArray();
            foreach (char c in inputChar)
            {
                Console.WriteLine();
            }
            long occurancesOfA = 0;
            for(int i=0; i<inputChar.Length; i++)
            {
                if (inputArr[i] == "a")
                {
                    occurancesOfA++;
                }
            }

            return occurancesOfA;
        }
    }
}

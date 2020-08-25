using System;
using System.Linq;

namespace RepeatedString
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static long CountRepeatedString(string s, long n)
        {
            long arrLength = s.ToArray().Length;
            string[] inputArr = Enumerable.Repeat("s", (s.Count<Tchar>*n)).ToArray();
            long occurancesOfA = 0;
            for(int i=0; i<n; i++)
            {
                if(s[i]=='a')
                {
                    occurancesOfA++;
                }
            }

            return occurancesOfA;
        }
    }
}

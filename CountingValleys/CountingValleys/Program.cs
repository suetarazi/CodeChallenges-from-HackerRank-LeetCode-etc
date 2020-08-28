using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace CountingValleys
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int countingValleys(int n, string s)
        {
            //if U = 1 and D = -1; count the number of times the string changes from + to -
            int valleys = 0;
            int seaLevel = 0;
             
            
            for(int i=0; i<n; i++)
            {
                if(s[i] == 'U')
                {
                    seaLevel += 1;
                }
                else
                {
                    seaLevel -= 1;
                }

                if(s[i] == 'U' && seaLevel == 0)
                {
                    valleys++;
                }

            }
            return valleys;
        }

    }
}

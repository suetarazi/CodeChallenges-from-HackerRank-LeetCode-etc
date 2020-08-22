using System;
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
            int U = 1;
            int D = -1; 
            char[] arr = s.ToCharArray();
            for(char c=arr[0]; c<n; c++)
            {
                U = 1;
                D = -1;
                
            }


            return valleys;
        }

    }
}

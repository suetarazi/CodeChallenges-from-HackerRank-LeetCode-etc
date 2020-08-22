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
            //int U = 1;
            //int D = -1; 
            char[] arr = s.ToCharArray();
            int[] numArr = new int[n];
            for(char c=arr[0]; c<n; c++)
            {
                if(arr[c] == 'U')
                {
                    numArr[c] = 1;
                }
                else
                {
                    numArr[c] = -1;
                }

            }
            foreach(int i in numArr)
            {
                int sum = 0;
                if(sum < 0)
                {
                    valleys++;
                }
                sum += numArr[i];
            }

            return valleys;
        }

    }
}

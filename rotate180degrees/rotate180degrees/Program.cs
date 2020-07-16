using System;

namespace rotate180degrees
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Solution s = new Solution();
            int N = 34563;
            int count = s.RotatedDigits(N);
            Console.WriteLine(count);
        }
    }

    public class Solution
    {
        public int RotatedDigits(int N)
        {
            string strN = N.ToString();
            char[] charN = strN.ToCharArray();
            int count = 0;
            foreach (char n in charN)

            {
                if (N == 2)
                {
                    N = 5;
                    count++;
                }
                else if (N == 5)
                {
                    N = 2;
                    count++;
                }
                else if (N == 6)
                {
                    N = 9;
                    count++;
                }
                else if (N == 9)
                {
                    N = 6;
                    count++;
                }
                else;
        }
            return count;
        }
    }
}

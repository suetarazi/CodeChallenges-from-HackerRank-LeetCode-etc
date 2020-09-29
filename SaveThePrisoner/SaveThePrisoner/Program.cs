using System;

namespace SaveThePrisoner
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int saveThePrisoner(int n, int m, int s)
        {
            int[] prisoners = new int[n];
            int arrStop = Math.Abs(n - m);
            int lastRound = Math.Abs(arrStop - n);
            int badCandy = lastRound/s;
            //int badCandy = prisoners[s + lastRound];

            return badCandy;
        }

    }
}

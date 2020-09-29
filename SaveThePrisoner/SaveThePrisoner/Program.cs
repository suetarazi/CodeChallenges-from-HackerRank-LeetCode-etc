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
            
            int arrStop = Math.Abs(n - m);
            int lastRound = Math.Abs(arrStop - n);
            int badCandy = s + lastRound - 1;
            
            return badCandy;
        }

    }
}

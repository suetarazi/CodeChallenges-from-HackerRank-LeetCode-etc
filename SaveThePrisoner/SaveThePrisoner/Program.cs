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
            //3 7 3 
            int steps = m % n;
            int badCandy = (s + steps -1) % n;
            if (badCandy == 0)
            {
                return s;
            }
            else
            {
                return badCandy;
            }
        }

    }
}

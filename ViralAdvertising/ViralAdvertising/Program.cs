using System;

namespace ViralAdvertising
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        public int viralAdvertising(int n)
        {
            int cumulative = 0;
            decimal recipients = 5;
            decimal dailyLikes = 0;
            int days = 1;

            while (days <= n)
            {
                dailyLikes = Math.Floor(recipients / 2);
                recipients = dailyLikes * 3;
                cumulative += Convert.ToInt32(dailyLikes);

                days++;
            }

            return cumulative;
        }
    }
}

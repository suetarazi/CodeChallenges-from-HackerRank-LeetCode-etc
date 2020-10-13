using System;

namespace AppleAndOrange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s">st = width of house</param>
        /// <param name="t">st = width of house</param>
        /// <param name="a">distance of apple tree from house</param>
        /// <param name="b">distance of orange tree from house</param>
        /// <param name="apples">array of apples and the distances they fall from a</param>
        /// <param name="oranges">array of oranges and the distances they fall from b</param>
        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int appleCount = 0;
            int orangeCount = 0;
            for(int i=0; i<apples.Length; i++)
            {
                if(apples[i]>=(s-a) && (apples[i] <= (t-a)))
                    {
                    appleCount++;
                    }
            }

            for(int j=0; j<oranges.Length; j++)
            {
                if(oranges[j]<(b-t) && (oranges[j]>(b-s)))
                {
                    orangeCount++;
                }
            }

            Console.WriteLine($"{appleCount} {orangeCount}");
        }
    }
}

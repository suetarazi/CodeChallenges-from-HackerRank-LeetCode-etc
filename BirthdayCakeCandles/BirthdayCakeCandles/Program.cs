using System;
using System.Collections.Generic;

namespace BirthdayCakeCandles
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            List<int> testList = new List<int> { 3, 2, 1, 3 };
            p.birthdayCakeCandles(testList);
        }

        public int birthdayCakeCandles(List<int> candles)
        {
            int candleCount = 1;
            candles.Sort();
            candles.Reverse();

            for(int i=0; i<candles.Count; i++)
            {
                if(candles[i+1] == candles[i])
                {
                    candleCount++;
                }

                else
                {
                    
                    return candleCount;
                }

            }


            return candleCount;
        }
    }
}

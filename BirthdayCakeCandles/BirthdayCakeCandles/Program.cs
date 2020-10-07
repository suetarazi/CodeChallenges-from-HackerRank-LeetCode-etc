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

        /// <summary>
        /// This method utilizes built in methods of Sort() and Reverse(), but requires multiple passes through the array. It is therefore O(n) for the Sort() + O(n) for the Reverse() + at worst O(n) for the pass through the array comparing candle heights 
        /// </summary>
        /// <param name="candles"></param>
        /// <returns>int candleCount</returns>
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

        /// <summary>
        /// This method solves the problem in O(n), only making ONE pass through the array 
        /// </summary>
        /// <param name="inputArr"></param>
        /// <returns>int candleCount</returns>
        public int CandleCount(int[] inputArr)
        {
            int tallestCandle = inputArr[0];
            int candleCount = 0;

            foreach (int c in inputArr)
            {
                if (c > tallestCandle)
                {
                    tallestCandle = c;
                    candleCount = 1;

                }
                if (c == tallestCandle)
                {
                    candleCount++;
                }

            }
            return tallestCandle;
        }
    }
}

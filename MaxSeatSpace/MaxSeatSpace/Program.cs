using System;

namespace MaxSeatSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Solution s = new Solution();
            int[] seats = new int[] { 1, 0, 0, 0, 1, 0, 1 };
            Console.WriteLine(s.MaxDistToClosest(seats)); 
        }


    }

    public class Solution
    {
        public int MaxDistToClosest(int[] seats)
        {
            //count max number of 0's in array
            
            int count = 0;
            int max = 0;
            int maxStartIndex = 0;
            int assignedSeat = 0;
            for(int i = 0; i < seats.Length; i++)
            {
                if(seats[i]==0)
                {
                    count++;
                    max = count;
                    maxStartIndex = i;
                }
            }
            
            if(maxStartIndex == 0)
            {
                return assignedSeat = seats[0];
            }
            else if(maxStartIndex+max == seats.Length)
            {
                return assignedSeat = seats.Length;
            }
            else
            {
                int x = (max - maxStartIndex) / 2;
                return assignedSeat = maxStartIndex + x;

            }
        }
    }
}

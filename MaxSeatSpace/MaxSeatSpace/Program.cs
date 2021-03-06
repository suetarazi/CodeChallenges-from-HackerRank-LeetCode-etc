﻿using System;

namespace MaxSeatSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Solution s = new Solution();
            //int[] seats = new int[] { 1, 0, 0, 0, 1 };
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
                if(seats[i]==0 && seats[i+1]!=1)
                {
                    maxStartIndex = i;
                    count++;
                    max = count;
                }
            }
            
            if(maxStartIndex == 0)
            {
                assignedSeat = seats[0];
                return assignedSeat;
            }
            else if(maxStartIndex+max == seats.Length)
            {
                assignedSeat = seats.Length;
                return assignedSeat;
            }
            else
            {
                int x = (max - maxStartIndex) / 2;
                assignedSeat = maxStartIndex + x;
                return assignedSeat;

            }
        }
    }
}

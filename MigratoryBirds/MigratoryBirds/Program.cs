using System;
using System.Collections.Generic;
using System.Linq;

namespace MigratoryBirds
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> testList = new List<int> { 1, 4, 4, 4, 5, 3 };
            int result = migratoryBirds(testList);
        }

        public static int migratoryBirds(List<int> arr)
        {
            //all birds are either type 1, 2, 3, 4 or 5

            int[] birdCount = new int[5];

            foreach(int bird in arr)
            {
                if(bird == 1)
                {
                    birdCount[0]++;
                    Console.WriteLine($"birdCount at [0] is now {birdCount[0]}");
                }
                if(bird == 2)
                {
                    birdCount[1]++;
                    Console.WriteLine($"birdCount at [1] is now {birdCount[1]}");
                }
                if(bird == 3)
                {
                    birdCount[2]++;
                    Console.WriteLine($"birdCount at [2] is now {birdCount[2]}");
                }
                if(bird == 4)
                {
                    birdCount[3]++;
                    Console.WriteLine($"birdCount at [3] is now {birdCount[3]}");
                }
                if(bird == 5)
                {
                    birdCount[4]++;
                    Console.WriteLine($"birdCount at [4] is now {birdCount[4]}");
                }
            }

            int bigBird = birdCount.Max();
            return Array.IndexOf(birdCount, bigBird) + 1;

            //foreach(int b in birdCount)
            //{
            //    Console.WriteLine($"birdCount array is: {b}");
            //}

            //if(birdCount[birdCount.Length-1] == birdCount[birdCount.Length - 2])
            //{
            //    return birdCount[birdCount.Length - 2] + 1;
            //}
            //else
            //{
            //    return birdCount[birdCount.Length - 1] + 1;
            //}

        }
    }
}

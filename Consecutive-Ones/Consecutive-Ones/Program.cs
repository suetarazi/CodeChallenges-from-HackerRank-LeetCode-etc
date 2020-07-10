using System;

namespace CountOnes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //CountOnes c = new CountOnes();
            int[] arr = new int[] { 1, 1, 0, 1, 1, 1 };
            Console.WriteLine(CountOnes(arr)); 
            
        }

    //Given a binary array, find the maximum number of consecutive 1s in this array.

    //{1,1,0,1,1,1}

        public static int CountOnes(int[] arr)
        {
            int count = 0;
            int maxCount = 0;

            foreach(int num in arr)
            {
                if(num == 1)
                {
                    count++;
                    maxCount = count;
                }
                else
                {
                    maxCount = count;
                    count = 0;
                }

            }
            //Console.WriteLine(maxCount);
            return maxCount;
        }

    }
}

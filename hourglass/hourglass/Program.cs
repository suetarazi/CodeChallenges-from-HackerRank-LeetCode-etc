using System;
using System.IO;

namespace hourglass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            //int result = Solution.hourglassSum(arr);

            //textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();

        }
    }

    class Solution
    {

        // Complete the hourglassSum function below.
        static int hourglassSum(int[][] arr)
        {
            int sum = 0;
            for (int j = 0; j < arr.Length - 2; j++)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    int hourglass = i + (i + 1) + (i + 2);
                }
            }
            return sum;
        }

    }

}

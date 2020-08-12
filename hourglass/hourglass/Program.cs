using System;
using System.IO;

namespace hourglass
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int[][] arr = new int[6][]
                {
            new int[] { 1, 1, 1, 0, 0, 0 },
            new int[] { 0, 1, 0, 0, 0, 0 },
            new int[] { 1, 1, 1, 0, 0, 0 },
            new int[] { 0, 0, 2, 4, 4, 0 },
            new int[] { 0, 0, 0, 2, 0, 0 },
            new int[] { 0, 0, 1, 2, 4, 0 }
            };

            //for (int i = 0; i < 6; i++)
            //{
            //    arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            //}

            //Solution solution = new Solution();
            int result = Solution.hourglassSum(arr);
            Console.WriteLine(result);
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();

        }
    }

    public class Solution
    {

        // Complete the hourglassSum function below.
        public static int hourglassSum(int[][] arr)
        {
            int sum = 0;
            for (int j = 0; j < arr.Length - 2; j++)
            {
                for (int i = 0; i < arr.Length - 2; i++)
                {
                    int hourglass = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i+1][j+1] + arr[i+2][j] + arr[i+2][j+1] + arr[i+2][j+2];
                    Console.WriteLine($"hourglass is {hourglass}");
                    if(hourglass > sum)
                    {
                        sum = hourglass;
                        
                    }
                }

            }
            Console.WriteLine($"sum is {sum}");
            return sum;
        }

    }

}

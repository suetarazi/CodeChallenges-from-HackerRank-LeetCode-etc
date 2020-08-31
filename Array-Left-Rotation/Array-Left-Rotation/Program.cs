using System;

namespace Array_Left_Rotation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int[] LeftRotation(int n, int d, int[] inputArr)
        {
            
            while(< d)
            {
                int temp = inputArr[0];

                for(int i=0; i<inputArr.Length - 1; i++)
                {
                    inputArr[i] = inputArr[i + 1];
                }

                inputArr[inputArr.Length] = temp;
            }

            return inputArr;
        }
    }
}

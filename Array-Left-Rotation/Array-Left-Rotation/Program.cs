using System;
using System.Globalization;

namespace Array_Left_Rotation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            int testd = 4;
            int[] testInput = new int[] { 1, 2, 3, 4, 5 };
            Program p = new Program();
            p.LeftRotation2(testInput, testd);
            ////foreach(int num in actual)
            ////{
            ////    Console.WriteLine(string.Join (", ", num));
            ////}
        }

        public int[] LeftRotation(int[] inputArr, int d)
        {
            int n = inputArr.Length;

            for(int j = 0; j < d; j++)
            {
                int temp = inputArr[0];

                for(int i=0; i< n - 1; i++)
                {
                    inputArr[i] = inputArr[i + 1];
                }

                inputArr[inputArr.Length-1] = temp;
            }

                        
            Console.WriteLine("{0}", string.Join(" ", inputArr));
            
           return inputArr;
        }

        public void LeftRotation2(int[] inputArr, int d)
        {
            int n = inputArr.Length;
            //Console.Write(inputArr[d]);

            for(int i=0; i<inputArr.Length; i++)
            {
                Console.Write($"{ inputArr[(d + i) % n]} ");
                
            }


            
        }
    }
}

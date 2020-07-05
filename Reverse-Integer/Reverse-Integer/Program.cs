using System;

namespace ReverseInteger
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");
                int x = 123;
                Solution s = new Solution();
                //s.Reverse(x);
                s.ReverseArray(x);
            }
        }

        public class Solution
        {
            public int Reverse(int x)
            {
                int[] input = new int[] { 1, 2, 3 };

                for (int i = input.Length - 1; i > 0; i--)
                {
                    Console.WriteLine(input[i]);
                    input[i] = i;
                }


                foreach (int num in input)
                {
                    Console.WriteLine(num);
                    return input[num];
                }

                return x;
            }

            public int ReverseArray(int x)
            {
                int[] input = new int[] { 1, 2, 3 };

                Array.Reverse<int>(input);

                Console.WriteLine(string.Join(" ", input));

                return x; //string.Join(" ", input); 
            }
        }
    }



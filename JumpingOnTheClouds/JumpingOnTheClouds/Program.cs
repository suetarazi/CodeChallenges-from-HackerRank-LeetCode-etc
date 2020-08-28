using System;

namespace JumpingOnTheClouds
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            int[] arr = new int[] { 0, 0, 1, 0, 0, 1, 0 };
            int[] arr2 = new int[] { 0, 0, 0, 1, 0, 0 };
            //p.jumpingOnClouds(arr2);
        }

        public int jumpingOnClouds(int[] c)
        {
            //[0, 0, 1, 0, 0, 1, 0]
            int totalSteps = 0;
            int i = 0;
            while(i<c.Length-1)
            {
                if(c[0]==1)
                {
                    Console.WriteLine("You are starting with 1");
                    i++;
                }
                else if(c[i+1]==0 && i+2 < c.Length && c[i + 2] == 0)
                {
                    totalSteps++;
                    i++;
                    i++;
                    Console.WriteLine($"adding two steps yields {totalSteps}");
                }
                else if(c[i+1]==0 && i+2 < c.Length && c[i+2]!=0)
                {
                    totalSteps++;
                    i++;
                    Console.WriteLine($"adding one step yields {totalSteps}");
                }
                else if(c[i+1]!=0 && c[i+2]==0)
                {
                    totalSteps++;
                    i++;
                    i++;
                }
            }

            Console.WriteLine($"The total number of steps is {totalSteps}");
            return totalSteps;

        }
    }
}

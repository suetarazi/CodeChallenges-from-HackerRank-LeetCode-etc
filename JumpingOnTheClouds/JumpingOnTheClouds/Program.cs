using System;

namespace JumpingOnTheClouds
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int jumpingOnClouds(int[] c)
        {
            int totalSteps = 0;
            foreach(int i in c)
            {
                if(c[i]==1)
                {
                    return 0;
                }
                else if(c[i]==0 && c[i+2]==0)
                {
                    totalSteps++;
                    totalSteps++;
                }
                else if(c[i]==0 && c[i+1]==0)
                {
                    totalSteps++;
                }
            }

            return totalSteps;

        }
    }
}

using System;

namespace ElectronicsStore
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int testb = 10;
            int testn = 2;
            int testm = 3;
            int[] testKeyboards = new int[] { 3, 1 };
            int[] testDrives = new int[] { 5, 2, 8 };
            Program p = new Program();
            p.getMoneySpent(testKeyboards, testDrives, testb);
        }

        public int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            int max = -1;
            for(int i=0; i<keyboards.Length; i++)
            {
                for(int j=0; j<drives.Length; j++)
                {
                    int price = keyboards[i] + drives[j];
                        if(price <= b && price > max) 
                        {
                        max = price;
                        //return max;
                        Console.WriteLine($"The max price is {max}");
                        }


                    return max;
                }
            }
                    return max;    


        }

    }
}

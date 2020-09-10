using System;

namespace CatsAndAMouse
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public string catAndMouse(int x, int y, int z)
        {
            
            int d1 = Math.Abs(z - x);
            int d2 = Math.Abs(z - y);

            if(d1 == d2)
            {
                Console.WriteLine($"The winner is Mouse C");
                return "Mouse C";
            }
            else if(d1 > d2)
            {
                Console.WriteLine($"The winner is Cat A");
                return "Cat B";
            }
            else if(d2 > d1)
            {
                Console.WriteLine($"The winner is Cat B");
                return "Cat A";
            }
            else

            return "-1";
        }

    }
}

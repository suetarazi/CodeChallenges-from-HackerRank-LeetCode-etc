using System;
using System.Collections.Generic;

namespace BalancedTeams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int MaxBalancedTeams(List<int> developers, int maxNewHires)
        {
            developers.Sort();
            int maxBalanced = 1;

            //start with width 1: start = 0; end = 0;
            while(maxNewHires != null)
                {

            }

            return maxBalanced;
        }
//        Sort teams[5, 4, 1, 3, 4] -> [1,3,4,4,5]

//        start maxBalanced = 1;
//        Start with width 1: start = 0, end = 0
//while(end<size):
//    if (balancable)
//        record
//        end++, window.add
//    else
//        start++, window.remove


//Window:
//    total, count, max
//    required = (max * count) - total
//    add: max = value, total+=value, count++
//    remove: total-= value, count--


    }
}

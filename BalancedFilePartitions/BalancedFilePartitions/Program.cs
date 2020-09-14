using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedFilePartitions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int mostBalancedPartition(List<int> parent, List<int> files_size)
        {
            List<int> branch1 = new List<int>();
            List<int> branch2 = new List<int>();

            //how to turn a list into a tree?  
            //tree.Left goes to branch1; tree.Right goes to branch2; 



            int AbsDiff = Math.Abs(branch1.Sum() - branch2.Sum());
            return AbsDiff;
        }

    }
}

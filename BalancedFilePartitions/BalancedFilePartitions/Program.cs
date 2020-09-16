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

//        public static int mostBalancedPartition(List<int> parent, List<int> files_size)
  //      {
    //        List<int> branch1 = new List<int>();
      //      List<int> branch2 = new List<int>();

            //how to turn a list into a tree?  
            //tree.Left goes to branch1; tree.Right goes to branch2; 



        //    int AbsDiff = Math.Abs(branch1.Sum() - branch2.Sum());
          //  return AbsDiff;
       // }

        public class Node
    {
        public int files = 0;
        public int total = 0;  // Sum of this node and all descendent files
        public List<Node> children = new List<Node>();
    }

    static int calculateTotal(Node node)
    {
        node.total = node.files;
        foreach (var child in node.children)
        {
            node.total += calculateTotal(child);
        }
        return node.total;
    }

    static int mostBalancedPartition(List<int> parent, List<int> files_size)
    {
        // Construct directories - O(N)
        List<Node> nodes = new List<Node>();
        for (int i = 0; i < files_size.Count; i++)
        {
            Node n = new Node();
            n.files = files_size[i];
            nodes.Add(n);
        }

        // Link into a tree - O(N)
        for (int i = 0; i < parent.Count; i++)
        {
            if (parent[i] != -1)
            {
                // parent[i] = j   ->   j is i's parent
                nodes[parent[i]].children.Add(nodes[i]);
            }
        }

        // Fill in totals - O(N)
        calculateTotal(nodes[0]);

        // Find the cheapest cut - O(N)
        return cheapestCut(nodes[0]);
    }

    public static int cheapestCut(Node node)
    {
        int cheapest = int.MaxValue;
        cheapestCut(node, ref cheapest);
        return cheapest;
    }

    private static void cheapestCut(Node node, ref int cheapest)
    { 
        // Local edges
        foreach (var child in node.children)
        {
            int cutCost = node.total - child.total;
            if (cutCost < cheapest)
            {
                cheapest = cutCost;
            }
            cheapestCut(child, ref cheapest);
        }
    }

        
    }
}

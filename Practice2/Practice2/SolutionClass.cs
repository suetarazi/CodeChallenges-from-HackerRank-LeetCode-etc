using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;

namespace Practice2
{
    class Node
    {
        public int id;
        public List<Node> neighbors;
    }


    class SolutionClass
    {
        // BFS - Print IDs in breadth first order
        public static void visitAll(Node start)
        {
            //make a scratch pad to keep track of which nodes have been visited:
            List<Node> scratch = new List<Node>();

            //make a queue
            Queue<Node> queue = new Queue<Node>();
             
            queue.Enqueue(start); //{0,0}
            scratch.Add(start);
            Console.WriteLine(start.id);
            
            while(queue.Count != 0)
            {
                Node n = queue.Dequeue();
                    

                foreach(Node node in n.neighbors)
                {
                    if(!scratch.Contains(node))
                    {
                    queue.Enqueue(node); //neighbors are 1 away from {0,0}
                    scratch.Add(node);
                    Console.WriteLine(node.id);
                    }
                }
               
               
                }
            }


        }
        public static int shortestPathLength(Node start, Node end)
        {
            // Start at the start
            // Create a set of nodes S that are reachable from start
            // Create a set of nodes S' thar are reachable from S and have not yet been in any set
            // Repeat until you reach end
            // Return number of sets (+/-1?)



            Queue<Node> queue = new Queue<Node>(); 
            queue.Enqueue(start); //{0,0}
            
            




        }
        public static int calculateDistance(string cityMap)
        {


        }

    }
}

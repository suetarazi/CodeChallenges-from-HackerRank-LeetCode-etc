using System;
using System.Net.Http.Headers;

namespace InsertANodeAtTheTailOfALinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int n = 15;
            fizzBuzz(n);
        }

        ////static SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode head, int data)

        ////while(head != null)
        ////{
        ////    SinglyLinkedListNode node = new SinglyLinkedListNode();
        ////    node.data = data;
        ////    Console.WriteLine(node.data);
        ////    node = head.next;
        ////    head = node;
        ////}
        ///
        public static void fizzBuzz(int n)
        {
            string[] inputArr = new string[n + 1];

            for(int i=1; i<=n; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    inputArr[i] = "FizzBuzz";
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    inputArr[i] = "Fizz";
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    inputArr[i] = "Buzz";
                    Console.WriteLine("Buzz");
                }
                else
                {
                    inputArr[i] = i.ToString();
                    Console.WriteLine($"{inputArr[i]}");
                }
            }
            foreach(string s in inputArr)
            {
                Console.WriteLine(s);
            }
        }

    }
}


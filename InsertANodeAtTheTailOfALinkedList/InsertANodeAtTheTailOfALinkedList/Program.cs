using System;
using System.Net.Http.Headers;

namespace InsertANodeAtTheTailOfALinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode head, int data)
        
        while(head != null)
        {
            SinglyLinkedListNode node = new SinglyLinkedListNode();
            node.data = data;
            Console.WriteLine(node.data);
            node = head.next;
            head = node;
        }
    }
}

using System;

namespace PrintElementsOfLinkedList
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

              //  For your reference (from HackerRank):
     
              //SinglyLinkedListNode {
              //    int data;
              //    SinglyLinkedListNode next;
              //}
     

        static void printLinkedList(SinglyLinkedListNode head)
        {
            while (head != null)
            {

                Console.WriteLine(head.data);
                head = head.next;
            }


        }
    }

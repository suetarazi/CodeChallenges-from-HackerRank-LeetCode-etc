using CircularQueue.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http.Headers;

namespace CircularQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int size = 16; 
        }
    }

    // A max-length queue based on an array
    public class CircularBuffer<T> : IEnumerable<T>
    {
        private readonly T[] data;
        private static object node;

        public int front { get; set; }
        public int rear { get; set; }

        int size = 16;

        Queue queue = new Queue(size);
        public CircularBuffer(int size)
        {
            this.data = new T[size];
            int maxSize = size - 1;
        }

        // Return the number of items in the buffer
        public static int Count()
        {
            //built in queue class contains a method called Count
            //return queue.Count;

            int count = 0;
        
            if(node != null)
            {
                count++;
                node = node.Next;
            }
            return count;

        }

        // Returns the item at the specified offest in the queue (from head).  Throws
        // IndexOutOfRangeException if the item doesn't exist.
        public T this[int index]
        {
            get
            {
                // Implement me!
            }
        }

        // Adds the item to the end if there's room.  Returns true if successful.
        public bool Enqueue(int item)
        {
            if (queue.Count != size)
            {
                queue.Enqueue(item);
                rear = item;
                return true;
            }
            else
            {
                return false;
            }
        }

        // Removes and returns the item at the front of the queue.  Throws
        // InvalidOperationException if the queue is empty.
        public T Dequeue()
        {
            if(queue.Peek = null)
            {
                throw new InvalidOperationException("The buffer is empty");
            }
            else
            {
                int temp = front + 1;
                queue.Dequeue();
                front = temp;

            }
        }



        public IEnumerator<T> GetEnumerator()
        {

            HashSet<string> listNames = new HashSet<string>();
            listNames.Add();
            listNames.SymmetricExceptWith
               
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
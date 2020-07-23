using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CircularQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    // A max-length queue based on an array
    public class CircularBuffer<T> : IEnumerable<T>
    {
        private readonly T[] data;

        public CircularBuffer(int size)
        {
            this.data = new T[size];
        }

        // Return the number of items in the buffer
        public int Count
        {
            get
            {
                // Implement me!
            }
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
        public bool Enqueue(T item)
        {
            // Implement me!
        }

        // Removes and returns the item at the front of the queue.  Throws
        // InvalidOperationException if the queue is empty.
        public T Dequeue()
        {
            // Implement me!
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
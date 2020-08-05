using CircularQueue.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            //int size = 16; 
        }
    }

    // A max-length queue based on an array
    public class CircularBuffer<T> : IEnumerable<T>
    {
        private readonly T[] data;
        //private static object node;

        private int _front;
        private int _rear;
        private int _count;

        int size;

          
        
        public CircularBuffer(int size)
        {
            data = new T[size];
            this.size = size;
            
        }

        // Return the number of items in the buffer
        public int Count
        {
            get
            {
                return _count;
            }
        }

        // Returns the item at the specified offest in the queue (from head).  Throws
        // IndexOutOfRangeException if the item doesn't exist.
        public T this[int index]
        {
            get
            {
                return data[(_front + index) % data.Length];
            //if(_front + index >= this.data.Length)
            //    {
            //        index = _front - this.data.Length + index;                   
            //        return this.data[index];
            //    }
            
            //T value = this.data[_front + index];
            //    return value;
            }
        }

        // Adds the item to the end if there's room.  Returns true if successful.
        public bool Enqueue(T item)
        {
            // TODO: What happens when you get to the end of the array, and it's not full?
            // TODO: What happens when the queue is full?

            int maxSize = size;
            
            if (Count == maxSize)
            {
                return false;
            }
            else
            {
                _rear++;
                if (_rear >= data.Length)
                {
                    _rear = 0;
                }
                data[_rear] = item;
                _count++;
                //] data + (_rear * sizeof(T))
                return true;
            }
        }

        // Removes and returns the item at the front of the queue.  Throws
        // InvalidOperationException if the queue is empty.
        public T Dequeue()
        {
            // % size of buffer
            if(Count == 0)
            {
                throw new InvalidOperationException("The buffer is empty");
            }
            else
            {
                _count--;
                _front++;
                    if(_front >= data.Length)
                    {
                        _front = 0;
                    }
                T value = data[_front];
                return value;

            }
        }



        public IEnumerator<T> GetEnumerator()
        {

            HashSet<string> listNames = new HashSet<string>();
            //listNames.Add();
            //listNames.SymmetricExceptWith

            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
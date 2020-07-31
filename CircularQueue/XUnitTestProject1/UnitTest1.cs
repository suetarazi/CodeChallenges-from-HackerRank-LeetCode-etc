using System;
using Xunit;
using CircularQueue;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Xunit.Sdk;

namespace XUnitTestProject1
{
    public class UnitTest1 : IEnumerable
    {
        [Fact]
        public void EmptyQueueTest()
        {
            CircularBuffer<int> testData = new CircularBuffer<int>(16);
            //is.Count = 0;
            //_rear + 1 == _front;
            //testData.Count = 0;
            //var actual = testData.Dequeue();
            //var expected = "The buffer is empty";
            Assert.Throws<InvalidOperationException>(() => testData.Dequeue());
        }

        public int Count { get; }
        [Fact]
        public void EnqueueItem()
        {
            CircularBuffer<int> testData = new CircularBuffer<int>(16);
            int item = 5;
            testData.Enqueue(item);
            int actual = this.Count;
            int expected = 1;
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void EnqueueThreeDequeueOneItems()
        {
            CircularBuffer<int> testData = new CircularBuffer<int>(16);
            int item1 = 6;
            int item2 = 8;
            int item3 = 22;
            testData.Enqueue(item1);
            testData.Enqueue(item2);
            testData.Enqueue(item3);
            testData.Dequeue();
            int actual = this.Count;
            int expected = 2;
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void EnqueueThreeDequeueOneReturnValue()
        {
            CircularBuffer<int> testData = new CircularBuffer<int>(16);
            int item1 = 6;
            int item2 = 8;
            int item3 = 22;
            testData.Enqueue(item1);
            testData.Enqueue(item2);
            testData.Enqueue(item3);
            int actual = testData.Dequeue();
            int expected = 6;
            Assert.Equal(expected, actual);
        }

        public void EnqueueFullBuffer()
        {
            CircularBuffer<int> testData = new CircularBuffer<int>(3);
            int item1 = 6;
            int item2 = 8;
            int item3 = 22;
            int item4 = 13;
            testData.Enqueue(item1);
            testData.Enqueue(item2);
            testData.Enqueue(item3);
            bool actual = testData.Enqueue(item4);
            Assert.False(actual);
        }
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

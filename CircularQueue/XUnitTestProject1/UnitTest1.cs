using System;
using Xunit;
using CircularQueue;
using System.Collections;
using System.Collections.Generic;

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

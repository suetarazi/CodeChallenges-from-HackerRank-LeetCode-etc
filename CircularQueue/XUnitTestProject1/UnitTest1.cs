using System;
using Xunit;
using CircularQueue;


namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void EmptyQueueTest()
        {
            CircularBuffer<int> testData = new CircularBuffer<int>(16);
            //is.Count = 0;
            _rear + 1 == _front;
            testData.Count = 0;
            var actual = testData.Dequeue();
            var expected = "The buffer is empty";
            Assert.Equal(expected, actual);
        }
    }
}

using BirthdayCakeCandles;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            List<int> testList = new List<int> { 3, 2, 1, 3 };
            Program p = new Program();
            int actual = p.birthdayCakeCandles(testList);
            int expected = 2;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            List<int> testList = new List<int> { 1, 3, 5, 7, 9, 9, 6, 4, 2, 2, 9, 9, 9, 8, 4 };
            Program p = new Program();
            int actual = p.birthdayCakeCandles(testList);
            int expected = 5;
            Assert.Equal(expected, actual);
        }
    }
}

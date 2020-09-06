using System;
using Xunit;
using MigratoryBirds;
using System.Collections.Generic;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int listLength = 6;
            List<int> testList = new List<int> { 1, 4, 4, 4, 5, 3 };
            int actual = MigratoryBirds.Program.migratoryBirds(testList);
            int expected = 4;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            int listLength = 11;
            List<int> testList = new List<int> { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 };
            int actual = MigratoryBirds.Program.migratoryBirds(testList);
            int expected = 3;
            Assert.Equal(expected, actual);
        }
    
    }
}

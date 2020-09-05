using System;
using Xunit;
using ElectronicsStore;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int testb = 10;
            int testn = 2;
            int testm = 3;
            int[] testKeyboards = new int[] { 3, 1 };
            int[] testDrives = new int[] { 5, 2, 8 };
            Program p = new Program();
            int actual = p.getMoneySpent(testKeyboards, testDrives, testb);
            int expected = 9;
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Test2()
        {
            int testb = 5;
            int testn = 1;
            int testm = 1;
            int[] testKeyboards = new int[] { 4 };
            int[] testDrives = new int[] { 5 };
            Program p = new Program();
            int actual = p.getMoneySpent(testKeyboards, testDrives, testb);
            int expected = -1;
            Assert.Equal(expected, actual);

        }
    }
}

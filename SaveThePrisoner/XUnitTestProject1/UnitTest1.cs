using System;
using Xunit;
using SaveThePrisoner;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int testn = 5;
            int testm = 2;
            int tests = 1;
            Program p = new Program();
            int actual = p.saveThePrisoner(testn, testm, tests);
            int expected = 2;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            int testn = 5;
            int testm = 2;
            int tests = 2;
            Program p = new Program();
            int actual = p.saveThePrisoner(testn, testm, tests);
            int expected = 3;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            int testn = 7;
            int testm = 19;
            int tests = 2;
            Program p = new Program();
            int actual = p.saveThePrisoner(testn, testm, tests);
            int expected = 6;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test4()
        {
            int testn = 3;
            int testm = 7;
            int tests = 3;
            Program p = new Program();
            int actual = p.saveThePrisoner(testn, testm, tests);
            int expected = 3;
            Assert.Equal(expected, actual);
        }

    }
}

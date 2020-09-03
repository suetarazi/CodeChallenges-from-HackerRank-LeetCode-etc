using System;
using Xunit;
using BonAppetit;
using System.Collections.Generic;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void OverchargedTest1()
        {
            List<int> testList = new List<int>() { 3, 10, 2, 9 };
            int testn = 4;
            int testk = 1;
            int testb = 12;
            Program p = new Program();
            string actual = p.bonAppetit(testList, testk, testb);
            string expected = "5";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CorrectSplitTest2()
        {
            List<int> testList = new List<int>() { 3, 10, 2, 9 };
            int testn = 4;
            int testk = 1;
            int testb = 7;
            Program p = new Program();
            string actual = p.bonAppetit(testList, testk, testb);
            string expected = "Bon Appetit";
            Assert.Equal(expected, actual);
        }
    }
}

using System;
using Xunit;
using CatsAndAMouse;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Program = CatsAndAMouse.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1a()
        {
            int testQueriesq = 2;
            int testx = 1;
            int testy = 2;
            int testz = 3;
            Program p = new Program();
            string actual = p.catAndMouse(testx, testy, testz);
            string expected = "Cat B";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test1b()
        {
            int testQueriesq = 2;
            int testx = 1;
            int testy = 3;
            int testz = 2;
            Program p = new Program();
            string actual = p.catAndMouse(testx, testy, testz);
            string expected = "Mouse C";
            Assert.Equal(expected, actual);
        }
    }
}

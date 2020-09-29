using System;
using Xunit;
using ViralAdvertising;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Program = ViralAdvertising.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int testInput = 3;
            int expected = 9;
            Program p = new Program();
            int actual = p.viralAdvertising(testInput);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            int testInput = 5;
            int expected = 24;
            Program p = new Program();
            int actual = p.viralAdvertising(testInput);
            Assert.Equal(expected, actual);
        }
    }
}

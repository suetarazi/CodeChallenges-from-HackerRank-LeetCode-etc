using System;
using Xunit;
using JumpingOnTheClouds;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Program = JumpingOnTheClouds.Program;
using Xunit.Sdk;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] testArr = new int[] { 0, 0, 1, 0, 0, 1, 0 };
            Program p = new Program();
            int actual = p.jumpingOnClouds(testArr);
            int expected = 4;
            Assert.Equal(expected, actual);
        }
    }
}

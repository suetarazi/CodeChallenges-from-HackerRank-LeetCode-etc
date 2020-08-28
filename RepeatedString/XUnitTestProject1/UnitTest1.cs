using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using Xunit;
using RepeatedString;
using Program = RepeatedString.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string testString = "aba";
            long n = 10;
            Program p = new Program();
            long actual = RepeatedString.Program.CountRepeatedString(testString, n);
            long expected = 7;
            Assert.Equal(expected, actual);
            
        }

        [Fact]
        public void ReallyLongNvalueTest()
        {
            string testString = "a";
            long n = 1000000000000;
            Program p = new Program();
            long actual = Program.CountRepeatedString(testString, n);
            long expected = 1000000000000;
            Assert.Equal(expected, actual);
        }
    }
}

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
                //(testString, n);
            long expected = 7;
            Assert.Equal(actual, expected);
            
        }
    }
}

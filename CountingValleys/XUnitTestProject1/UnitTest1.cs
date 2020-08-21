using System;
using Xunit;
using CountingValleys;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void JustOneValleyTest1()
        {
            int n = 8;
            string s = "UDDDUDUU";
            Program p = new Program();
            int actual = p.countingValleys(n, s);
            int expected = 1;
            Assert.Equal(expected, actual);
        }
    }
}

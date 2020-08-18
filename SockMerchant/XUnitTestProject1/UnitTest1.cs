using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using Xunit;
using SockMerchant;
using Program = SockMerchant.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int n = 9;
            int[] testArr = new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            Program p = new Program();
            int actual = p.FindMatchingPairsOfSocks(n, testArr);
            int expected = 3;
            Assert.Equal(expected, actual);
        }
    }
}

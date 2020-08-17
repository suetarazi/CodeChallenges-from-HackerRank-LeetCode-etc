using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using Xunit;
using SubstringBanana;
using Program = SubstringBanana.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void SubstringTest1()
        {
            string s = "banana";
            Program p = new Program();
            string actual = p.SubstringB(s);
            string expected = "na";
            Assert.Equal(expected, actual);
        }
    }
}

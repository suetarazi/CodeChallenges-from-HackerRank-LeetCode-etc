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
            string expected = "nana";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SubstringOneLetterTest()
        {
            string s = "l";
            Program p = new Program();
            string actual = p.SubstringB(s);
            string expected = "l";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SubstringEmptyTest()
        {
            string s = " ";
            Program p = new Program();
            string actual = p.SubstringB(s);
            string expected = " ";
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void SubstringLongTest()
        {
            string s = "AlyaZadeAveryMarco";
            Program p = new Program();
            string actual = p.SubstringB(s);
            string expected = "ZadeAveryMarco";
            Assert.Equal(expected, actual);
        }
    }
}

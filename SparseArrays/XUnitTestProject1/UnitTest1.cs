using System;
using Xunit;
using SparseArrays;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string[] testString = new string[] { "aba", "baba", "aba", "xzxb" };
            string[] testQueries = new string[] { "aba", "xzxb", "ab" };
            //Program p = new Program();
            int[] actual = Program.matchingStrings(testString, testQueries);
            int[] expected = new int[] { 2, 1, 0 };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            string[] testString = new string[] { "def", "de", "fgh" };
            string[] testQueries = new string[] { "de", "lmn", "fgh" };
            //Program p = new Program();
            int[] actual = Program.matchingStrings(testString, testQueries);
            int[] expected = new int[] { 1, 0, 1 };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            string[] testString = new string[] { "abcde", "sdaklfj", "asdjf", "na", "basdn", "sdaklfj", "asdjf", "na", "asdjf", "na", "basdn", "sdaklfj", "asdjf" };
            string[] testQueries = new string[] { "abcde", "sdaklfj", "asdjf", "na", "basdn" };
            //Program p = new Program();
            int[] actual = Program.matchingStrings(testString, testQueries);
            int[] expected = new int[] { 1, 3, 4, 3, 2 };
            Assert.Equal(expected, actual);


        }
    }
}

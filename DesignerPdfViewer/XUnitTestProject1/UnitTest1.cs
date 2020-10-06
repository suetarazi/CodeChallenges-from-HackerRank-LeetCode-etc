using System;
using Xunit;
using DesignerPdfViewer;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] inputArr = new int[] { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            string inputWord = "abc";
            Program p = new Program();
            int actual = p.designerPdfViewer(inputArr, inputWord);
            int expected = 9;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            int[] inputArr = new int[] { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7 };
            string inputWord = "zaba";
            Program p = new Program();
            int actual = p.designerPdfViewer(inputArr, inputWord);
            int expected = 28;
            Assert.Equal(expected, actual);
        }
    }
}

using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using Xunit;
using Array_Left_Rotation;
using Program = Array_Left_Rotation.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int testd = 4;
            int[] testInput = new int[] { 1, 2, 3, 4, 5 };
            Program p = new Program();
            int[] actual = p.LeftRotation(testInput, testd);
            int[] expected = new int[] { 5, 1, 2, 3, 4 };
            Assert.Equal(expected, actual);

        }
    }
}

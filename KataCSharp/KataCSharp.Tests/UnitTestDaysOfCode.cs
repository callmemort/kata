using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.Tests
{
    public class UnitTestDaysOfCode
    {
        

        [Theory]
        [InlineData(new int[]{0, 1, 2, 3 },new int[] { 3, 1, 2, 0 })]
        [InlineData(new int[] { 19, 46, 1, 7 }, new int[] { 7,46,1,19 })]
        [InlineData(new int[] { 1 }, new int[] {1 })]
        [InlineData(new int[] { 8, 6, 7, 9, 5 }, new int[] { 5, 6, 7, 9, 8 })]
        public void TestDay01SwapEnds(int[] nums, int[] expected)
        {
            int[] testResult = DaysOfCode.Day01SwapEnds(nums); //act
            Assert.Equal(expected, testResult); //assert
        }
    }
}

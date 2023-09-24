using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.Tests
{
    public class UnitTestDaysOfCode
    {

        //Day01
        [Theory]
        [InlineData(new int[] { 0, 1, 2, 3 }, new int[] { 3, 1, 2, 0 })]
        [InlineData(new int[] { 19, 46, 1, 7 }, new int[] { 7, 46, 1, 19 })]
        [InlineData(new int[] { 1 }, new int[] { 1 })]
        [InlineData(new int[] { 8, 6, 7, 9, 5 }, new int[] { 5, 6, 7, 9, 8 })]
        public void TestDay01SwapEnds(int[] nums, int[] expected)
        {
            int[] testResult = DaysOfCode.Day01SwapEnds(nums); //act
            Assert.Equal(expected, testResult); //assert
        }

        //Day02
        [Theory]
        [InlineData(new int[] { 3, 1, 2 }, true)]
        [InlineData(new int[] { 1, 3, 2 }, true)]
        [InlineData(new int[] { 1 }, false)]
        [InlineData(new int[] { 2, 1, 3, 4 }, false)]
        public void TestDay02Has12(int[] nums, bool expected)
        {
            bool testResult = DaysOfCode.Day02Has12(nums); //act
            Assert.Equal(expected, testResult); //assert
        }
        //Day03
        [Theory]
        [InlineData(1, 2, 3, 0)]
        [InlineData(1, 2, 2, 10)]
        [InlineData(3, 3, 3, 20)]
        [InlineData(1, 3, 1, 10)]
        [InlineData(2, 2, 3, 10)]
        public void TestDay03GreenTicket(int a, int b, int c, int expected)
        {
            int testResult = DaysOfCode.Day03GreenTicket(a, b, c); //act
            Assert.Equal(expected, testResult); //assert
        }
        //Day04
        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 1 }, 2)]
        [InlineData(new int[] { 2, 1, 1 }, new int[] { 1, 4 }, 1)]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 4 }, 1)]
        [InlineData(new int[0], new int[0], 0)]
        [InlineData(new int[] { 1, 4, 6, 7, 1, 1, 0, -5 }, new int[0] { }, 1)]
        public void TestDay04Start1(int[] a, int[] b, int expected)
        {
            int testResult = DaysOfCode.Day04Start1(a, b); //act
            Assert.Equal(expected, testResult); //assert
        }
        //Day05
        [Theory]
        [InlineData(2, 6, new int[] { 2, 3, 4, 5 })]
        [InlineData(11, 18, new int[] { 11, 12, 13, 14, 15, 16, 17 })]
        [InlineData(4, 4, new int[] { })]
        [InlineData(6, 7, new int[] { 6 })]
        [InlineData(-6, -2, new int[] { -6, -5, -4, -3 })]
        [InlineData(0, 0, new int[] { })]
        public void TestDay05FizzArray3(int start, int end, int[] expected)
        {
            int[] testResult = DaysOfCode.Day05FizzArray3(start, end);
            Assert.Equal(expected, testResult);
        }
        //Day06
        [Theory]
        [InlineData(new int[] { 1, 1, 4, 4 }, true)]
        [InlineData(new int[] { 1, 2, 3, 4 }, false)]
        [InlineData(new int[] { 1, 1 }, true)]
        [InlineData(new int[] { 0, 4, 1 }, false)]

        public void TestDay06Only14(int[] nums, bool expected)
        {
            bool testResult = DaysOfCode.Day06Only14(nums);
            Assert.Equal(expected, testResult);
        }
        //Day07
        [Theory]
        [InlineData(new int[] { 1, 1, 4, 4, 1, 4 }, true)]
        [InlineData(new int[] { 1, 2, 3, 3, 3, 4 }, false)]
        [InlineData(new int[] { 1, 1, 1, 23, 15, 75 }, false)]
        [InlineData(new int[] { 1, 1, 1, 2, 2, 2, 1 }, false)]
        [InlineData(new int[] { 3, 3, 3 }, false)]
        [InlineData(new int[] { 0, 0, -1 }, true)]

        public void TestDay07NoTuples(int[] nums, bool expected)
        {
            bool testResult = DaysOfCode.Day07NoTuples(nums);
            Assert.Equal(expected, testResult);
        }
        //Day08
        [Theory]
        [InlineData(new int[] { 2, 3 }, false)]
        [InlineData(new int[] { 4, 5 }, true)]
        [InlineData(new int[] { -2, -3, }, true)]
        [InlineData(new int[] { 2, 2, }, false)]
        public void TestDay08No23(int[] nums, bool expected)
        {
            bool testResult = DaysOfCode.Day08No23(nums);
            Assert.Equal(expected, testResult);
        }
        //Day09
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4 }, false)]
        [InlineData(new int[] { 2, 3, 5 }, true)]
        [InlineData(new int[] { }, true)]
        [InlineData(new int[] { 0, 2, 3, 5, 4 }, false)]
        public void TestDay09No14(int[] nums, bool expected)
        {
            bool testResult = DaysOfCode.Day09No14(nums);
            Assert.Equal(expected, testResult);
        }
        //Day10
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4 }, false)]
        [InlineData(new int[] { 1, 1, 3, 4 }, true)]
        [InlineData(new int[] { 1, 4, 4, 4 }, false)]
        [InlineData(new int[] { 2, 3, 5, 6, 7 }, false)]
        [InlineData(new int[] { 4, 4, 1, 1, 3, 0, 1 }, true)]
        public void TestDay10More14(int[] nums, bool expected)
        {
            bool testResult = DaysOfCode.Day10More14(nums);
            Assert.Equal(expected, testResult);
        }
        //Day11
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 2, 3 })]
        [InlineData(new int[] { 7, 1, 2, 3, 4, 9 }, new int[] { 2, 3 })]
        [InlineData(new int[] { 1, 2 }, new int[] { 1, 2 })]
        public void TestDay11MakeMiddle(int[] nums, int[] expected)
        {
            int[] testResult = DaysOfCode.Day11MakeMiddle(nums);
            Assert.Equal(expected, testResult);
        }
        //Day12
        [Theory]
        [InlineData(new int[] { 4, 5, 6 }, new int[] { 0, 0, 0, 0, 0, 6 })]
        [InlineData(new int[] { 1, 2 }, new int[] { 0, 0, 0, 2 })]
        [InlineData(new int[] { 3 }, new int[] { 0, 3 })]
        public void TestDay12MakeLast(int[] nums, int[] expected)
        {
            int[] testResult = DaysOfCode.Day12MakeLast(nums);
            Assert.Equal(expected, testResult);
        }
        //Day13
        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 3 })]
        [InlineData(new int[] { 7, 4, 6, 2 }, new int[] { 7, 2 })]
        [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 1, 4 })]
        public void TestDay13MakeEnds(int[] nums, int[] expected)
        {
            int[] testResult = DaysOfCode.Day13MakeEnds(nums);
            Assert.Equal(expected, testResult);
        }
        //Day15
        [Theory]
        [InlineData(new int[] { 1, 1 }, false)]
        [InlineData(new int[] { 1, 2 }, true)]
        [InlineData(new int[] { 2, 3 }, true)]
        [InlineData(new int[] { -2, -3 }, false)]
        [InlineData(new int[] { 1, 4, 5, 6, 0, 7, -3 }, false)]
        [InlineData(new int[] { 1, 4, 3, 6, 0, 7, -3 }, true)]
        public void TestDay15Has23(int[] nums, bool expected)
        {
            bool testResult = DaysOfCode.Day15Has23(nums);
            Assert.Equal(expected, testResult);
        }
        [Theory]
        [InlineData(1, new int[] { 0 })]
        [InlineData(4, new int[] { 0, 1, 2, 3 })]
        [InlineData(10, new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 })]

        //Day16
        public void TestDay16FizzArray(int n, int[] expected)
        {
            int[] testResult = DaysOfCode.Day16FizzArray(n);
            Assert.Equal(expected, testResult);
        }

        //Day17
        //    fix23([1, 2, 3]) → [1, 2, 0]
        //    fix23([2, 3, 5]) → [2, 0, 5]
        //    fix23([1, 2, 1]) → [1, 2, 1]
        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 0 })]
        [InlineData(new int[] { 2, 3, 5 }, new int[] { 2, 0, 5 })]
        [InlineData(new int[] { 1, 2, 1 }, new int[] { 1, 2, 1 })]

        public void TestDay17Fix23(int[] nums, int[] expected)
        {
            int[] testResult = DaysOfCode.Day17Fix23(nums);
            Assert.Equal(expected, testResult);
        }

        [Theory]
        [InlineData(2, 4, 6, true)]
        [InlineData(4, 2, 6, true)]
        [InlineData(4, 6, 3, false)]

        public void TestDay18EvenlySpaced(int a, int b, int c, bool expected)
        {
            bool testResult = DaysOfCode.Day18EvenlySpaced(a, b, c);
            Assert.Equal(expected, testResult);
        }
    }
}

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
        [InlineData(new int[]{0, 1, 2, 3 },new int[] { 3, 1, 2, 0 })]
        [InlineData(new int[] { 19, 46, 1, 7 }, new int[] { 7,46,1,19 })]
        [InlineData(new int[] { 1 }, new int[] {1 })]
        [InlineData(new int[] { 8, 6, 7, 9, 5 }, new int[] { 5, 6, 7, 9, 8 })]
        public void TestDay01SwapEnds(int[] nums, int[] expected)
        {
            int[] testResult = DaysOfCode.Day01SwapEnds(nums); //act
            Assert.Equal(expected, testResult); //assert
        }

        //Day02
        [Theory]
        [InlineData(new int[] { 3,1,2 }, true)]
        [InlineData(new int[] { 1, 3, 2 }, true)]
        [InlineData(new int[] { 1 }, false)]
        [InlineData(new int[] { 2,1,3,4 }, false)]
        public void TestDay02Has12(int[] nums, bool expected)
        {
            bool testResult = DaysOfCode.Day02Has12(nums); //act
            Assert.Equal(expected, testResult); //assert
        }
        //Day03
        [Theory]
        [InlineData(1,2,3,0)]
        [InlineData(1,2,2,10)]
        [InlineData(3,3,3,20)]
        [InlineData(1,3,1,10)]
        [InlineData(2, 2, 3, 10)]
        public void TestDay03GreenTicket(int a,int b,int c, int expected)
        {
            int testResult = DaysOfCode.Day03GreenTicket(a,b,c); //act
            Assert.Equal(expected, testResult); //assert
        }
        //Day04
        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 1 },2)]
        [InlineData(new int[] { 2, 1, 1 }, new int[] { 1, 4 }, 1)]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 4}, 1)]
        [InlineData(new int[0] , new int[0], 0)]
        [InlineData(new int[] { 1,4,6,7,1,1,0,-5 }, new int[0] {}, 1)]
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
        [InlineData(0,0,new int[] { })]
        public void TestDay05FizzArray3(int start, int end, int[] expected)
        {
            int[] testResult = DaysOfCode.Day05FizzArray3(start, end);
            Assert.Equal(expected, testResult);
        }
        //Day06
        [Theory]
        [InlineData(new int[] { 1, 1, 4, 4 }, true)]
        [InlineData( new int[] { 1,2,3,4 },false)]
        [InlineData(new int[] {1,1 },true)]
        [InlineData(new int[] { 0,4,1 }, false)]
        
        public void TestDay06Only14(int[] nums,bool expected)
        {
            bool testResult = DaysOfCode.Day06Only14(nums);
            Assert.Equal(expected, testResult);
        }
        //Day07
        [Theory]
        [InlineData(new int[] { 1, 1, 4, 4,1,4 }, true)]
        [InlineData(new int[] { 1, 2, 3,3,3,4 }, false)]
        [InlineData(new int[] { 1, 1,1,23,15,75 }, false)]
        [InlineData(new int[] { 1, 1, 1, 2, 2, 2, 1 }, false)]
        [InlineData(new int[] {3,3,3 }, false)]
        [InlineData(new int[] { 0, 0, -1 }, true)]

        public void TestDay07NoTuples(int[] nums, bool expected)
        {
            bool testResult = DaysOfCode.Day07NoTuples(nums);
            Assert.Equal(expected, testResult);
        }
    }
}

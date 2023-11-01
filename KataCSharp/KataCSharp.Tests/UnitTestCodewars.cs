using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using Xunit.Sdk;

namespace KataCSharp.Tests;

public class UnitTestCodewars
{

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4 }, 1, 10)]
    [InlineData(new int[] {}, 1, 0)]
    [InlineData(new int[] { 2, 2, 3, 3, 4, 4 }, 2,9 )]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 100, 5)]

    public void TestQueueTime(int[] customers, int n, long expected)
    {
        
        long testResult = CodeWars.QueueTime(customers, n);
        Assert.Equal(expected, testResult);
    }


    [Theory]
    [InlineData(new int[] { 6, 1, 4, 2, 0, 1, 9, 8, 7, 6 }, 1)]
    [InlineData(new int[] { 19, 5, 42, 2, 77 }, 7)]
    public void TestSumTwoSmallest(int[] input, int expected)
    {
        int testResult = CodeWars.sumTwoSmallestNumbers(input);
        Assert.Equal(expected, testResult);
    }


    [Theory]
    [InlineData("a ClAsH oF kiNGs", "A Clash Of Kings")]
    [InlineData("a ClAsH oF kiNGs", "A Clash of Kings", "of")]
    [InlineData("a ClAsH oF kiNGs", "A Clash of Kings", "of a")]
    //[InlineData("a ClAsH oF kiNGs", "A Clash Of Kings")]

    public void TestTitleCase(string text, string expected, string minors = "")
    {
        string testResult = CodeWars.TitleCase(text, minors);

        Assert.Equal(expected, testResult);
    }

    [Fact]
    public void TestExpandedForm()
    {
        string test1 = CodeWars.ExpandedForm(1205);
        Assert.Equal("1000 + 200 + 5", test1);
        string test2 = CodeWars.ExpandedForm(10201);
        Assert.Equal("10000 + 200 + 1", test2);
        string test3 = CodeWars.ExpandedForm(70304);
        Assert.Equal("70000 + 300 + 4", test3);

    }
    [Fact]
    public void TestCreatePhoneNumber()
    {
        Assert.Equal("(614) 201-9876", CodeWars.CreatePhoneNumber(new int[] { 6, 1, 4, 2, 0, 1, 9, 8, 7, 6 }));
        Assert.Equal("(212) 555-1234", CodeWars.CreatePhoneNumber(new int[] { 2, 1, 2, 5, 5, 5, 1, 2, 3, 4 }));
    }

    [Fact]
    public void TestTimeSolve()
    {
        Assert.Equal("23:59", CodeWars.TimeSolve(new String[] { "14:51" }));
        Assert.Equal("09:10", CodeWars.TimeSolve(new String[] { "21:14", "15:34", "14:51", "06:25", "15:30" }));
        Assert.Equal("11:40", CodeWars.TimeSolve(new String[] { "23:00", "04:22", "18:05", "06:24" }));
    }

    [Fact]
    public void TestCheckExam()
    {
        int testResult1 = CodeWars.CheckExam(new string[] { "a", "a", "b", "b" }, new string[] { "a", "c", "b", "d" });
        Assert.Equal(6, testResult1);
        int testResult2 = CodeWars.CheckExam(new string[] { "a", "a", "c", "b" }, new string[] { "a", "a", "b", "" });
        Assert.Equal(7, testResult2);
        int testResult3 = CodeWars.CheckExam(new string[] { "a", "a", "b", "c" }, new string[] { "a", "a", "b", "c" });
        Assert.Equal(16, testResult3);
        int testResult4 = CodeWars.CheckExam(new string[] { "b", "c", "b", "a" }, new string[] { "", "a", "a", "c" });
        Assert.Equal(0, testResult4);


    }

    [Theory]
    [InlineData(2, 2, 2, 2)]
    [InlineData(2, 6, 2, 12)]
    [InlineData(1, 5, 1, 15)]
    [InlineData(1, 5, 3, 5)]
    [InlineData(-5, 15, 5, 25)]

    public void TestSequenceSum(int start, int end, int step, int expected)
    {
        int testResult = CodeWars.SequenceSum(start, end, step);
        Assert.Equal(expected, testResult);
    }

    [Theory]
    [InlineData("123", "123", "July 9, 2015", "July 9, 2015", true)]
    [InlineData("123", "123", "July 9, 2015", "July 2, 2015", false)]
    [InlineData("124", "123", "July 9, 2015", "July 2, 2015", false)]
    [InlineData("1234", "123", "July 9, 2015", "July 2, 2015", false)]
    [InlineData("1", "1", "July 9, 2020", "July 9, 2020", true)]
    [InlineData("1", "1", "July 10, 2020", "July 9, 2020", false)]
    [InlineData("123", "123", "July 10, 2020", "July 9, 2021", true)]
    public void TestCheckCoupon(string enteredCode, string correctCode, string currentDate, string expirationDate, bool expected)
    {
        bool testResult = CodeWars.CheckCoupon(enteredCode, correctCode, currentDate, expirationDate); //act
        Assert.Equal(expected, testResult); //assert
    }

    [Theory]
    [InlineData(12, 3)]
    [InlineData(-12, 3)]
    [InlineData(0, 0)]
    [InlineData(123456, 21)]
    public void TestSumDigits(int input, int expected)
    {
        //arrange
        int testResult = CodeWars.SumDigits(input); //act
        Assert.Equal(expected, testResult); //assert
    }
    [Theory]
    [InlineData("This website is for losers LOL!", "Ths wbst s fr lsrs LL!")]
    [InlineData("What are you, a communist?", "Wht r y,  cmmnst?")]
    
    public void TestDisemvowel(string input, string expected)
    {
        string testResult = CodeWars.Disemvowel(input);
        Assert.Equal(expected, testResult);
    }
}
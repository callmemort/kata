using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace KataCSharp.Tests;

public class UnitTestCodewars
{
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

}
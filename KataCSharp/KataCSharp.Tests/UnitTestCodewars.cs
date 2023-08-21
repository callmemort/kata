using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace KataCSharp.Tests;

public class UnitTestCodewars
{

    [Theory]
    [InlineData("123", "123", "July 9, 2015", "July 9, 2015", true)]
    [InlineData("123", "123", "July 9, 2015", "July 2, 2015", false)]
    [InlineData("124", "123", "July 9, 2015", "July 2, 2015", false)]
    [InlineData("1234", "123", "July 9, 2015", "July 2, 2015", false)]
    [InlineData("1", "1", "July 9, 2020", "July 9, 2020", true)]
    [InlineData("1", "1", "July 10, 2020", "July 9, 2020", false)]
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
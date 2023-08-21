
using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;

namespace KataCSharp;

public class CodeWars
{
    public bool IsPrime(int candidate)
    {
        throw new NotImplementedException("Not implemented.");
    }


    /// <summary>
    /// https://www.codewars.com/kata/539de388a540db7fec000642/train/csharp
    /// The Coupon Code
    ///  verifies that a coupon code is valid and not expired. 
    ///  A coupon is no more valid on the day AFTER the expiration date.
    ///  All dates will be passed as strings in this format: "MONTH DATE, YEAR".
    /// </summary>
    /// <param name="enteredCode"></param>
    /// <param name="correctCode"></param>
    /// <param name="currentDate"></param>
    /// <param name="expirationDate"></param>
    /// <returns>Boolean</returns>
    public static bool CheckCoupon(string enteredCode, string correctCode, string currentDate, string expirationDate)
    {
        bool codesAreEqual = enteredCode.Equals(correctCode);
        DateTime expDateTime = Convert.ToDateTime(expirationDate);
        DateTime currDateTime = Convert.ToDateTime(currentDate);
        bool isNotExpired = false;
        if ((currDateTime.DayOfYear <= expDateTime.DayOfYear) && (currDateTime.Year <= expDateTime.Year))
        {
            isNotExpired = true;
        }
        if (codesAreEqual && isNotExpired)
        {
            return true;
        }
        else
        {

            return false;
        }
    }

    /// <summary>
    /// Takes a number as input and returns the sum of the absolute value of each of the number's decimal digits. 
    /// https://www.codewars.com/kata/52f3149496de55aded000410/train/csharp
    /// </summary>
    /// <param name="number"></param>
    /// <returns>Integer sum of absolute value of all digits</returns>
    public static int SumDigits(int number)
    {
        //convert to absolute value and string
        string numString = Math.Abs(number).ToString();

        int sum = 0;
        foreach (char c in numString)
        {
            sum += Convert.ToInt32(c.ToString()); //convert each digit and add to counter
        }

        return sum;
    }
}

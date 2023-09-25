

using Microsoft.CSharp;

using System.Diagnostics.Metrics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace KataCSharp;

public class CodeWars
{
    /// <summary>
    /// There is a queue for the self-checkout tills at the supermarket. 
    /// Your task is write a function to calculate the total time required for all the customers to check out!
    /// </summary>
    /// <param name="customers">customers: an array of positive integers representing the queue. Each integer represents a customer, and its value is the amount of time they require to check out.</param>
    /// <param name="n">n: a positive integer, the number of checkout tills.</param>
    /// <returns>The function should return an integer, the total time required.</returns>
    public static long QueueTime(int[] customers, int n)
    {
        if(customers.Length == 0)
        {
            return 0;
        }
        long timer = 0;
        int[] tills = new int[n];
        
        //init tills
        for (int i = 0; i < Math.Min(customers.Length, n); i++)
        {
            tills[i] = customers[i];
            customers[i] = 0;
        }
        bool keepGoing = true;
        while (keepGoing)
        {
            //iterate tills
            for (int i = 0; i < tills.Length; i++)
            {
                //countdown customer
                if (tills[i] > 0)
                {
                    Console.WriteLine($"till {i} is {tills[i]}, decrement...");
                    tills[i]--;
                }
                //if customer done, call next
                if (tills[i] == 0)
                {
                    Console.WriteLine($"till {i} is zero, calling next");
                    //call next customer
                    for (int j = 0; j < customers.Length; j++)
                    {
                        if (customers[j] > 0)
                        {
                            Console.WriteLine($"customer {j} greater than zero, adding to till {i}");
                            tills[i] = customers[j];
                            customers[j] = 0;
                            break;
                        }

                    }
                }
            }
            //increment timer
            timer++;
            Console.WriteLine( $"timer is now {timer}");
            //check if all customers complete

            if(tills.All(e => e == 0) && customers.All(e => e == 0))
            {
                keepGoing = false;
            }
          

           
        }
            return timer;
    }



    /// <summary>
    /// Complete the solution so that it returns true if the first argument(string) passed in ends with the 2nd argument (also a string). 
    /// solution('abc', 'bc') // returns true
    /// https://www.codewars.com/kata/51f2d1cafc9c0f745c00037d/solutions/csharp
    /// </summary>
    /// <param name="str"></param>
    /// <param name="ending"></param>
    /// <returns>Boolean</returns>

    public static bool Solution(string str, string ending)
    {
        bool result = false;
        result = str.EndsWith(ending);
        return result;
    }

    /// <summary>
    /// Create a function that returns the sum of the two lowest positive numbers given an array of minimum 4 positive integers. No floats or non-positive integers will be passed.
    /// https://www.codewars.com/kata/558fc85d8fd1938afb000014/solutions/csharp
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>

    public static int sumTwoSmallestNumbers(int[] numbers)
    {
        Array.Sort(numbers);

        int sum = numbers[0] + numbers[1];
        return sum;
    }
    /// <summary>
    /// Change a string to Title Case
    /// 
    /// </summary>
    /// <param name="text">Text to be changed to title case</param>
    /// <param name="minorWords">Optional minor words to keep lower case</param>
    /// <returns></returns>
    public static string TitleCase(string text, string minorWords = "")
    {
        string[] words = text.ToLower().Split(" ");
        string[] minors = minorWords is null ? new string[] { } :  minorWords.ToLower().Split(" ");

        for (int i = 0; i < words.Length; i++)
        {//words loop

            if (Array.IndexOf(minors, words[i]) < 0 || i == 0)
            {
                char[] thisWord = words[i].ToCharArray();

                for (int j = 0; j < thisWord.Length; j++)
                {//letters loop
                    if (j == 0)
                    {
                        thisWord[j] = Char.ToUpper(thisWord[j]);
                    }
                    else
                    {
                        thisWord[j] = Char.ToLower(thisWord[j]);

                    }

                }
                words[i] = new String(thisWord);
            }
            else { words[i] = words[i].ToLower(); }
        }
        string result = String.Join(" ", words);

        return result;
    }




    /// <summary>
    /// You will be given a number and you will need to return it as a string in Expanded Form. For example:
    /// (12); # Should return "10 + 2"
    /// (70304); # Should return "70000 + 300 + 4"
    /// </summary>
    /// <param name="num"></param>
    /// <returns>A string</returns>
    /// <exception cref="NotImplementedException"></exception>
    public static string ExpandedForm(long num)
    {
        string result = string.Empty;
        long current = num;
        List<long> resultSlices = new List<long>();
        while (current > 0)
        {
            long divisor = 1;
            while ((double)current / (divisor * 10) > 1)
            {
                divisor *= 10;
            }
            //do truncation division to get first digit, multiply by divisor
            long truncated = current / divisor;
            long resultSlice = truncated * divisor;
            current -= resultSlice;
            resultSlices.Add(resultSlice);
        }
        //build result string
        for (int i = 0; i < resultSlices.Count; i++)
        {
            if (i == resultSlices.Count - 1)
            {
                result += $"{resultSlices[i]}";
            }
            else
            {
                result += $"{resultSlices[i]} + ";
            }
        }

        return result;
    }

    /// <summary>
    /// Write a function that accepts an array of 10 integers (between 0 and 9), that returns a string of those numbers in the form of a phone number.
    /// => returns "(123) 456-7890"
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns>A string in format (###) ###-####</returns>
    public static string CreatePhoneNumber(int[] numbers)
    {
        string numStr = string.Empty;

        for (int i = 0; i < numbers.Length; i++)
        {
            numStr += numbers[i].ToString();
        }


        string result = $"({numStr.Substring(0, 3)}) {numStr.Substring(3, 3)}-{numStr.Substring(6, 4)}";
        return result;
    }


    /// <summary>
    /// https://www.codewars.com/kata/5b76a34ff71e5de9db0000f2/train/csharp
    /// In this Kata, you will be given a series of times at which an alarm sounds. 
    /// Your task will be to determine the maximum time interval between alarms. 
    /// Each alarm starts ringing at the beginning of the corresponding minute and rings for exactly one minute. 
    /// The times in the array are not in chronological order. 
    /// Ignore duplicate times, if any.
    /// 
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public static string TimeSolve(string[] arr)
    {

        List<int> times = new List<int>();
        foreach (string time in arr)
        {
            int hours = int.Parse(time.Substring(0, 2));
            int minutes = int.Parse(time.Substring(3, 2));
            minutes += hours * 60; //convert hh:mm str to minutes in 1440 minute day
            times.Add(minutes);
        }
        times.Sort();
        //first handle 24 hour wrap around interval
        int first = (1440 - times[times.Count - 1] + times[0] - 1);
        List<int> intervals = new List<int> { first };

        for (int i = times.Count - 1; i > 0; i--)
        {
            int interval;
            interval = times[i] - times[i - 1] - 1;  //subtract 1 minute for alarm ringing time
            intervals.Add(interval);
        }
        intervals.Sort();
        intervals.Reverse();
        int maxMinutes = intervals[0]; //get largest interval
        int resultHours = maxMinutes / 60;
        int resultMinutes = maxMinutes % 60;

        string result = $"{resultHours.ToString("D2")}:{resultMinutes.ToString("D2")}";
        return result;
    }



    public static int CheckExam(string[] arr1, string[] arr2)
    {
        int score = 0;
        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] == arr2[i])
            {
                score += 4;
            }
            else if (String.IsNullOrEmpty(arr2[i]))
            {
                score += 0;
            }
            else
            {
                score += -1;
            }

        }
        score = score < 0 ? 0 : score;
        return score;

    }


    /// <summary>
    /// Your task is to write a function which returns the sum of a sequence of integers.
    /// The sequence is defined by 3 non-negative values: begin, end, step.
    /// If begin value is greater than the end, your function should return 0. 
    /// If end is not the result of an integer number of steps, then don't add it to the sum. See the 4th example below.
    /// Examples
    /// 2,2,2 --> 2
    /// 2,6,2 --> 12 (2 + 4 + 6)
    /// 1,5,1 --> 15 (1 + 2 + 3 + 4 + 5)
    /// 1,5,3  --> 5 (1 + 4)
    /// </summary>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <param name="step"></param>
    /// <returns></returns>
    public static int SequenceSum(int start, int end, int step)
    {
        int sum = 0;
        for (int i = start; i <= end; i += step)
        {
            sum += i;
        }

        return sum;
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
        bool isNotExpired = currDateTime <= expDateTime ? true : false;

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

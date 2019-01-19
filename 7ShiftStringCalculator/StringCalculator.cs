using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7ShiftStringCalculator
{
    public class StringCalculator
    {
        public static int Add(string numbers)
        {
            string[] delimiters = { "," };

            //This will check if an input has a custom delimiter
            if (numbers.Substring(0, 2) == "//")
            {
                //Finds the custom delimiter portion
                string customDelimiter = numbers.Substring(2, numbers.IndexOf("\n") - 2);
                //Put the ',' separated delimiters into the string array
                delimiters = customDelimiter.Split(',');
                //Use the custom delimiters to separate the numbers part of the input
                numbers = numbers.Substring(numbers.IndexOf("\n"), numbers.Length - numbers.IndexOf("\n"));
            }

            int returnNum = 0;
            //This will separate the numbers portion of the input. The extra input into Split allows it to take in a string array.
            string[] numberList = numbers.Split(delimiters, System.StringSplitOptions.RemoveEmptyEntries);

            List<int> negativeNums = new List<int>();
            //Goes through each number 
            foreach (var number in numberList)
            {
                //Turns the string into an int
                int parsedNumber = int.Parse(number);
                //If the number is negative it will be added to a separate List
                if (parsedNumber < 0)
                {
                    negativeNums.Add(parsedNumber);
                    continue;
                }
                //If the number is less than or equal to 1000 it gets added to the final value
                returnNum += parsedNumber > 1000 ? 0 : parsedNumber;
            }

            //If there is a negative number(s), throw an Exception
            if (negativeNums.Count > 0)
            {
                string exceptionStr = "Negatives not allowed. Numbers ";
                foreach (var negative in negativeNums)
                {
                    exceptionStr += " " + exceptionStr;
                }
                throw new Exception(exceptionStr);
            }

            return returnNum;
        }
    }
}

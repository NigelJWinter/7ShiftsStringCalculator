using Microsoft.VisualStudio.TestTools.UnitTesting;
using _7ShiftStringCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7ShiftStringCalculator.Tests
{
    [TestClass()]
    public class StringCalculatorTests
    {
        [TestMethod()]
        public void CommaDelimitedAddTest()
        {
            //Test the basic case of having comma delimiters
            Assert.AreEqual(8, StringCalculator.Add("1,2,5"));
        }

        [TestMethod()]
        public void NewLineInputAddTest()
        {
            //Test adding '\n' characters into the string
            Assert.AreEqual(6, StringCalculator.Add("1\n,2,\n3"));
        }

        [TestMethod()]
        public void SetCustomDelimiterAddTest()
        {
            //Test adding a custom delimiter
            Assert.AreEqual(8, StringCalculator.Add("//;\n1;3;4"));
            Assert.AreEqual(6, StringCalculator.Add("//$\n1$2$3"));
            Assert.AreEqual(13, StringCalculator.Add("//@\n2@3@8"));

            //Test adding a multi character delimiter
            Assert.AreEqual(8, StringCalculator.Add("//@@@\n1@@@3@@@4"));
            //Test adding multiple delimiters
            Assert.AreEqual(8, StringCalculator.Add("//@@,!!!\n1!!!3@@4"));

        }

        [TestMethod()]
        public void MaxNumberAddTest()
        {
            //Test adding number that is over 1000
            Assert.AreEqual(8, StringCalculator.Add("//;\n1;3;4;1001"));
            //Test boundary case
            Assert.AreEqual(1008, StringCalculator.Add("//;\n1;3;4;1000"));
        }

        //Test that inputing negative values will thow an Exception
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AddNegativeNumbersTest()
        {
            StringCalculator.Add("-2,-3,-5");
        }
    }
}
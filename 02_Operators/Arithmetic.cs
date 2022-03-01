using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_Operators
{
    [TestClass]
    public class Arithmetic
    {
        [TestMethod]
        public void SimpleOperators()
        {
            int a = 22;
            int b = 15;

            //Addition
            int sum = a + b;

            //Subtracting
            int difference = a - b;

            //Multiplication
            int product = a * b;

            //Division
            int quotient = a / b; //With whole number it drops remainders/decimals

            //Remainder
            int remainder = a % b;

           /* DateTime today = DateTime.UtcNow;
            DateTime someDay = DateTime(1980, 02, 28);
            TimeSpan timeSpan = today - someDay; */
        }
    }
}

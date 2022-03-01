using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _02_Operators
{
    [TestClass]
    public class Comparisons
    {
        [TestMethod]
        public void Comparing()
        {
            int age = 25;
            string username = "Jacob";

            bool equals = age == 45;
            bool userIsAdam = username == "Adam";
            Console.WriteLine("User is 45: " + equals);
            Console.WriteLine($"User is Adam: {userIsAdam}");

            bool notEqual = age != 112;
            bool userIsNotJustin = username != "Justin";
            Console.WriteLine($"User is not 112: {notEqual}");
            Console.WriteLine("User is not Justin: " + userIsNotJustin);

            List<string> firstList = new List<string>();
            firstList.Add(username);

            List<string> secondList = new List<string>();
            secondList.Add(username);

            bool areSame = firstList == secondList;

            //More Comparisons
            bool greaterThan = age > 12;
            bool lessThan = age < 75;

            bool greaterThanOrEqual = age >= 66;
            bool lessThanOrEqual = age <= 23;


            bool trueValue = true;
            bool falseValue = false;

            //Using || for "or" statements, if either side true, then it will return true
            bool tOrT = trueValue || trueValue;
            bool tOrF = trueValue || falseValue;
            bool fOrT = falseValue || trueValue;
            bool fOrF = falseValue || falseValue;

            //Using && for "and" statements, both have to be true for a true statement to return
            bool tAndT = trueValue && trueValue;
            bool tAndF = trueValue && falseValue;
            bool fAndT = trueValue && falseValue;
            bool fAndF = falseValue && falseValue;
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ValueTypes
    {
        // Comments indicated by this Ctrl + K + C
        /* Longer comments indicated by this. ctrl + shift + / to make longer comments */

        //PascalCaseCapitalization
        //camelCaseCapitilization

        [TestMethod]
        public void Booleans()
        {
            //Declaring a variable
            bool declared;

            //Assigning a variable, becomes initilized
            declared = true;

            //Declare and initiliaze a variable
            bool declerationAndInitilized = false;

            //Assigning after declarition
            declerationAndInitilized = true;
        }

        [TestMethod]
        public void Characters()
        {
            //A single character
            char character = 'a';
            char symbol = '?';
            char number = '7';
            char space = ' ';
            char special = '\n';

        }

        [TestMethod]
        public void WholeNumbers()
        {
            //Types of numbers
            byte byteMin = 0;
            byte byteMax = 255;

            short shortMin = -32768;
            short shortMax = 32767;

            //Class will mainly use int
            int intMin = -2147483648;
            int intMax = 2147483647;

            long longMin = -9223372036854775808;
            long longMax = 9223372036854775807;

            int a = 15;
            int b = -10;
        }

        [TestMethod]
        public void Decimals()
        {
            //3 Types of Decimals, varying degrees of accuracy
            float floatExample = 1.120012f;
            //Float = 7 digits of precision, add F at the end to signify float
            double doubleExample = 12.1234655d;
            //Double = 15-16 digits of precision, d to signify double
            decimal decimalExample = -154.153241564132m; 
            //Decimal = 28-29 digits of precision, m to signify decimal
        }

        //enums must be declared outside test method, and use PascalType. Make it inside the class but outside the method
        enum PastryType { Cake, Cupcake, Eclaire, Petitfour, Corssant};

        [TestMethod]
        public void Enums()
        {
            PastryType myPastry = PastryType.Corssant;
                //Can also be done via using numbers to signify position in the enum
        }

        [TestMethod]
        public void Structs()
        {
            //can be pre-made, but can also be manipulated
            DateTime today = DateTime.Today;
            //When looking into periods at the end such as DateTime., purple is methods, and wrenches will perform tasks
            DateTime birthday = new DateTime(2003, 2, 20);
            //New will make a new example of items
        }
    }
}

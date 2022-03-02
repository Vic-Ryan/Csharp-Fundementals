using System;

namespace _05_Classes2
{
    public class Calculator
    {
        //Addiion
        public int Add(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
            //can also be typed as return numOne + numTwo
        }

        public double add(double numeOne, double numTwo)
        {
            double sum = numeOne + numTwo;
            return sum;
        }
        //Subtraction
        public int Subtract(int numOne, int numTwo)
        {
            int difference = numOne - numTwo;
            return difference;
        }
        public double Subtract(double numOne, double numTwo)
        {
            double difference = numOne - numTwo;
            return difference;
        }

        //Multiplication
        public int Multiply(int numOne, int numTwo)
        {
            int product = numOne * numTwo;
            return product;

        }
        public double Multiply(double numOne, double numTwo)
        {
            double product = numOne * numTwo;
            return product;
        }

        //Division
        public int Divide(int numOne, int numTwo)
        {
            int quotient = numOne / numTwo;
            return quotient;
            //If dividing, better to do doubles rather than ints to keep closer to the true answer
        }
        public double Divide(double numOne, double numTwo)
        {
            double quotient = numOne / numTwo;
            return quotient;
        }

        //Find the remainder
        public int Remainder(int numOne, int numTwo)
        {
            int remainder = numOne % numTwo;
            return remainder;
        }
        public double Remainder(double numOne, double numTwo)
        {
            double remainder = numOne % numTwo;
            return remainder;
        }

        public int CalculateAge(DateTime birthDate)
        {
            TimeSpan age = DateTime.Now - birthDate;
            double totalAgeInYears = age.TotalDays / 365.25;
            double rounded = Math.Floor(totalAgeInYears);
            int years = Convert.ToInt32(rounded);
            return years;
        }
    }
}

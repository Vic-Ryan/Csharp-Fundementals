using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes2
{
    [TestClass]
    public class MethodTests
    {
        [TestMethod]
        public void GreeterMethodExecute()
        {
            Greeter greeter = new Greeter();
            //Semantic satiation: words no longer are words


            greeter.SayHello("Victor");
            greeter.SayHello();
            greeter.SayHello(3);


            greeter.GetRandomGreeting();
            greeter.GetRandomGreeting();
            greeter.GetRandomGreeting();
            greeter.GetRandomGreeting();

            //have to go through this method to pull up randomgreeting, whereas can call directly in the greeter class
            Console.WriteLine(greeter.RandomGreeting());
        }

        [TestMethod]
        public void Calculator()
        {
            Calculator calculator = new Calculator();
            int sum = calculator.Add(8, 3);
            Console.WriteLine(sum);

            int quotient = calculator.Divide(12, 4);
            Console.WriteLine(quotient);

            //Only saved once to the line, and then lost. Good if you just need this one time, but if you need more better saved
            Console.WriteLine(calculator.Multiply(4, 3));

            int result = calculator.Divide(calculator.Multiply(sum, 6), quotient);
            Console.WriteLine(result);

            int age = calculator.CalculateAge(new DateTime(2003, 2, 20));
            Console.WriteLine(age);
        }

        [TestMethod]
        public void PersonProperty()
        {
            Person person = new Person("Victor", "Ryan", new DateTime(2003, 02, 20));
            Console.WriteLine($"My name is {person.FullName}, and I am {person.Age} years old.");
            person.Transport = new Vehicle("Chrysler", "300", 12000, VehicleType.Car);

            Person blankPerson = new Person();

            Assert.AreEqual("Victor R", person.FullName);
            Assert.AreEqual("Jacob", person.FirstName);
            person.SayHello();

            Person luke = new Person("Luke", "Skywalker", new DateTime(1970, 02, 02));
            luke.SayHello();

            person.Brag();
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Conditionals
{
    [TestClass]
    public class Switch
    {
        [TestMethod]
        public void SwitchCase()
        {
            int input = 1;

            switch (input)
            {
                case 1:
                    Console.WriteLine("Hello");
                    break;
                case 2:
                    Console.WriteLine("What's up");
                    break;
                default:
                    Console.WriteLine("This is the default, it will execute if no case matches the value");
                    break;

            }

            string name = "Jacob";
            switch(name)
            {
                case "Jacob":
                    Console.WriteLine("What's up cool guy?");
                    break;
                case "Hello":
                    Console.WriteLine("Hello!");
                    break;
                default:
                    Console.WriteLine("Hi?");
                    break;
            }    
        }
    }
}

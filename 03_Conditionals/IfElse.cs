using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Conditionals
{
    [TestClass]
    public class IfElse
    {
        [TestMethod]
        public void IfStatements()
        {
            bool userIsHungry = true;

            //If Keyword, place condition in ()
            if (userIsHungry)
            {
                //Section here is called a body
                Console.WriteLine("Eat something.");
            }

            string name = "Jacob";

            if (name == "Jacob")
            {
                Console.WriteLine("You must be so cool!");
            }

            if (name != "Jacob")
            {
                Console.WriteLine("You must not be very cool.");
            }
        }

        [TestMethod]
        public void IfElseStatements()
        {
            bool choresAreDone = false;

            if (choresAreDone)
            {
                Console.WriteLine("Have fun at the movies!");
            }
            else
            {
                Console.WriteLine("Stay home and do your chores");
            }

            string input = "7";
            int totalHours = int.Parse(input);

            if (totalHours >= 8)
            {
                Console.WriteLine("You should be well rested");
            }
            else
            {
                Console.WriteLine("You might be tired today");

                if (totalHours < 4)
                {
                    Console.WriteLine("You should get more sleep");
                }
            }
        }

        [TestMethod]
        public void IfElseIfStatements()
        {
            Random rng = new Random();
            //RNG Will not include the higher number
            int roll = rng.Next(1, 7);

            if (roll == 6)
            {
                Console.WriteLine("You rolled a six! Good job!");
            }
            else if (roll == 5)
            {
                Console.WriteLine("You rolled 5, not bad.");
            }
            else if (roll < 5 && roll > 3)
            {
                Console.WriteLine("You rolled a four, thats okay");
            }
            else if (roll == 3)
            {
                Console.WriteLine("THRREEEEEEEE");
            }
            else if (roll > 1)
            {
                Console.WriteLine("Toooooooo Wars?!");
            }
            else
            {
                Console.WriteLine("Uno.");
            }
        }
    }
}

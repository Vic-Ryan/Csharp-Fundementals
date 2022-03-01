using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ReferenceTypes
    {
        [TestMethod]
        public void String()
        {
            //Strings are collections of chars

            //Declarations
            string thisIsDeclared;

            //Initilized by assigning
            string declared;
            declared = "This is initilized";

            //Declare and Initlized
            string declaredAndInitilized = "This is both declaring and initilizing";

            //Numbers can be made into strings, but cannot be used as numbers
            string number = "7787";

            //Null is a complete absence, whereas empty may not have anything but still there
            string nullString;
            string emptyString = "";

            string firstName = "Victor";
            string lastName = "Ryan";

            //Concatenation, adds strings together to put them into 1, larger string
            string concatenetedFullName = firstName + " " + lastName;
            Console.WriteLine(concatenetedFullName);

            //Compositing, putting numerical values in order, then assigning strings to them after in the same order
            string compositeFullName = string.Format("{0} {1}", firstName, lastName);
            Console.WriteLine(compositeFullName);

            //Interpolation, calls string directly to make them write
            string interpolatedFullName = $"{firstName} {lastName}";
            Console.WriteLine(interpolatedFullName);
        }

        [TestMethod]
        public void Collections()
        {
            string stringExample = "This is a collection of chars";

            //Array is a collection of strings
            string[] stringArray = {"Hello","World","Why"};

            Console.WriteLine(stringArray[2]);

            //Updating a value by it's index, code read top to bottom so values will only change after update
            stringArray[0] = "Who";

            stringArray[2] = "Changed";

            //Lists
            //New setting aside memory for a new list
            //If error, ctrl + . or right click and open it up, will have to add using system.list
            //Used more often than arrays, can grow dynamically  by having items put in or removed
            List<string> ListOfStrings = new List<string>();
            List<int> listOfIntergers = new List<int>();

            ListOfStrings.Add("A string");
            listOfIntergers.Add(12900);

            //Queues will give the first item in, and remove it as it goes on, like a line
            Queue<string> firstInFirstOut = new Queue<string>();

            firstInFirstOut.Enqueue("I'm First");
            firstInFirstOut.Enqueue("I'm second");

            //Dictionary, a collection of key values and pairs
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();

            // Have to give it a key, 7, and a value, "Agent"
            keyAndValue.Add(7, "Agent");

            Dictionary<string, string> realDictionary = new Dictionary<string, string>();

            realDictionary.Add("Know", "Be aware of through observation, inquirry, or information");

            //Extra collection types, not as useful but good to know

            //Like a dictionary computer sorts on its own
            SortedList<int, string> sortedKeyAndValue = new SortedList<int, string>();

            //Unordered collection of unique elements, not used
            HashSet<int> uniqueList = new HashSet<int>();

            //Stack is like queue, although it starts from the most recent addition, much like stacking things onto eachother
            Stack<string> lastInFirstOut = new Stack<string>();

        }

        [TestMethod]
        public void Classes()
        {
            //Use new to make a 'new' instance of a class
            Random rng = new Random();

            int randomNumber = rng.Next();
            Console.WriteLine(randomNumber);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes2
{
    [TestClass]
    public class RoomTests
    {
        [TestMethod]
        public void SettingValues()
        {
            Room room = new Room(16, 35, 15);

            double squareFeet = room.SquareFoot();
            Console.WriteLine(squareFeet);

            double lateralArea = room.LateralArea();
            Console.WriteLine(lateralArea);
            //Assert.AreEqual(lateralArea, 2 * (15 * (16 + 35)));
            //Assert.AreEqual(lateralArea, 2 * (room.Height * (room.Length + room.Width)));
        }

        //Unit Test Naming: Functionality_Goal
        //Checking Constructor Is Setting Values
        [TestMethod]
        public void ConstructRoom_ShouldSetProperties()
        {
            Room room = new Room(8, 8, 10);

            Assert.AreEqual(8, room.Length);
            Assert.AreEqual(10, room.Height);
            Assert.AreEqual(8, room.Width);
        }
        //Checking Square Footage Output
        [TestMethod]
        public void CheckSquareFootage_ShouldReturnCorrectDouble()
        {
            Room room = new Room(10, 7, 10);

            double expected = 70; // 10 * 7
            double actual = room.SquareFoot();

            Assert.AreEqual(expected, actual);

        }
        //Checking lateral area output
        [TestMethod]
        public void CheckLateralSurfaceArea_ShouldReturnCorrectDouble()
        {
            Room room = new Room(10, 7, 10);
            Assert.AreEqual(340, room.LateralArea());
        }
        //Checking invalid lengths
        [TestMethod]
        [DataRow(4, 5, 10)] //Check minimum length failure
        [DataRow(40, 39, 25)] //Check maximum length failure
        public void CreatingInvalidLength_ShouldThrowException(double length, double width, double height)
        {
            Exception thrownException = null;
            try
            {
                //attempt this
                Room room = new Room(length, width, height);
            }
            //Grab the exception
            catch(Exception err)
            {
                thrownException = err;
                //Run this code
            }
            Assert.IsNotNull(thrownException);
            Assert.IsInstanceOfType(thrownException, typeof(ArgumentException));
        }
        //Checking invalid widths
        [TestMethod]
        [DataRow(6, 4, 10)] //Check minimum width failure
        [DataRow(29, 50, 25)] //Check maximum width failure
        public void CreatingInvalidWidth_ShouldThrowException(double length, double width, double height)
        {
            Exception thrownException = null;
            try
            {
                //attempt this
                Room room = new Room(length, width, height);
            }
            //Grab the exception
            catch (Exception err)
            {
                thrownException = err;
                //Run this code
            }
            finally //Will always run in a try scenario, regardless of an excpection thrown or not
            {
                Console.WriteLine("I cannot be stopped!");
                Assert.IsNotNull(thrownException);
                Assert.IsInstanceOfType(thrownException, typeof(ArgumentException));
            }
            Console.WriteLine("I can be.");
        }
        //Checking invalid heights
        [TestMethod]
        [DataRow(6, 5, 9)] //Check minimum height failure
        [DataRow(29, 39, 30)] //Check maximum height failure
        [ExpectedException(typeof(ArgumentException))] //Expecting an exception and this test to fail, so it passes!
        public void CreatingInvalidHeight_ShouldThrowException(double length, double width, double height)
        {
                Room room = new Room(length, width, height); //Simplest form of catching exceptions

        }
    }
}


using _06_StreamingConten_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_StreamingContent_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void SetTitle_ShouldGetCorrectString()
        {
            //Arrange
            StreamingContent content = new StreamingContent(); 

            //Act
            content.Title = "Toy Story";
            string expected = "Toy Story";
            string actual = content.Title;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(MaturityRating.G, true)]
        [DataRow(MaturityRating.TV_PG, true)]
        [DataRow(MaturityRating.R, false)]
        [DataRow(MaturityRating.TV_MA, false)]
        public void SetMaturityRating_ShouldGetCorrectFamilyFriendliness(MaturityRating rating, bool expectedFamilyFriendly)
        {
            //Triple A paradigm, a short hand for test setup

            //Arrange => Set the stage for the test
            StreamingContent content = new StreamingContent("Some Title", "Some Description", 5, rating, GenreType.Horror);

            //Act => Executing any code
            bool actual = content.IsFamilyFriendly;
            bool expected = expectedFamilyFriendly;

            //Assert => Call your assertions
            Assert.AreEqual(expected, actual);
        }
    }
}

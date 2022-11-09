using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mandatory_assignment_1;
using System.ComponentModel.DataAnnotations;

namespace Mandatory_assignment_1_Tests
{
    [TestClass]
    public class TestFootballPlayer
    {

        [ClassInitialize]
        public static void Setup(TestContext context)
        {

        }

        private FootballPlayer footballPlayerNoFail = new FootballPlayer(1, "Johan H. Rauer", 23, 99);
        private FootballPlayer footballPlayerIdFail = new FootballPlayer(-1, "Johan H. Rauer", 23, 99);
        private FootballPlayer footballPlayerShirtFailHigh = new FootballPlayer(2, "Johan H. Rauer", 23, 999);
        private FootballPlayer footballPlayerShirtFailLow = new FootballPlayer(3, "Johan H. Rauer", 23, 0);
        private FootballPlayer footballPlayerAgeFail = new FootballPlayer(4, "Johan H. Rauer", 0, 99);
        private FootballPlayer footballPlayerNameFail = new FootballPlayer(5, "J", 23, 99);


        [TestMethod()]
        public void ToStringTest()
        {
            // Act
            string str = footballPlayerNoFail.ToString();

            // Assert
            Assert.AreEqual("1 Johan H. Rauer 23 99", str);  
        }

        [TestMethod]
        public void StandardPropertyTest()
        {
            try
            {
                // Act
                footballPlayerNoFail.Validate();
            }
            catch (Exception ex)
            {
                // Assert
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        public void ValidateIdTest()
        {
            // Assert
            Assert.ThrowsException<IllegalIdException>(() => footballPlayerIdFail.ValidateId());
        }

        [TestMethod]
        public void ValidateNameTest()
        {
            // Assert
            Assert.ThrowsException<IllegalNameException>(() => footballPlayerNameFail.ValidateName());
        }

        [TestMethod]
        public void ValidateAgeTest()
        {
            // Assert
            Assert.ThrowsException<IllegalAgeException>(() => footballPlayerAgeFail.ValidateAge());
        }

        [TestMethod]
        public void ValidateShirtNumberHighTest()
        {
            // Assert
            Assert.ThrowsException<IllegalShirtNumberException>(() => footballPlayerShirtFailHigh.ValidateShirtNumber());
        }

        [TestMethod]
        public void ValidateShirtNumberLowTest()
        {
            // Assert
            Assert.ThrowsException<IllegalShirtNumberException>(() => footballPlayerShirtFailLow.ValidateShirtNumber());
        }
    }
}
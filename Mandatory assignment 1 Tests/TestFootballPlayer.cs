using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mandatory_assignment_1;
using System.ComponentModel.DataAnnotations;

namespace Mandatory_assignment_1_Tests
{
    [TestClass]
    public class TestFootballPlayer
    {

        //[ClassInitialize]
        //public static void Setup(TestContext context)
        //{

        //}

        //[ClassCleanup]
        //public static void TearDown()
        //{

        //}

        [TestMethod]
        public void FootballPlayerPropTest()
        {
            // Arrange
            var footballPlayerNoFail = new FootballPlayer(1, "Johan H. Rauer", 23, 99);
            var footballPlayerShirtFailHigh = new FootballPlayer(2, "Johan H. Rauer", 23, 999);
            var footballPlayerShirtFailLow = new FootballPlayer(3, "Johan H. Rauer", 23, 0);
            var footballPlayerAgeFail = new FootballPlayer(4, "Johan H. Rauer", 0, 99);
            var footballPlayerNameFail = new FootballPlayer(5, "J", 23, 99);

            // Act
            var validationResults = new List<ValidationResult>();
            var footballPlayerNoFailActual = Validator.TryValidateObject(footballPlayerNoFail, new ValidationContext(footballPlayerNoFail), validationResults, true);
            var footballPlayerShirtFailHighActual = Validator.TryValidateObject(footballPlayerShirtFailHigh, new ValidationContext(footballPlayerShirtFailHigh), validationResults, true);
            var footballPlayerShirtFailLowActual = Validator.TryValidateObject(footballPlayerShirtFailLow, new ValidationContext(footballPlayerShirtFailLow), validationResults, true);
            var footballPlayerAgeFailActual = Validator.TryValidateObject(footballPlayerAgeFail, new ValidationContext(footballPlayerAgeFail), validationResults, true);
            var footballPlayerNameFailActual = Validator.TryValidateObject(footballPlayerNameFail, new ValidationContext(footballPlayerNameFail), validationResults, true);

            // Assert
            Assert.IsTrue(footballPlayerNoFailActual, "Error: No Fail validation failed");
            Assert.IsFalse(footballPlayerShirtFailHighActual, "Error: ShirtNumber Validation does not work");
            Assert.IsFalse(footballPlayerShirtFailLowActual, "Error: ShirtNumber Validation does not work");
            Assert.IsFalse(footballPlayerAgeFailActual, "Error: Age Validation does not work");
            Assert.IsFalse(footballPlayerNameFailActual, "Error: Name Validation does not work");

        }
    }
}
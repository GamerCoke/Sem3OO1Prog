using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bridge;
using System.Diagnostics.CodeAnalysis;

namespace OOp1ProgTest
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public sealed class CarClassTest
    {
        [TestMethod]
        public void PriceTest()
        {
            // Arrange
            Car c = new Car();
            double expectedOutcome = 230;

            // Act
            double actualOutcome = c.Price();

            // Assert
            Assert.AreEqual(expectedOutcome, actualOutcome);
        }

        [TestMethod]
        public void BroBizzTest()
        {
            // Arrange
            Car c = new Car();
            c.BroBizz = true;
            double expectedOutcome = 230 * 0.9;

            // Act
            double ActualOutcome = c.Price();

            // Assert
            Assert.AreEqual(expectedOutcome, ActualOutcome);
        }

        [TestMethod]
        public void VehicleTypeTest()
        {
            // Arrange
            Car c = new Car();
            string expectedType = "Car";

            // Act
            string actualType = c.VehicleType();

            // Assert
            Assert.AreEqual(expectedType, actualType);
        }

        [TestMethod]
        public void LicenseExceptionTest()
        {
            // Arrange
            Car c = new Car();

            // Act & Assert
            Assert.ThrowsException<ArgumentException>( () => { c.Licenseplate = "01234567"; } );
        }

        [TestMethod]
        public void LicenseTest()
        {
            // Arrange
            Car c = new Car();
            string expectedOutcome = "0123456";

            // Act
            c.Licenseplate = expectedOutcome;

            // Assert
            Assert.AreEqual(c.Licenseplate, expectedOutcome);
        }

        [TestMethod]
        public void NullLicenseTest()
        {
            // Arrange
            Car c = new Car();

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => { c.Licenseplate = null; });
        }
    }

    [ExcludeFromCodeCoverage]
    [TestClass]
    public sealed class MCClassTest
    {
        [TestMethod]
        public void PriceTest()
        {
            // Arrange
            MC m = new MC();
            double expectedPrice = 120;

            // Act
            double actualPrice = m.Price();

            // Assert
            Assert.AreEqual(expectedPrice, actualPrice);
        }

        [TestMethod]
        public void BroBizzTest()
        {
            // Arrange
            MC m = new MC();
            m.BroBizz = true;
            double expectedOutcome = 120 * 0.9;

            // Act
            double ActualOutcome = m.Price();

            // Assert
            Assert.AreEqual(expectedOutcome, ActualOutcome);
        }

        [TestMethod]
        public void VehicleTypeTest()
        {
            // Arrange
            MC m = new MC();
            string expectedType = "MC";

            // Act
            string actualType = m.VehicleType();

            // Assert
            Assert.AreEqual(expectedType, actualType);
        }

        [TestMethod]
        public void LicenseExceptionTest()
        {
            // Arrange
            MC m = new MC();

            // Act & Assert
            Assert.ThrowsException<ArgumentException>( () => { m.Licenseplate = "01234567";  } );
        }

        [TestMethod]
        public void LicenseTest()
        {
            // Arrange
            MC m = new MC();
            string expectedOutcome = "0123456";

            // Act
            m.Licenseplate = expectedOutcome;

            // Assert
            Assert.AreEqual(m.Licenseplate, expectedOutcome);
        }

        [TestMethod]
        public void NullLicenseTest()
        {
            // Arrange
            MC m = new MC();

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => { m.Licenseplate = null; });
        }
    }
}

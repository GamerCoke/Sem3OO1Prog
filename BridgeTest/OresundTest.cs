using System.Diagnostics.CodeAnalysis;
using OresundbronLibrary;

namespace OOp1ProgTest;
[ExcludeFromCodeCoverage]
[TestClass]
public class OresundCarTest
{
    [TestMethod]
    public void PriceTest()
    {
        // Arrange
        OresundCar c = new OresundCar();
        double expectedResult = 460;

        // Act
        double actualResult = c.Price();

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    // test

    [TestMethod]
    public void BroBizzTest()
    {
        // Arrange 
        OresundCar c = new OresundCar();
        c.BroBizz = true;
        double expectedResult = 178;

        // Act
        double actualResult = c.Price();

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void VehicleTypeTest()
    {
        // Arrange
        OresundCar c = new OresundCar();
        string expectedResult = "Oresund Car";

        // Act
        string actualResult = c.VehicleType();

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}

[ExcludeFromCodeCoverage]
[TestClass]
public class OresundMCTest
{
    [TestMethod]
    public void PriceTest()
    {
        // Arrange
        OresundMC m = new OresundMC();
        double expectedResult = 235;

        // Act
        double actualResult = m.Price();

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void BroBizzTest()
    {
        // Arrange
        OresundMC m = new OresundMC();
        m.BroBizz = true;
        double expectedResult = 92;

        // Act
        double actualResult = m.Price();

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void VehicleTypeTest()
    {
        // Arrange
        OresundMC m = new OresundMC();
        string expectedResult = "Oresund MC";

        // Act
        string actualResult = m.VehicleType();

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}

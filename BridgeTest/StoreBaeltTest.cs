using System.Diagnostics.CodeAnalysis;
using Bridge;
using StoreBaeltTicketLibrary;

namespace OOp1ProgTest;

[ExcludeFromCodeCoverage]
[TestClass]
public class StoreBaeltTest
{
    [TestMethod]
    public void PriceTest()
    {
        // Arrange
        StoreBaeltCar c = new StoreBaeltCar();

        double expectedOutcome = 230;

        // Act
        double ActualOutcome = c.Price();

        // Assert
        Assert.AreEqual(expectedOutcome, ActualOutcome);
    }

    [TestMethod]
    public void BroBizzPriceTest()
    {
        // Arrange
        StoreBaeltCar c = new StoreBaeltCar();
        c.BroBizz = true;
        double expectedOutcome = 207;

        // Act
        double ActualOutcome = c.Price();

        // Assert
        Assert.AreEqual(expectedOutcome, ActualOutcome);
    }

    [TestMethod]
    public void WeekendPriceTest()
    {
        // Arrange
        StoreBaeltCar c = new StoreBaeltCar();
        c.Weekend = true;
        double expectedOutcome = 195.5;

        // Act
        double actualOutcome = c.Price();

        // Assert
        Assert.AreEqual(expectedOutcome, actualOutcome);
    }

    [TestMethod]
    public void WeekendBroBizzPriceTest()
    {
        // Arrange
        StoreBaeltCar c = new StoreBaeltCar();
        c.Weekend = true;
        c.BroBizz = true;
        double expectedOutcome = 175.95;

        // Act
        double ActualOutcome = c.Price();

        // Assert
        Assert.AreEqual(expectedOutcome, ActualOutcome, 0.001);
    }
}

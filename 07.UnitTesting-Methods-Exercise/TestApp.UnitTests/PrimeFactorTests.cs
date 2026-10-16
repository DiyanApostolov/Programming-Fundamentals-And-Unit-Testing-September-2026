using NUnit.Framework;
using System.IO;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        // Arrange
        long input = 11;
        long expected = 11;

        // Act
        long result = PrimeFactor.FindLargestPrimeFactor(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        // Arrange
        long input = 826354;
        long expected = 149;

        // Act
        long result = PrimeFactor.FindLargestPrimeFactor(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

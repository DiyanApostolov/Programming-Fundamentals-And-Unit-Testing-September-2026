using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class NumberProcessorTests
{
    [Test]
    public void Test_ProcessNumbers_SquareEvenNumbers()
    {
        // Arrange
        List<int> input = new() { 2, 4, 6 };
        List<double> expected = new() { 4, 16, 36 };

        // Act
        List<double> actual = NumberProcessor.ProcessNumbers(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual); // OLD SYNTAX

        Assert.That(actual, Is.EqualTo(expected)); // NEW SYNTAX
    }

    // TODO: finish test
    [Test]
    public void Test_ProcessNumbers_SquareRootOddNumbers()
    {
        // Arrange
        List<int> numbers = new List<int>() { 9, 49, 23 };
        List<double> expected = new List<double>() { 3, 7, 4.795 };

        // Act
        List<double> result = NumberProcessor.ProcessNumbers(numbers);

        // Assert
        for (int i = 0; i < result.Count; i++)
        {
            Assert.That(result[i], Is.EqualTo(expected[i]).Within(0.001));
        }
    }

    // TODO: finish test
    [Test]
    public void Test_ProcessNumbers_HandleZero()
    {
        // Arrange
        List<int> input = new() { 0 };
        List<int> expected = new() { 0 };

        // Act
        List<double> result = NumberProcessor.ProcessNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ProcessNumbers_EmptyInput()
    {
        // Arrange
        List<int> input = new List<int>();

        // Act
        List<double> result = NumberProcessor.ProcessNumbers(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // BONUS TEST
    [Test]
    public void Test_ProcessNumbers_EvenAndOddsNumbers()
    {
        // Arrange
        List<int> input = new() { 2, 49, 6, 21 };
        List<double> expected = new() { 4, 7, 36, 4.582 };

        // Act
        List<double> result = NumberProcessor.ProcessNumbers(input);

        // Assert
        for (int i = 0; i < result.Count; i++)
        {
            Assert.That(result[i], Is.EqualTo(expected[i]).Within(0.001));
        }
    }
}

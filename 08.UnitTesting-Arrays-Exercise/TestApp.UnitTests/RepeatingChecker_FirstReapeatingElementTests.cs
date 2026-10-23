using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class RepeatingChecker_FirstReapeatingElementTests
{
    [Test]
    public void Test_FindFirstRepeatingElement_EmptyArray_ReturnsNegativeOne()
    {
        // Arrange
        int[] numbers = Array.Empty<int>();
        int expected = -1;

        // Act
        int result = RepeatingChecker.FindFirstRepeatingElement(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithOneInteger_ReturnsNegativeOne()
    {
        // Arrange
        int[] numbers = new int[] { 7 };
        int expected = -1;

        // Act
        int result = RepeatingChecker.FindFirstRepeatingElement(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithManyNonRepeatingValues_ReturnsNegativeOne()
    {
        // Arrange
        int[] numbers = new int[] { 7, -5, 10, 106, 33, 20 };
        int expected = -1;

        // Act
        int result = RepeatingChecker.FindFirstRepeatingElement(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithTwoReapeatingNegativeOneValue_ReturnsNegativeOne()
    {
        // Arrange
        int[] numbers = new int[] { -1, -1 };
        int expected = -1;

        // Act
        int result = RepeatingChecker.FindFirstRepeatingElement(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithManyIntegerWithSameValues_ReturnsTheIntegerValue()
    {
        // Arrange
        int[] numbers = new int[] { 7, 7, 7, 7, 7, 7, 7, 7 };
        int expected = 7;

        // Act
        int result = RepeatingChecker.FindFirstRepeatingElement(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithAtLeastTwoReaptingValues_ReturnsTheRepeatingValue()
    {
        // Arrange
        int[] numbers = new int[] { 10, 34, 6, 7, 10, 0, 100, 150, 7 };
        int expected = 10;

        // Act
        int result = RepeatingChecker.FindFirstRepeatingElement(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

using System;
using System.Collections.Generic;
using System.Reflection;
using NUnit.Framework;

namespace TestApp.Tests;

public class NumberFinderTests
{
    [Test]
    public void Test_FindSmallestPositive_ShouldReturnError_WhenListIsNull()
    {
        // Arrange
        List<int> numbers = null;
        string expectedMessage = "List cannot be empty.";

        // Act
        string result = NumberFinder.FindSmallestPositive(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expectedMessage));
    }

    [Test]
    public void Test_FindSmallestPositive_ShouldReturnError_WhenListIsEmpty()
    {
        // Arrange
        List<int> numbers = new List<int>();
        string expectedMessage = "List cannot be empty.";

        // Act
        string result = NumberFinder.FindSmallestPositive(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expectedMessage));
    }

    [Test]
    public void Test_FindSmallestPositive_ShouldReturnSmallest_WhenListHasPositiveNumbers()
    {
        // Arrange
        List<int> numbers = new List<int>() { 7, 39, 22, 4, 105, 70};
        string expectedMessage = "Smallest positive number is: 4";

        // Act
        string result = NumberFinder.FindSmallestPositive(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expectedMessage));
    }

    [Test]
    public void Test_FindSmallestPositive_ShouldReturnSmallest_WhenListHasMixedNumbers()
    {
        // Arrange
        List<int> numbers = new List<int>() { -7, 39, -22, -4, 105, 70 };
        string expectedMessage = "Smallest positive number is: 39";

        // Act
        string result = NumberFinder.FindSmallestPositive(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expectedMessage));
    }

    [Test]
    public void Test_FindSmallestPositive_ShouldReturnNotFoundMessage_WhenAllNumbersAreNegativeOrZero()
    {
        // Arrange
        List<int> numbers = new List<int>() { -7, -39, -22, -4, 0, -70 };
        string expectedMessage = "No positive numbers found.";

        // Act
        string result = NumberFinder.FindSmallestPositive(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expectedMessage));
    }

    [Test]
    public void Test_FindSmallestPositive_ShouldHandleDuplicates_Correctly()
    {
        // Arrange
        List<int> numbers = new List<int>() { 7, 39, 22, 4, 105, 70, 4, 22 };
        string expectedMessage = "Smallest positive number is: 4";

        // Act
        string result = NumberFinder.FindSmallestPositive(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expectedMessage));
    }
}

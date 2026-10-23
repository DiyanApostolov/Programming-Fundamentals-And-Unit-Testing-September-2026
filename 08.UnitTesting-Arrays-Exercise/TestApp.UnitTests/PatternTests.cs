using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        // Arrange
        int[] input = new int[] { 42, 2, 7, 105, 34, 50, 2, 11, 4, 105 }; // 2, 4, 7, 11, 34, 42, 50, 105
        int[] expected = new int[] { 2, 105, 4, 50, 7, 42, 11, 34 };

        // Act
        int[] result = Pattern.SortInPattern(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] emptyArray = new int[0];

        // Act
        int[] result = Pattern.SortInPattern(emptyArray);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        // Arrange
        int[] input = new int[] { 42 };

        // Act
        int[] result = Pattern.SortInPattern(input);

        // Assert
        Assert.That(result, Is.EqualTo(input));
    }
}

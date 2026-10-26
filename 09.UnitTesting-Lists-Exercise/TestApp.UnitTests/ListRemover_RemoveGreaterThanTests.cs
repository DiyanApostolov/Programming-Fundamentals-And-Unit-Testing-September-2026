using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListRemover_RemoveGreaterThanTests
{
    [Test]
    public void Test_RemoveElementsGreaterThan_EmptyListParameter_ReturnsEmtyList()
    {
        // Arrange
        List<int> numbers = new List<int>(); // empty list
        int threshold = 5;

        // Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(numbers, threshold);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithGreaterThanThresholdElements_ReturnsEmtyList()
    {
        // Arrange
        List<int> numbers = new List<int>() { 6, 10, 15, 200, 77}; 
        int threshold = 5;

        // Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(numbers, threshold);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithLessThanOrEqualToThresholdElements_ReturnsSameList()
    {
        // Arrange
        List<int> numbers = new List<int>() { 6, 10, 15, 100, 77 };
        int threshold = 100;

        // Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(numbers, threshold);

        // Assert
        Assert.That(result, Is.EqualTo(numbers));
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithLessThanEqualAndGreaterThanThresholdElements_ReturnsOnlyLessThanOrEqualToThreshold()
    {
        // Arrange
        List<int> numbers = new List<int>() { 6, 10, 50, 100, 77, 42};
        int threshold = 50;
        List<int> exected = new List<int>() { 6, 10, 50, 42 };

        // Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(numbers, threshold);

        // Assert
        Assert.That(result, Is.EqualTo(exected));
    }

    // BONUS TEST
    [Test]
    public void Test_RemoveElementsGreaterThan_NegativeNumbers_ReturnsOnlyLessThanOrEqualToThreshold()
    {
        // Arrange
        List<int> numbers = new List<int>() { -6, -10, 50, -100, -77, 42 };
        int threshold = -50;
        List<int> exected = new List<int>() { -100, -77 };

        // Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(numbers, threshold);

        // Assert
        Assert.That(result, Is.EqualTo(exected));
    }
}

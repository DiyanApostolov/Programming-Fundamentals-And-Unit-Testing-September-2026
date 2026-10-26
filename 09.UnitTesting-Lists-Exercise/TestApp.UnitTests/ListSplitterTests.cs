using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListSplitterTests
{
    [Test]
    public void Test_SplitEvenAndOdd_EmptyListParameter_ReturnsEmptyEvenAndOddLists()
    {
        // Arrange
        List<int> numbers = new List<int>(); // empty list

        // Act
        (List<int> evens, List<int> odds) result = ListSplitter.SplitEvenAndOdd(numbers);

        // Assert
        Assert.That(result.evens, Is.Empty);
        Assert.That(result.odds, Is.Empty);
    }

    [Test]
    public void Test_SplitEvenAndOdd_OnlyEvenValues_ReturnsEmptyOddList()
    {
        // Arrange
        List<int> numbers = new List<int>() { 2, 4, 6 }; 

        // Act
        (List<int> evens, List<int> odds) result = ListSplitter.SplitEvenAndOdd(numbers);

        // Assert
        Assert.That(result.evens, Is.EqualTo(numbers));
        Assert.That(result.odds, Is.Empty);
    }

    [Test]
    public void Test_SplitEvenAndOdd_OnlyOddValues_ReturnsEmptyEvenList()
    {
        // Arrange
        List<int> numbers = new List<int>() { 1, 3, 5 };

        // Act
        (List<int> evens, List<int> odds) result = ListSplitter.SplitEvenAndOdd(numbers);

        // Assert
        Assert.That(result.evens, Is.Empty);
        Assert.That(result.odds, Is.EqualTo(numbers));
    }

    [Test]
    public void Test_SplitEvenAndOdd_EvenAndOddValues_ReturnsListWithCorrectValues()
    {
        // Arrange
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
        List<int> expectedEvens = new List<int>() { 2, 4, 6 };
        List<int> expectedOdds = new List<int>() { 1, 3, 5 };

        // Act
        (List<int> evens, List<int> odds) result = ListSplitter.SplitEvenAndOdd(numbers);

        // Assert
        Assert.That(result.evens, Is.EqualTo(expectedEvens));
        Assert.That(result.odds, Is.EqualTo(expectedOdds));
    }
}

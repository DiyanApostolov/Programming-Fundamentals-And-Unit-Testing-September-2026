using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverserTests
{
    [Test]
    public void Test_ReverseStrings_WithEmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        string[] inputArray = Array.Empty<string>();

        // Act
        string[] result = Reverser.ReverseStrings(inputArray);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_ReverseStrings_WithSingleString_ReturnsReversedString()
    {
        // Arrange
        string[] input = new string[] { "Hello" };
        string[] expected = new string[] { "olleH" };

        // Act
        string[] result = Reverser.ReverseStrings(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseStrings_WithMultipleStrings_ReturnsReversedStrings()
    {
        // Arrange
        string[] input = new string[] { "Hello", "Dido", "Honda" };
        string[] expected = new string[] { "olleH", "odiD", "adnoH" };

        // Act
        string[] result = Reverser.ReverseStrings(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseStrings_WithSpecialCharacters_ReturnsReversedSpecialCharacters()
    {
        // Arrange
        string[] input = new string[] { "Hello#", "$%-", "12*!" };
        string[] expected = new string[] { "#olleH", "-%$", "!*21" };

        // Act
        string[] result = Reverser.ReverseStrings(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

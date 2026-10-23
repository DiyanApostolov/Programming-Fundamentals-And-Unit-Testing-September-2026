using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        // Arrange
        char[] chars = new char[] { '0', '1', 'a', 'z', '9', '#' };
        char[] expected = new char[] { 'a', 'z', '#' };

        // Act
        char[] result = Fake.RemoveStringNumbers(chars);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        // Arrange
        char[] chars = new char[] { 'a', 'z', 'D', '#' };

        // Act
        char[] result = Fake.RemoveStringNumbers(chars);

        // Assert
        Assert.That(result, Is.EqualTo(chars));
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        char[] emptyArray = Array.Empty<char>();

        // Act
        char[] result = Fake.RemoveStringNumbers(emptyArray);

        // Assert - OLD SYNTAX
        Assert.IsEmpty(result);
    }

    // BONUS TEST - NOT FOR JUDGE
    [Test]
    public void Test_RemoveStringNumbers_ArrayOnlyWithNumbers_ReturnsEmptyArray()
    {
        // Arrange
        char[] emptyArray = new char[] { '4', '7', '1', '9' };

        // Act
        char[] result = Fake.RemoveStringNumbers(emptyArray);

        // Assert - OLD SYNTAX
        Assert.IsEmpty(result);
    }
}

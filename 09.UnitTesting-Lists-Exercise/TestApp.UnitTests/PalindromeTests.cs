using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> words = new List<string>() { "refer", "civic", "ABBA" };

        // Act
        bool result = Palindrome.IsPalindrome(words);

        // Assert
        Assert.That(result, Is.True);
    }

    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> words = new List<string>();

        // Act
        bool result = Palindrome.IsPalindrome(words);

        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        // Arrange
        List<string> words = new List<string>() { "refer" };

        // Act
        bool result = Palindrome.IsPalindrome(words);

        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        // Arrange
        List<string> words = new List<string>() { "refer", "civic", "dido" };

        // Act
        bool result = Palindrome.IsPalindrome(words);

        // Assert
        Assert.That(result, Is.False);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> words = new List<string>() { "Refer", "CivIC", "kAYak", "lEVeL" };

        // Act
        bool result = Palindrome.IsPalindrome(words);

        // Assert
        Assert.That(result, Is.True);
    }
}

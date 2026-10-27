using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.Tests;

public class TextCensorTests
{
    [Test]
    public void CensorWord_ShouldReturnError_WhenSentenceIsNull()
    {
        // Arrange
        string sentence = null;
        string wordToCensor = "word";
        string expected = "Sentence cannot be empty.";

        // Act
        string result = TextCensor.CensorWord(sentence, wordToCensor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void CensorWord_ShouldReturnError_WhenSentenceIsWhitespace()
    {
        // Arrange
        string sentence = " ";
        string wordToCensor = "word";
        string expected = "Sentence cannot be empty.";

        // Act
        string result = TextCensor.CensorWord(sentence, wordToCensor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void CensorWord_ShouldReturnError_WhenWordIsNull()
    {
        // Arrange
        string sentence = "This is a bad word";
        string wordToCensor = null;
        string expected = "Word to censor cannot be empty.";

        // Act
        string result = TextCensor.CensorWord(sentence, wordToCensor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void CensorWord_ShouldReturnError_WhenWordIsWhitespace()
    {
        // Arrange
        string sentence = "This is a bad word";
        string wordToCensor = " ";
        string expected = "Word to censor cannot be empty.";

        // Act
        string result = TextCensor.CensorWord(sentence, wordToCensor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void CensorWord_ShouldReplaceSingleOccurrence()
    {
        // Arrange
        string sentence = "This is a bad word";
        string wordToCensor = "bad";
        string expected = "This is a *** word";

        // Act
        string result = TextCensor.CensorWord(sentence, wordToCensor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void CensorWord_ShouldReplaceMultipleOccurrences()
    {
        // Arrange
        string sentence = "This is a bad sentence with many bad words.";
        string wordToCensor = "bad";
        string expected = "This is a *** sentence with many *** words.";

        // Act
        string result = TextCensor.CensorWord(sentence, wordToCensor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void CensorWord_ShouldReturnOriginal_WhenWordNotFound()
    {
        // Arrange
        string sentence = "This is a bad sentence with many bad words.";
        string wordToCensor = "invalid";       

        // Act
        string result = TextCensor.CensorWord(sentence, wordToCensor);

        // Assert
        Assert.That(result, Is.EqualTo(sentence));
    }

    [Test]
    public void CensorWord_ShouldReplaceCaseInsensitive()
    {
        // Arrange
        string sentence = "This is a bad sentence with many BAD words.";
        string wordToCensor = "Bad";
        string expected = "This is a *** sentence with many *** words.";

        // Act
        string result = TextCensor.CensorWord(sentence, wordToCensor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}


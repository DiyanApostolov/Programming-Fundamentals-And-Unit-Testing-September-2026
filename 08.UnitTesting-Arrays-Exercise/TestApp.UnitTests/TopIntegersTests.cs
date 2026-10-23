using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class TopIntegersTests
{
    private TopIntegers topIntegers;

    [SetUp]
    public void SetUp()
    {
        topIntegers = new TopIntegers();
    }

    [Test]
    public void Test_FindTopIntegers_EmptyArrayParameter_ReturnEmptyString()
    {
        // Arrange
        int[] numbers = Array.Empty<int>();

        // Act
        string result = topIntegers.FindTopIntegers(numbers);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindTopIntegers_AllElementsAreTopIntegers_ReturnStringWithAllElements()
    {
        // Arrange
        int[] numbers = new int[] { 4, 3, 2 };
        string expected = "4 3 2";

        // Act
        string result = topIntegers.FindTopIntegers(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindTopIntegers_OnlyOneElementArray_ReturnStringWithOneInteger()
    {
        // Arrange
        int[] numbers = new int[] { 42 };
        string expected = "42";

        // Act
        string result = topIntegers.FindTopIntegers(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindTopIntegers_OnlySomeElementsAreTopIntegers_ReturnStringWithOnlyTopIntegers()
    {
        // Arrange
        int[] numbers = new int[] { 14, 24, 3, 19, 15, 17 };
        string expected = "24 19 17";

        // Act
        string result = topIntegers.FindTopIntegers(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // BONUS TEST - NOT FOR JUDGE
    [Test]
    public void Test_FindTopIntegers_ArrayWithSameNUmbers_ReturnStringWithOneInteger()
    {
        // Arrange
        int[] numbers = new int[] { 42, 42, 42, 42, 42, 42 };
        string expected = "42";

        // Act
        string result = topIntegers.FindTopIntegers(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}


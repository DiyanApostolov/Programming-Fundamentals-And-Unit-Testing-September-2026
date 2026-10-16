using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NUnit.Framework.Constraints.Tolerance;

namespace TestApp.UnitTests;

public class PalindromeIntegersTests
{
    private PalindromeIntegers pi; // declare variable2

    [SetUp]
    public void SetUp()
    {
        pi = new PalindromeIntegers(); // new instantion of class PalindromeIntegers
    }

    [Test]
    public void Test_FindPalindromes_EmptyList_ReturnsEmptyList()
    {
        // Arrange
        List<int> emptyList = new List<int>();

        // Act
        List<int> result = pi.FindPalindromes(emptyList); // call method from instantion

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindPalindromes_NoPalindromes_ReturnsEmptyList()
    {
        // Arrange
        List<int> numbers = new List<int>() { 123, 504, 23, 1400 };

        // Act
        List<int> result = pi.FindPalindromes(numbers);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindPalindromes_OnlySingleDigitsElements_ReturnsSameIntegersList()
    {
        // Arrange
        List<int> numbers = new List<int>() { 1, 5, 3, 7 };

        // Act
        List<int> result = pi.FindPalindromes(numbers);

        // Assert - NEW SYNTAX
        Assert.That(result, Is.EqualTo(numbers));

        // Assert - OLD SYNTAX
        CollectionAssert.AreEqual(numbers, result);
    }

    [Test]
    public void Test_FindPalindromes_AllElementsArePalindromes_ReturnsSameIntegersList()
    {
        // Arrange
        List<int> numbers = new List<int>() { 101, 555, 3223, 77 };

        // Act
        List<int> result = pi.FindPalindromes(numbers);

        // Assert - NEW SYNTAX
        Assert.That(result, Is.EqualTo(numbers));
    }

    [Test]
    public void Test_FindPalindromes_PalimdromesAndNoPalindromesIntegers_ReturnsOnlyPalindromes()
    {
        // Arrange
        List<int> numbers = new List<int>() { 105, 555, 30223, 707, 2435, 1001 };
        List<int> expected = new List<int>() { 555, 707, 1001 };

        // Act
        List<int> result = pi.FindPalindromes(numbers);

        // Assert - NEW SYNTAX
        Assert.That(result, Is.EqualTo(expected));
    }
}

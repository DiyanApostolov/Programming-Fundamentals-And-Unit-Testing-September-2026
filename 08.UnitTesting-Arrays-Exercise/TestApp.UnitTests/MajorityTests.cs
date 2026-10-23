using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class MajorityTests
{
    [Test]
    public void Test_IsEvenOrOddMajority_EmpryArray_ReturnsZero()
    {
        // Arrange
        int[] numbers = Array.Empty<int>();
        int expected = 0;

        // Act
        int result = Majority.IsEvenOrOddMajority(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_ArrayOnlyWithZeros_ReturnsZero()
    {
        // Arrange
        int[] numbers = new int[] { 0, 0, 0, 0, 0, 0 };
        int expected = 0;

        // Act
        int result = Majority.IsEvenOrOddMajority(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_EqualOddAndEvenNumbers_ReturnsZero()
    {
        // Arrange
        int[] numbers = new int[] { 2, 13, 7, 80, 14, 21 };
        int expected = 0;

        // Act
        int result = Majority.IsEvenOrOddMajority(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_EvenMajority_ReturnsPositiveNumber()
    {
        // Arrange
        int[] numbers = { 2, 13, 7, 20, 32, 100 };

        // Act
        int result = Majority.IsEvenOrOddMajority(numbers);

        // Assert
        Assert.That(result, Is.GreaterThan(0));

        Assert.Greater(result, 0); // OLD SYNTAX
    }

    [Test]
    public void Test_IsEvenOrOddMajority_OddMajority_ReturnsNegativeNumber()
    {
        // Arrange
        int[] numbers = { 2, 13, 7, 21, 32, 107 };

        // Act
        int result = Majority.IsEvenOrOddMajority(numbers);

        // Assert
        Assert.That(result, Is.LessThan(0));

        Assert.Less(result, 0); // OLD SYNTAX
    }
}

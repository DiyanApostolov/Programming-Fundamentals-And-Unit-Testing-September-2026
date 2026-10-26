using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class SameValuesTests
{
    [Test]
    public void Test_FindSameValues_EmptyFirstList_ReturnsEmptyList()
    {
        // Arrange
        List<int> firstList = new List<int>(); // Empty list
        List<int> secondList = new List<int>() { 1, 2, 3 }; 

        // Act
        List<int> result = SameValues.FindSameValues(firstList, secondList);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindSameValues_EmptySecondList_ReturnsEmptyList()
    {
        // Arrange
        List<int> firstList = new List<int>() { 1, 2, 3 }; 
        List<int> secondList = new List<int>(); // Empty list

        // Act
        List<int> result = SameValues.FindSameValues(firstList, secondList);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindSameValues_NoSameValuesInBothLists_ReturnsEmptyList()
    {
        // Arrange
        List<int> firstList = new List<int>() { 1, 2, 3 };
        List<int> secondList = new List<int>() { 4, 5, 6 }; 

        // Act
        List<int> result = SameValues.FindSameValues(firstList, secondList);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindSameValues_BothListWithSameValues_ReturnsListWithSameValues()
    {
        // Arrange
        List<int> firstList = new List<int>() { 1, 2, 3, 1, 3, 7, 12, 5, 9, 7  };
        List<int> secondList = new List<int>() { 4, 5, 60, 3, 12, 7 };
        List<int> expected = new List<int>() { 3, 5, 7, 12 }; // sorted list

        // Act
        List<int> result = SameValues.FindSameValues(firstList, secondList);

        // Assert
        Assert.That(result, Is.EquivalentTo(expected)); // EquivalentTo - check values without index
    }
}

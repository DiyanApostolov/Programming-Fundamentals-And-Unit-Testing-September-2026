using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class AverageGradeTests
{
    [Test]
    public void Test_GetGradeDefinition_AverageGradeUnderTwo_ReturnsErrorMessage()
    {
        //Arrange
        List<double> grades = new List<double>() { 2, 1, 2.5 };
        string expectedMessage = "Incorrect grades";

        // Act
        string result = AverageGrade.GetGradeDefinition(grades);

        //Assert
        Assert.That(result, Is.EqualTo(expectedMessage));
    }

    [Test]
    public void Test_GetGradeDefinition_AverageGradeOverSix_ReturnsErrorMessage()
    {
        //Arrange
        List<double> grades = new List<double>() { 6 , 5.50, 7};
        string expectedMessage = "Incorrect grades";

        // Act
        string result = AverageGrade.GetGradeDefinition(grades);

        //Assert
        Assert.That(result, Is.EqualTo(expectedMessage));
    }

    [Test]
    public void Test_GetGradeDefinition_FailScoreAverageGrade_ReturnsFailDefinitionMessage()
    {
        //Arrange
        List<double> grades = new List<double>() { 2, 2.50, 2.80 };
        string expectedMessage = "Fail";

        // Act
        string result = AverageGrade.GetGradeDefinition(grades);

        //Assert
        Assert.That(result, Is.EqualTo(expectedMessage));
    }

    [Test]
    public void Test_GetGradeDefinition_PoorScoreAverageGrade_ReturnsPoorDefinitionMessage()
    {
        //Arrange
        List<double> grades = new List<double>() { 3, 3.50, 3.20 };
        string expectedMessage = "Poor";

        // Act
        string result = AverageGrade.GetGradeDefinition(grades);

        //Assert
        Assert.That(result, Is.EqualTo(expectedMessage));
    }

    [Test]
    public void Test_GetGradeDefinition_GoodScoreAverageGrade_ReturnsGoodDefinitionMessage()
    {
        //Arrange
        List<double> grades = new List<double>() { 4, 3.50, 4.20 };
        string expectedMessage = "Good";

        // Act
        string result = AverageGrade.GetGradeDefinition(grades);

        //Assert
        Assert.That(result, Is.EqualTo(expectedMessage));
    }

    [Test]
    public void Test_GetGradeDefinition_VeryGoodScoreAverageGrade_ReturnsVeryGoodDefinitionMessage()
    {
        //Arrange
        List<double> grades = new List<double>() { 4.80, 5.50, 5.20 };
        string expectedMessage = "Very good";

        // Act
        string result = AverageGrade.GetGradeDefinition(grades);

        //Assert
        Assert.That(result, Is.EqualTo(expectedMessage));
    }

    [Test]
    public void Test_GetGradeDefinition_ExcellentScoreAverageGrade_ReturnsExcellentDefinitionMessage()
    {
        //Arrange
        List<double> grades = new List<double>() { 5.80, 5.50, 6 };
        string expectedMessage = "Excellent";

        // Act
        string result = AverageGrade.GetGradeDefinition(grades);

        //Assert
        Assert.That(result, Is.EqualTo(expectedMessage));
    }
}

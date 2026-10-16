using NUnit.Framework;
using NUnit.Framework.Internal;

namespace TestApp.UnitTests;

public class EmailTests
{
    // TODO: finish test
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string validEmail = "test@example.com";   

        // Act
        bool result = Email.IsValidEmail(validEmail);

        // Assert - OLD SYNTAX
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsValidEmail_InvalidEmail()
    {
        // Arange
        string invalidEmail = "@example.com";

        // Act
        bool result = Email.IsValidEmail(invalidEmail);

        // Assert - NEW SYNTAX
        Assert.That(result, Is.False);
    }

    [Test]
    public void Test_IsValidEmail_NullInput()
    {
        // Arange
        string nullEmail = null;

        // Act
        bool result = Email.IsValidEmail(nullEmail);

        // Assert - NEW SYNTAX
        Assert.That(result, Is.False);
    }
}

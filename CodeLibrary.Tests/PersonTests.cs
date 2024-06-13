using FluentAssertions;

namespace CodeLibrary.Tests;

public class PersonTests
{
    [Fact]
    public void Person_WhenNewed_DoesNotError()
    {
        // Arrange
        var age = 0;

        // Act
        var act = () => new Person(age);

        // Assert
        act.Should().NotThrow();
    }
}
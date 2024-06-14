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

    [Fact]
    public void CanVote_WhenYoung_ReturnsFalse()
    {
        // Arrange
        var age = 5;

        // Act
        var sut = new Person(age);

        // Assert
        sut.CanVote.Should().BeFalse();
    }


    [Fact]
    public void CanVote_MinimumAcceptedAge_ReturnsTrue()
    {
        // Arrange
        var age = 18;

        // Act
        var sut = new Person(age);

        // Assert
        sut.CanVote.Should().BeTrue();
    }
}
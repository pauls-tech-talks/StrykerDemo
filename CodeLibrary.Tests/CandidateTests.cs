using FluentAssertions;

namespace CodeLibrary.Tests;

public class CandidateTests
{
    [Fact]
    public void Constructor_WhenCalled_DoesNotError()
    {
        // Arrange
        var age = 18;

        // Act
        var act = () => new Candidate(age);

        // Assert
        act.Should().NotThrow();
    }

    [Fact]
    public void CanVote_WhenYoung_ReturnsFalse()
    {
        // Arrange
        var age = 5;

        // Act
        var sut = new Candidate(age);

        // Assert
        sut.CanVote.Should().BeFalse();
    }
}
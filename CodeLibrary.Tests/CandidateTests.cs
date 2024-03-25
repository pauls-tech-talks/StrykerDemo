using FluentAssertions;

namespace CodeLibrary.Tests;

public class CandidateTests
{
    [Fact]
    public void Candidate_WhenNewed_DoesNotError()
    {
        // Arrange
        var age = 18;

        // Act
        var act = () => new Candidate(age);

        // Assert
        act.Should().NotThrow();
    }
}
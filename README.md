# StrykerDemo
Demonstrates some of the capabilities and value of Stryker Mutator tool

## Quickstart Commands
Here are some commands to get started:
``` bash
# Restore tools
dotnet tool restore

# Run coverage
gci **/TestResults/ | ri -r; dotnet test -c Release --collect "XPlat Code Coverage"; dotnet reportgenerator -targetdir:coveragereport -reports:**/coverage.cobertura.xml -reporttypes:"html"; start coveragereport/index.html;

# Run mutations
dotnet stryker -o;
```

## Intro
This tool is about getting the most out of unit testing.

Imagine the scenario: `All your tests pass`.
Wow that's great! But this isn't enough. We need to know whether we've covered all threads of execution..

Enter: `Test coverage tools`.
These tell us that all lines of code (include logical branches) have been hit during unit tests.
Again, this is fab... But is *this* enough? No! It's a good start, but it cant give us the full picture.

Turns out there's two big problems with using test coverage (alone):
- It can be falsely gained  
- It does nothing to measure the actual tests

### Example Code
Here is some example code. It is highly over-simplified for legibility.
``` csharp
public class Person
{
    public Person(int age)
    {
        CanVote = IsOldEnoughToVote(age);
        Console.WriteLine("can vote?, {0}", CanVote);
    }

    public bool CanVote { get; }

    public static bool IsOldEnoughToVote(int age)
    {
        return age > 81;
    }
}
```

### Generic Test
``` csharp
[Fact]
public void Person_WhenNewed_DoesNotError()
{
    // Arrange
    var age = 54;

    // Act
    var act = () => new Person(age);

    // Assert
    act.Should().NotThrow();
}
```

### Misleading Analysis
It is clear in the above example that we are lacking decent tests, which would really help.
This is a trivial example - in bigger codebases these are much more likely to slip by unnoticed.
With our basic tools, we are getting the thumbs-up:

:heavy_check_mark: All tests pass
:heavy_check_mark: 100% test coverage

But there's clearly issues with the tests AND the code. So what gives!!

:interrobang: Test Quality???

### Stryker to the Rescue!
Stryker (as with any mutation testing tool) meddles with your source code and looks for at least one test to **fail** as a result.
For example, Stryker flips logical operators, so `valueA > valueB` is mutated to `valueA >= valueB` by Stryker and then requires a test to fail.

Clearly the above lack of test coverage is now exposed by the tool!
Additionally, the specific mutations force us to zoom into specific logic, and find hidden bugs!
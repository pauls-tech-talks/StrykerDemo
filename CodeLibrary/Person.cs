namespace CodeLibrary;

public class Person
{
    public Person(int age)
    {
        CanVote = IsOldEnoughToVote(age);
    }

    public bool CanVote { get; }

    public static bool IsOldEnoughToVote(int age)
    {
        return age > 18;
    }
}

namespace CodeLibrary;

public class Candidate
{
    public Candidate(int age)
    {
        CanVote = IsOldEnoughToVote(age);
    }

    public bool CanVote { get; }

    public static bool IsOldEnoughToVote(int age)
    {
        return age > 81;
    }
}

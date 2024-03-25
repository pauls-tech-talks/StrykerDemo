namespace CodeLibrary;

public class Candidate
{
    public Candidate(int age)
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

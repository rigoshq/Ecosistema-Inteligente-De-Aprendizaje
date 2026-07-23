namespace EIA.Core.Intelligence;

public class SelfReflection
{
    public Guid Id { get; }

    public DateTime CreatedAt { get; }

    public string Question { get; }

    public string Answer { get; }

    public SelfReflection(
        string question,
        string answer)
    {
        Id = Guid.NewGuid();

        CreatedAt = DateTime.UtcNow;

        Question = question;

        Answer = answer;
    }
}
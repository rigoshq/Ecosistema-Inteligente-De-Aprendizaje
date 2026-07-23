namespace EIA.Core.Intelligence;

public class Talent
{
    public string Name { get; }

    public double Score { get; }

    public string Description { get; }

    public Talent(
        string name,
        double score,
        string description)
    {
        Name = name;

        Score = score;

        Description = description;
    }
}
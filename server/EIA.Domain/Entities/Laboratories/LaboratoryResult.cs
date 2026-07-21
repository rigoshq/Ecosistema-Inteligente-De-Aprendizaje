namespace EIA.Domain.Entities.Laboratories;

public class LaboratoryResult
{
    public bool Approved { get; private set; }

    public double Score { get; private set; }

    public string Feedback { get; private set; }

    public LaboratoryResult(
        bool approved,
        double score,
        string feedback)
    {
        Approved = approved;

        Score = score;

        Feedback = feedback;
    }
}
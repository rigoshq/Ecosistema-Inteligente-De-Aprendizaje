namespace EIA.Domain.Entities.LearningExperiences;

public class LearningFeedback
{
    public string Message { get; private set; }

    public double Score { get; private set; }

    public LearningFeedback(
        string message,
        double score)
    {
        Message = message;

        Score = score;
    }
}
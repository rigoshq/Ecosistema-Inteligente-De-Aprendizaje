namespace EIA.Domain.Entities.LearningExperiences;

public class LearningProgress
{
    public double Percentage { get; private set; }

    public void Update(double percentage)
    {
        Percentage = percentage;
    }
}
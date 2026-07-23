namespace EIA.Core.Intelligence;

public class LearningInsight
{
    public string Category { get; }

    public string Description { get; }

    public double Confidence { get; }

    public LearningInsight(
        string category,
        string description,
        double confidence)
    {
        Category = category;

        Description = description;

        Confidence = confidence;
    }
}
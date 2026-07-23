namespace EIA.Core.Cognitive;

public class CognitiveTwin
{
    public Guid ExplorerId { get; }

    public double KnowledgeLevel { get; private set; }

    public double Curiosity { get; private set; }

    public double Persistence { get; private set; }

    public double Autonomy { get; private set; }

    public double Confidence { get; private set; }

    public DateTime LastUpdate { get; private set; }

    public CognitiveTwin(
        Guid explorerId)
    {
        ExplorerId = explorerId;

        LastUpdate = DateTime.UtcNow;
    }

    public void UpdateKnowledge(
        double value)
    {
        KnowledgeLevel = value;

        LastUpdate = DateTime.UtcNow;
    }

    public void UpdateCuriosity(
        double value)
    {
        Curiosity = value;

        LastUpdate = DateTime.UtcNow;
    }

    public void UpdatePersistence(
        double value)
    {
        Persistence = value;

        LastUpdate = DateTime.UtcNow;
    }

    public void UpdateAutonomy(
        double value)
    {
        Autonomy = value;

        LastUpdate = DateTime.UtcNow;
    }

    public void UpdateConfidence(
        double value)
    {
        Confidence = value;

        LastUpdate = DateTime.UtcNow;
    }
}
namespace EIA.Domain.Learning.Competencies;

public class LearningCompetencyLevel
{
    public LearningCompetency Competency { get; }

    public double Value { get; private set; }

    public LearningCompetencyLevel(
        LearningCompetency competency,
        double value)
    {
        Competency = competency;

        Value = value;
    }

    public void Update(double value)
    {
        Value = value;
    }
}
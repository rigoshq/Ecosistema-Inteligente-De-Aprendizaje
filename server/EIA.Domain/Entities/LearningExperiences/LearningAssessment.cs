namespace EIA.Domain.Entities.LearningExperiences;

public class LearningAssessment
{
    public bool Approved { get; private set; }

    public double Grade { get; private set; }

    public LearningAssessment(
        bool approved,
        double grade)
    {
        Approved = approved;

        Grade = grade;
    }
}
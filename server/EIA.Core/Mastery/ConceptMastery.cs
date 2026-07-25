namespace EIA.Core.Mastery;

public class ConceptMastery
{
    public Guid ConceptId { get; }

    public string ConceptName { get; }

    public double Understanding { get; private set; }

    public double Application { get; private set; }

    public double Transfer { get; private set; }

    public double Retention { get; private set; }

    public double Overall =>
        (Understanding +
         Application +
         Transfer +
         Retention) / 4.0;

    public ConceptMastery(
        Guid conceptId,
        string conceptName)
    {
        ConceptId = conceptId;

        ConceptName = conceptName;
    }

    public void UpdateUnderstanding(double value)
        => Understanding = value;

    public void UpdateApplication(double value)
        => Application = value;

    public void UpdateTransfer(double value)
        => Transfer = value;

    public void UpdateRetention(double value)
        => Retention = value;
}
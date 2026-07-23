namespace EIA.Domain.Entities.Laboratories;

public class LaboratoryMeasurement
{
    public Guid Id { get; }

    public string Variable { get; }

    public double Value { get; }

    public string Unit { get; }

    public DateTime Timestamp { get; }

    public LaboratoryMeasurement(
        string variable,
        double value,
        string unit)
    {
        Id = Guid.NewGuid();

        Variable = variable;

        Value = value;

        Unit = unit;

        Timestamp = DateTime.UtcNow;
    }
}
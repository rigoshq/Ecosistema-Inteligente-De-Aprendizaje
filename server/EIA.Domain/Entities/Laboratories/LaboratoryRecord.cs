namespace EIA.Domain.Entities.Laboratories;

public class LaboratoryRecord
{
    public Guid Id { get; }

    public Dictionary<string, double> Values { get; }

    public DateTime Timestamp { get; }

    public LaboratoryRecord()
    {
        Id = Guid.NewGuid();

        Values = new();

        Timestamp = DateTime.UtcNow;
    }

    public void AddValue(
        string variable,
        double value)
    {
        Values[variable] = value;
    }

    public bool ContainsVariable(
        string variable)
    {
        return Values.ContainsKey(variable);
    }

    public double? GetValue(
        string variable)
    {
        if (!Values.TryGetValue(variable, out var value))
            return null;

        return value;
    }
}
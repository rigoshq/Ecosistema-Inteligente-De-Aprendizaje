namespace EIA.Core.UseCases.Laboratory;

public class LaboratoryDataRow
{
    public double Time { get; set; }

    public double Distance { get; set; }

    public double Velocity { get; set; }

    public string Observation { get; set; } = string.Empty;
}
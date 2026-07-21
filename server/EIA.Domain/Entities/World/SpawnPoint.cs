namespace EIA.Domain.Entities.World;

public class SpawnPoint
{
    public Guid Id { get; }

    public string Name { get; }

    public double X { get; }

    public double Y { get; }

    public double Z { get; }

    public SpawnPoint(
        string name,
        double x,
        double y,
        double z)
    {
        Id = Guid.NewGuid();

        Name = name;

        X = x;

        Y = y;

        Z = z;
    }
}
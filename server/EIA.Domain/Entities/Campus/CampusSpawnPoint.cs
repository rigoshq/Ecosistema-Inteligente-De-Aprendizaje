namespace EIA.Domain.Entities.Campus;

public class CampusSpawnPoint
{
    public float PositionX { get; private set; }

    public float PositionY { get; private set; }

    public float PositionZ { get; private set; }

    public float RotationY { get; private set; }

    public CampusSpawnPoint(
        float x,
        float y,
        float z,
        float rotationY)
    {
        PositionX = x;

        PositionY = y;

        PositionZ = z;

        RotationY = rotationY;
    }
}
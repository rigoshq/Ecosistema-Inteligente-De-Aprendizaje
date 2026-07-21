namespace EIA.Domain.Entities.NPC;

public class NpcLocation
{
    public string Building { get; private set; }

    public string Floor { get; private set; }

    public string Room { get; private set; }

    public float PositionX { get; private set; }

    public float PositionY { get; private set; }

    public float PositionZ { get; private set; }

    public float RotationY { get; private set; }

    private NpcLocation()
    {
        Building = string.Empty;
        Floor = string.Empty;
        Room = string.Empty;
    }

    public NpcLocation(
        string building,
        string floor,
        string room,
        float x,
        float y,
        float z,
        float rotationY)
        : this()
    {
        Building = building;
        Floor = floor;
        Room = room;

        PositionX = x;
        PositionY = y;
        PositionZ = z;

        RotationY = rotationY;
    }

    public void MoveTo(
        float x,
        float y,
        float z)
    {
        PositionX = x;
        PositionY = y;
        PositionZ = z;
    }

    public void Rotate(float rotation)
    {
        RotationY = rotation;
    }
}
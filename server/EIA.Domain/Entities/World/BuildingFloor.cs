namespace EIA.Domain.Entities.World;

public class BuildingFloor
{
    public Guid Id { get; }

    public int Number { get; }

    public List<BuildingRoom> Rooms { get; }

    public BuildingFloor(int number)
    {
        Id = Guid.NewGuid();

        Number = number;

        Rooms = new();
    }

    public void AddRoom(BuildingRoom room)
    {
        Rooms.Add(room);
    }
}
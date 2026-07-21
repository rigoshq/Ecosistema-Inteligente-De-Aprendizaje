using EIA.Domain.Entities.Buildings.Enums;

namespace EIA.Domain.Entities.Buildings;

public class Building
{
    public Guid Id { get; private set; }

    public string Name { get; private set; }

    public string Description { get; private set; }

    public BuildingType Type { get; private set; }

    public bool Active { get; private set; }

    public BuildingTheme Theme { get; private set; }

    public BuildingEntrance Entrance { get; private set; }

    public BuildingNavigation Navigation { get; private set; }

    public BuildingPortal Portal { get; private set; }

    public List<BuildingFloor> Floors { get; }

    public List<BuildingRoom> Rooms { get; }

    private Building()
    {
        Id = Guid.NewGuid();

        Name = string.Empty;

        Description = string.Empty;

        Theme = new BuildingTheme(
            "",
            "",
            "",
            "");

        Entrance = new BuildingEntrance("Entrada Principal");

        Navigation = new BuildingNavigation();

        Portal = new BuildingPortal("");

        Floors = new();

        Rooms = new();

        Active = true;
    }

    public Building(
        string name,
        string description,
        BuildingType type)
        : this()
    {
        Name = name;

        Description = description;

        Type = type;
    }

    public void AddFloor(BuildingFloor floor)
    {
        Floors.Add(floor);
    }

    public void AddRoom(BuildingRoom room)
    {
        Rooms.Add(room);
    }

    public void Activate()
    {
        Active = true;
    }

    public void Deactivate()
    {
        Active = false;
    }
}
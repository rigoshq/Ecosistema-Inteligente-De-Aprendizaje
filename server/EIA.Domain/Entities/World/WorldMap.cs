using System.Collections.ObjectModel;

namespace EIA.Domain.Entities.World;

public class WorldMap
{
    private readonly List<KnowledgeBuilding> _buildings;

    private readonly List<WorldConnection> _connections;

    public Guid Id { get; }

    public string Name { get; }

    public Guid CentralBuildingId { get; private set; }

    public IReadOnlyCollection<KnowledgeBuilding> Buildings
        => new ReadOnlyCollection<KnowledgeBuilding>(_buildings);

    public IReadOnlyCollection<WorldConnection> Connections
        => new ReadOnlyCollection<WorldConnection>(_connections);

    public WorldMap(string name)
    {
        Id = Guid.NewGuid();

        Name = name;

        _buildings = new();

        _connections = new();
    }

    public void SetCentralBuilding(Guid buildingId)
    {
        CentralBuildingId = buildingId;
    }

    public void AddBuilding(KnowledgeBuilding building)
    {
        if (_buildings.Any(x => x.Id == building.Id))
            return;

        _buildings.Add(building);
    }

    public void AddConnection(WorldConnection connection)
    {
        if (_connections.Any(x => x.Id == connection.Id))
            return;

        _connections.Add(connection);
    }

    public KnowledgeBuilding? GetBuilding(Guid id)
    {
        return _buildings.FirstOrDefault(x => x.Id == id);
    }

    public IReadOnlyCollection<WorldConnection> GetConnections(Guid buildingId)
    {
        return _connections
            .Where(x =>
                x.OriginBuildingId == buildingId ||
                x.DestinationBuildingId == buildingId)
            .ToList()
            .AsReadOnly();
    }

    public bool AreConnected(Guid origin, Guid destination)
    {
        return _connections.Any(x =>
            x.IsUnlocked &&
            (
                (x.OriginBuildingId == origin &&
                 x.DestinationBuildingId == destination)
             ||
                (x.OriginBuildingId == destination &&
                 x.DestinationBuildingId == origin)
            ));
    }
}
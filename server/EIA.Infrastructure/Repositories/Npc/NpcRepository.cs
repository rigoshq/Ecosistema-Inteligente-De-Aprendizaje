using EIA.Core.Interfaces.Repositories;
using DomainNpc = EIA.Domain.Entities.NPC.Npc;

namespace EIA.Infrastructure.Repositories;

public class NpcRepository : INpcRepository
{
    private readonly Dictionary<Guid, DomainNpc> _storage = new();


    public void Add(DomainNpc npc)
    {
        _storage[npc.Id] = npc;
    }


    public IReadOnlyCollection<DomainNpc> GetAll()
    {
        return _storage.Values.ToList();
    }


    public DomainNpc? GetById(Guid id)
    {
        _storage.TryGetValue(id, out var npc);

        return npc;
    }


    public void Update(DomainNpc npc)
    {
        _storage[npc.Id] = npc;
    }


    public void Remove(Guid id)
    {
        _storage.Remove(id);
    }


    public DomainNpc? FindByFullName(string fullName)
    {
        return _storage.Values.FirstOrDefault(n =>
            n.Identity.FullName.Equals(
                fullName,
                StringComparison.OrdinalIgnoreCase));
    }


    public IReadOnlyCollection<DomainNpc> FindBySpecialty(
        string specialty)
    {
        return _storage.Values
            .Where(n =>
                n.Identity.Specialty.Equals(
                    specialty,
                    StringComparison.OrdinalIgnoreCase))
            .ToList();
    }
}
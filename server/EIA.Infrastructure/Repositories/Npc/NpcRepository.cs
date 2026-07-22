using EIA.Core.Interfaces.Repositories;
using EIA.Domain.Entities.NPC;
using EIA.Infrastructure.Repositories.Base;

namespace EIA.Infrastructure.Repositories;

public class NpcRepository
    : RepositoryBase<Npc>, INpcRepository
{
    protected override Guid GetEntityId(Npc entity)
    {
        return entity.Id;
    }

    public Npc? FindByFullName(string fullName)
    {
        return Storage.Values.FirstOrDefault(n =>
            n.Identity.FullName.Equals(
                fullName,
                StringComparison.OrdinalIgnoreCase));
    }

    public IReadOnlyCollection<Npc> FindBySpecialty(
        string specialty)
    {
        return Storage.Values
            .Where(n =>
                n.Identity.Specialty.Equals(
                    specialty,
                    StringComparison.OrdinalIgnoreCase))
            .ToList();
    }
}
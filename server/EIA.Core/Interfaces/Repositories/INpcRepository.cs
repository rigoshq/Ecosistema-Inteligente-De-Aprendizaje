using EIA.Domain.Entities.NPC;

namespace EIA.Core.Interfaces.Repositories;

public interface INpcRepository
    : IRepository<Npc>
{
    Npc? FindByFullName(string fullName);

    IReadOnlyCollection<Npc> FindBySpecialty(string specialty);
}
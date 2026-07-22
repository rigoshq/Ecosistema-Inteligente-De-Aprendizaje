using EIA.Core.Interfaces.Repositories;
using EIA.Domain.Entities.Dialogue;
using EIA.Infrastructure.Repositories.Base;

namespace EIA.Infrastructure.Repositories;

public class DialogueRepository
    : RepositoryBase<Dialogue>, IDialogueRepository
{
    protected override Guid GetEntityId(Dialogue entity)
    {
        return entity.Id;
    }

    public Dialogue? FindByTitle(string title)
    {
        return Storage.Values.FirstOrDefault(d =>
            d.Title.Equals(
                title,
                StringComparison.OrdinalIgnoreCase));
    }
}
using EIA.Domain.Entities.Dialogue;

namespace EIA.Core.Interfaces.Repositories;

public interface IDialogueRepository
    : IRepository<Dialogue>
{
    Dialogue? FindByTitle(string title);
}
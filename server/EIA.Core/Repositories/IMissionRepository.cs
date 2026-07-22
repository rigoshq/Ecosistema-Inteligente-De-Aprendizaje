using EIA.Domain.Entities.Missions;
using EIA.Domain.Entities.Missions.Enums;

namespace EIA.Core.Interfaces.Repositories;

public interface IMissionRepository
    : IRepository<Mission>
{
    Mission? FindByTitle(string title);

    IReadOnlyCollection<Mission> FindByType(
        MissionType type);

    IReadOnlyCollection<Mission> FindByState(
        MissionState state);

    IReadOnlyCollection<Mission> FindByDifficulty(
        MissionDifficulty difficulty);

    IReadOnlyCollection<Mission> FindAvailable(
        int explorerLevel);
}
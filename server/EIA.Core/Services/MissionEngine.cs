using EIA.Domain.Entities.Explorer;
using EIA.Domain.Entities.Missions;

namespace EIA.Core.Services;

public class MissionEngine
{
    public bool AcceptMission(
        Explorer explorer,
        Mission mission)
    {
        if (!mission.CanBeAccepted(explorer.Level))
            return false;

        explorer.AcceptMission(mission);

        mission.Start();

        return true;
    }

    public bool CompleteMission(
        Explorer explorer,
        Mission mission)
    {
        if (!mission.CanBeCompleted())
            return false;

        mission.Complete();

        explorer.CompleteMission(mission.Id);

        explorer.AddExperience(
            mission.ExperienceReward);

        explorer.AddCoins(
            mission.CoinsReward);

        return true;
    }
}
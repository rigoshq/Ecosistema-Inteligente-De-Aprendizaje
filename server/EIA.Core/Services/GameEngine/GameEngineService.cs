using EIA.Domain.Entities.Explorer;
using EIA.Domain.Entities.Missions;

namespace EIA.Core.Services.GameEngine;

public class GameEngineService
{
    public bool CanAcceptMission(
        Explorer explorer,
        Mission mission)
    {
        if (explorer.Level < mission.MinimumLevel)
            return false;

        if (explorer.ActiveMissions.Any(x => x.MissionId == mission.Id))
            return false;

        return true;
    }

    public void AcceptMission(
        Explorer explorer,
        Mission mission)
    {
        if (!CanAcceptMission(explorer, mission))
            return;

        explorer.AcceptMission(mission);
    }

    public void CompleteMission(
        Explorer explorer,
        Mission mission)
    {
        explorer.CompleteMission(mission.Id);

        explorer.AddExperience(mission.ExperienceReward);

        explorer.AddCoins(mission.CoinsReward);
    }
}
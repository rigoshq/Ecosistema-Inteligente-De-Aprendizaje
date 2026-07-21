using EIA.Core.UseCases.ExplorerJourney.Repositories;
using EIA.Domain.Entities.Dialogue;
using EIA.Domain.Entities.LearningExperiences;
using EIA.Domain.Entities.Missions;
using EIA.Domain.Entities.NPC;

namespace EIA.Infrastructure.Repositories.ExplorerJourney;

public class InMemoryScenarioRepository : IScenarioRepository
{
    public Npc GetNpc(string code)
    {
        throw new NotImplementedException();
    }

    public Dialogue GetDialogue(string code)
    {
        throw new NotImplementedException();
    }

    public Mission GetMission(string code)
    {
        throw new NotImplementedException();
    }

    public LearningExperience GetLearningExperience(string code)
    {
        throw new NotImplementedException();
    }
}
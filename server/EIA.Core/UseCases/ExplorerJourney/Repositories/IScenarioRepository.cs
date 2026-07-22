using EIA.Domain.Entities.Dialogue;
using EIA.Domain.Entities.LearningExperiences;
using EIA.Domain.Entities.Missions;
using EIA.Domain.Entities.NPC;
using DialogueEntity = EIA.Domain.Entities.Dialogue.Dialogue;

namespace EIA.Core.UseCases.ExplorerJourney.Repositories;

public interface IScenarioRepository
{
    Npc GetNpc(string code);

    DialogueEntity GetDialogue(string code);

    Mission GetMission(string code);

    LearningExperience GetLearningExperience(string code);
}
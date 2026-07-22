using DialogueEntity = EIA.Domain.Entities.Dialogue.Dialogue;
using EIA.Domain.Entities.LearningExperiences;
using EIA.Domain.Entities.Missions;
using EIA.Domain.Entities.NPC;

namespace EIA.Core.UseCases.ExplorerJourney.Scenarios;

public class NewtonCampusScenario
{
    private readonly ExplorerJourneyEngine _engine;

    public NewtonCampusScenario(
        ExplorerJourneyEngine engine)
    {
        _engine = engine;
    }

    public ExplorerJourneyResult Execute(
        ExplorerJourneyContext context,
        Npc professor,
        DialogueEntity dialogue,
        Mission mission,
        LearningExperience learningExperience)
    {
        _engine.StartJourney(context);

        _engine.MeetNpc(context, professor);

        _engine.StartDialogue(context, dialogue);

        _engine.AcceptMission(context, mission);

        _engine.StartLearningExperience(
            context,
            learningExperience);

        _engine.GrantReward(
            context,
            experience: 50,
            coins: 25);

        return _engine.CompleteJourney(context);
    }
}
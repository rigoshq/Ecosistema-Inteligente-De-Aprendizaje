using EIA.Core.UseCases.ExplorerJourney.Repositories;

namespace EIA.Core.UseCases.ExplorerJourney;

public class ScenarioRunner
{
    private readonly ExplorerJourneyEngine _engine;

    private readonly IScenarioRepository _repository;

    public ScenarioRunner(
        ExplorerJourneyEngine engine,
        IScenarioRepository repository)
    {
        _engine = engine;

        _repository = repository;
    }

    public ExplorerJourneyResult Run(
        ExplorerJourneyContext context,
        ScenarioDefinition definition)
    {
        var npc =
            _repository.GetNpc(
                definition.NpcCode);

        var dialogue =
            _repository.GetDialogue(
                definition.DialogueCode);

        var mission =
            _repository.GetMission(
                definition.MissionCode);

        var learningExperience =
            _repository.GetLearningExperience(
                definition.LearningExperienceCode);

        _engine.StartJourney(context);

        _engine.MeetNpc(context, npc);

        _engine.StartDialogue(context, dialogue);

        _engine.AcceptMission(context, mission);

        _engine.StartLearningExperience(
            context,
            learningExperience);

        _engine.GrantReward(
            context,
            definition.ExperienceReward,
            definition.CoinsReward);

        return _engine.CompleteJourney(context);
    }
}
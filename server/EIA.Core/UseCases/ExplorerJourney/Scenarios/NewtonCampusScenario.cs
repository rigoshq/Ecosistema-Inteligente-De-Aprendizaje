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
    //----------------------------------------------------------
    // Inicia el recorrido
    //----------------------------------------------------------

    _engine.StartJourney(context);

    //----------------------------------------------------------
    // Verifica que el profesor esté activo
    //----------------------------------------------------------

    if (!professor.Active)
    {
        return ExplorerJourneyResult.Fail(
            "El profesor no está disponible.");
    }

    //----------------------------------------------------------
    // Encuentro con el NPC
    //----------------------------------------------------------

    _engine.MeetNpc(
        context,
        professor);

    //----------------------------------------------------------
    // Inicia el diálogo
    //----------------------------------------------------------

    _engine.StartDialogue(
        context,
        dialogue);

    //----------------------------------------------------------
    // Acepta la misión
    //----------------------------------------------------------

    if (!mission.CanBeAccepted(
        context.Explorer.Level))
    {
        return ExplorerJourneyResult.Fail(
            "No cumples los requisitos para esta misión.");
    }

    _engine.AcceptMission(
        context,
        mission);

    //----------------------------------------------------------
    // Inicia la experiencia
    //----------------------------------------------------------

    _engine.StartLearningExperience(
        context,
        learningExperience);

    //----------------------------------------------------------
    // Recompensa
    //----------------------------------------------------------

    _engine.GrantReward(
        context,
        mission.ExperienceReward,
        mission.CoinsReward);

    //----------------------------------------------------------
    // Finaliza
    //----------------------------------------------------------

    return _engine.CompleteJourney(context);
}
}
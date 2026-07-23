using EIA.Core.UseCases.Adventure;
using EIA.Core.UseCases.Laboratory;
using EIA.Domain.Entities.LearningExperiences;
using EIA.Domain.Entities.Missions;
using EIA.Domain.Entities.NPC;

using DialogueEntity = EIA.Domain.Entities.Dialogue.Dialogue;

namespace EIA.Core.UseCases.ExplorerJourney;

public class FirstAdventureUseCase
{
    private readonly ExplorerJourneyEngine _journeyEngine;

    private readonly AdventureOrchestrator _orchestrator;

    private readonly LaboratoryEngine _laboratoryEngine;

    private readonly LaboratoryEvaluationService _evaluationService;

    private readonly ExecuteLaboratoryUseCase _executeLaboratoryUseCase;

    public FirstAdventureUseCase()
    {
        _journeyEngine = new();

        _orchestrator = new();

        _laboratoryEngine = new();

        _evaluationService = new();

        _executeLaboratoryUseCase = new();
    }

    public ExplorerJourneyResult Execute(
        ExplorerJourneyContext journey,
        AdventureContext adventure,
        Npc professor,
        DialogueEntity dialogue,
        Mission mission,
        LearningExperience learningExperience,
        Domain.Entities.Laboratories.Laboratory laboratory)
    {
        //----------------------------------------------------------
        // Inicia la aventura
        //----------------------------------------------------------

        _orchestrator.StartAdventure(
            adventure,
            journey);

        //----------------------------------------------------------
        // Encuentro con el profesor
        //----------------------------------------------------------

        _journeyEngine.MeetNpc(
            journey,
            professor);

        //----------------------------------------------------------
        // Diálogo inicial
        //----------------------------------------------------------

        _journeyEngine.StartDialogue(
            journey,
            dialogue);

        //----------------------------------------------------------
        // Acepta misión
        //----------------------------------------------------------

        _journeyEngine.AcceptMission(
            journey,
            mission);

        //----------------------------------------------------------
        // Inicia experiencia de aprendizaje
        //----------------------------------------------------------

        _journeyEngine.StartLearningExperience(
            journey,
            learningExperience);

        //----------------------------------------------------------
        // Ejecuta el laboratorio
        //----------------------------------------------------------

        var evaluation =
            _executeLaboratoryUseCase.Execute(
                laboratory);

        //----------------------------------------------------------
        // Entrega recompensa
        //----------------------------------------------------------

        _journeyEngine.GrantReward(
            journey,
            mission.ExperienceReward,
            mission.CoinsReward);

        //----------------------------------------------------------
        // Finaliza aventura
        //----------------------------------------------------------

        return _journeyEngine.CompleteJourney(
            journey);
    }
}
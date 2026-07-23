using EIA.Core.UseCases.Dialogue;
using EIA.Core.UseCases.ExplorerJourney;
using EIA.Domain.Entities.Missions;

using DialogueEntity = EIA.Domain.Entities.Dialogue.Dialogue;

namespace EIA.Core.UseCases.Adventure;

public class AdventureOrchestrator
{
    private readonly DialogueMissionResolver _resolver;

    private readonly AdventureEngine _adventureEngine;

    private readonly ExplorerJourneyEngine _journeyEngine;

    public AdventureOrchestrator()
    {
        _resolver = new();

        _adventureEngine = new();

        _journeyEngine = new();
    }

    public AdventureResult StartAdventure(
        AdventureContext adventure,
        ExplorerJourneyContext journey)
    {
        _adventureEngine.StartAdventure(adventure);

        _journeyEngine.StartJourney(journey);

        return AdventureResult.Ok(
            "Adventure initialized.");
    }

    public Mission? ResolveMission(
        DialogueEntity dialogue,
        IReadOnlyCollection<Mission> missions)
    {
        return _resolver.Resolve(
            dialogue,
            missions);
    }
}
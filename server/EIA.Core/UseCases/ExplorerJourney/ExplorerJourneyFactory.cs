using EIA.Core.UseCases.ExplorerJourney.Scenarios;

namespace EIA.Core.UseCases.ExplorerJourney;

public class ExplorerJourneyFactory
{
    private readonly ExplorerJourneyEngine _engine;

    public ExplorerJourneyFactory(
        ExplorerJourneyEngine engine)
    {
        _engine = engine;
    }

    public NewtonCampusScenario CreateNewtonCampus()
    {
        return new NewtonCampusScenario(_engine);
    }
}
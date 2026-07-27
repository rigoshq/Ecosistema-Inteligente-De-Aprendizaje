using EIA.Core.Engine;
using EIA.Core.ExplorerSession;
using EIA.Core.Intelligence;
using EIA.Domain.Entities.Explorer;

namespace EIA.Core.UseCases;

public class StartLearningJourneyUseCase
{
    private readonly ExplorerEngine _engine;

    private readonly LearningOrchestrator _orchestrator;

    public StartLearningJourneyUseCase(
        ExplorerEngine engine,
        LearningOrchestrator orchestrator)
    {
        _engine = engine;
        _orchestrator = orchestrator;
    }

    public LearningScene Execute(
        Explorer explorer)
    {
        //-----------------------------------------------------
        // Crear sesión del Explorador
        //-----------------------------------------------------

        var session = _engine.Start(explorer);

        //-----------------------------------------------------
        // Construir contexto
        //-----------------------------------------------------

        var context =
            new LearningContext(session);

        //-----------------------------------------------------
        // Dejar que el Ecosistema tome decisiones
        //-----------------------------------------------------

        return _orchestrator.Execute(context);
    }
}
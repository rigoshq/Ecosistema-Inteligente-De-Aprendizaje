using EIA.Core.Intelligence;
using EIA.Core.UseCases;

namespace EIA.Core.Engine;

public class LearningOrchestrator
{
    private readonly LearningDecisionEngine _decisionEngine;

    private readonly LoadLearningSceneUseCase _sceneLoader;

    public LearningOrchestrator(
        LearningDecisionEngine decisionEngine,
        LoadLearningSceneUseCase sceneLoader)
    {
        _decisionEngine = decisionEngine;
        _sceneLoader = sceneLoader;
    }

    public LearningScene Execute(
        LearningContext context)
    {
        // El motor decide qué hacer.
        var decision = _decisionEngine.Decide(context);

        // Más adelante aquí ejecutaremos distintas acciones
        // según la decisión obtenida.

        return _sceneLoader.Load(context.Session);
    }
}
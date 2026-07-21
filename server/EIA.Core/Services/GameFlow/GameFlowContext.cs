using EIA.Domain.Entities;
using EIA.Domain.Entities.Explorer;

namespace EIA.Core.Services.GameFlow;

public class GameFlowContext
{
    public Explorer Explorer { get; }

    public LearningWorld World { get; }

    public List<GameStage> Stages { get; }

    public GameStage? CurrentStage { get; private set; }

    public GameStep? CurrentStep { get; private set; }

    public GameFlowContext(
        Explorer explorer,
        LearningWorld world)
    {
        Explorer = explorer;

        World = world;

        Stages = new();
    }

    public void AddStage(GameStage stage)
    {
        Stages.Add(stage);
    }

    public void StartStage(GameStage stage)
    {
        CurrentStage = stage;

        CurrentStep = stage.Steps.FirstOrDefault();
    }

    public void MoveToStep(GameStep step)
    {
        CurrentStep = step;
    }
}
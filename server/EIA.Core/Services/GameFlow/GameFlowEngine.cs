using EIA.Core.Services.GameFlow.Enums;

namespace EIA.Core.Services.GameFlow;

public class GameFlowEngine
{
    public GameFlowState State { get; private set; }

    public GameFlowEngine()
    {
        State = GameFlowState.Created;
    }

    public GameFlowResult Start(GameFlowContext context)
    {
        State = GameFlowState.Running;

        return GameFlowResult.Ok(
            "Game Flow started.");
    }

    public GameFlowResult Pause()
    {
        State = GameFlowState.Paused;

        return GameFlowResult.Ok(
            "Game Flow paused.");
    }

    public GameFlowResult Finish()
    {
        State = GameFlowState.Finished;

        return GameFlowResult.Ok(
            "Game Flow finished.");
    }

    public GameFlowResult AddStage(
        GameFlowContext context,
        GameStage stage)
    {
        context.AddStage(stage);

        return GameFlowResult.Ok(
            $"Stage '{stage.Name}' added.");
    }

    public GameFlowResult StartStage(
        GameFlowContext context,
        GameStage stage)
    {
        context.StartStage(stage);

        return GameFlowResult.Ok(
            $"Stage '{stage.Name}' started.");
    }

    public GameFlowResult MoveToStep(
        GameFlowContext context,
        GameStep step)
    {
        context.MoveToStep(step);

        return GameFlowResult.Ok(
            $"Current step: '{step.Name}'.");
    }
}
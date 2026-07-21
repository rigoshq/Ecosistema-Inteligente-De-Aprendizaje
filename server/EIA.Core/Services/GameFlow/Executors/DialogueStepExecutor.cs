using EIA.Core.Services.GameFlow.Enums;

namespace EIA.Core.Services.GameFlow.Executors;

public class DialogueStepExecutor : IGameStepExecutor
{
    public bool CanExecute(GameStep step)
    {
        return step.Type == GameStepType.Dialogue;
    }

    public ScenarioResult Execute(GameStep step)
    {
        step.Start();

        return ScenarioResult.Ok(
            "Dialogue started.");
    }
}
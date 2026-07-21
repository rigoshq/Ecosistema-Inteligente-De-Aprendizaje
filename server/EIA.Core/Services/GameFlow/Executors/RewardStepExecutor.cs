using EIA.Core.Services.GameFlow.Enums;

namespace EIA.Core.Services.GameFlow.Executors;

public class RewardStepExecutor : IGameStepExecutor
{
    public bool CanExecute(GameStep step)
    {
        return step.Type == GameStepType.Reward;
    }

    public ScenarioResult Execute(GameStep step)
    {
        step.Start();

        return ScenarioResult.Ok(
            "Reward delivered.");
    }
}
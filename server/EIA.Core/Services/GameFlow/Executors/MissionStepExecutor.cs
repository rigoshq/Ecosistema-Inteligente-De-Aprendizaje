using EIA.Core.Services.GameFlow.Enums;

namespace EIA.Core.Services.GameFlow.Executors;

public class MissionStepExecutor : IGameStepExecutor
{
    public bool CanExecute(GameStep step)
    {
        return step.Type == GameStepType.Mission;
    }

    public ScenarioResult Execute(GameStep step)
    {
        step.Start();

        return ScenarioResult.Ok(
            "Mission accepted.");
    }
}
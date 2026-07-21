using EIA.Core.Services.GameFlow.Enums;

namespace EIA.Core.Services.GameFlow.Executors;

public class LaboratoryStepExecutor : IGameStepExecutor
{
    public bool CanExecute(GameStep step)
    {
        return step.Type == GameStepType.Laboratory;
    }

    public ScenarioResult Execute(GameStep step)
    {
        step.Start();

        return ScenarioResult.Ok(
            "Entering laboratory.");
    }
}
using EIA.Core.Services.GameFlow.Enums;

namespace EIA.Core.Services.GameFlow.Executors;

public class LearningExperienceStepExecutor : IGameStepExecutor
{
    public bool CanExecute(GameStep step)
    {
        return step.Type == GameStepType.LearningExperience;
    }

    public ScenarioResult Execute(GameStep step)
    {
        step.Start();

        return ScenarioResult.Ok(
            "Learning experience started.");
    }
}
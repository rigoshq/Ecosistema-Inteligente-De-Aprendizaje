namespace EIA.Core.Services.GameFlow.Executors;

public interface IGameStepExecutor
{
    bool CanExecute(GameStep step);

    ScenarioResult Execute(GameStep step);
}
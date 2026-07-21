namespace EIA.Core.Services.GameFlow;

public class ScenarioExecutor
{
    private readonly GameStepExecutorRegistry _registry;

    public ScenarioExecutor(
        GameStepExecutorRegistry registry)
    {
        _registry = registry;
    }

    public ScenarioResult Execute(GameStep step)
    {
        var executor = _registry.Find(step);

        if (executor == null)
        {
            return ScenarioResult.Fail(
                $"No executor registered for '{step.Type}'.");
        }

        return executor.Execute(step);
    }

    public void Finish(GameStep step)
    {
        step.Complete();
    }
}
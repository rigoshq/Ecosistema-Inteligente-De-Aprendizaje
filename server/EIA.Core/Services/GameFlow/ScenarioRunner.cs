namespace EIA.Core.Services.GameFlow;

public class ScenarioRunner
{
    private readonly GameFlowEngine _engine;

    public ScenarioRunner(GameFlowEngine engine)
    {
        _engine = engine;
    }

    public ScenarioResult Execute(
        GameFlowContext context,
        GameStage stage)
    {
        _engine.Start(context);

        _engine.AddStage(context, stage);

        _engine.StartStage(context, stage);

        return ScenarioResult.Ok(
            $"Scenario '{stage.Name}' started.");
    }

    public ScenarioResult Next(
        ScenarioExecution execution)
    {
        execution.CurrentStep.Complete();

        if (execution.HasNextStep())
        {
            execution.NextStep();

            return ScenarioResult.Ok(
                $"Current step: {execution.CurrentStep.Name}");
        }

        return ScenarioResult.Ok(
            "Scenario completed.");
    }
}
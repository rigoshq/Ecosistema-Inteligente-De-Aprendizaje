namespace EIA.Core.Services.GameFlow;

public class ScenarioExecution
{
    public GameStage Stage { get; }

    public int CurrentStepIndex { get; private set; }

    public ScenarioExecution(GameStage stage)
    {
        Stage = stage;

        CurrentStepIndex = 0;
    }

    public GameStep CurrentStep =>
        Stage.Steps[CurrentStepIndex];

    public bool HasNextStep()
    {
        return CurrentStepIndex < Stage.Steps.Count - 1;
    }

    public void NextStep()
    {
        if (HasNextStep())
            CurrentStepIndex++;
    }
}
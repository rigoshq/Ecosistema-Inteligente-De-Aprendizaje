namespace EIA.Core.Services.GameFlow;

public class ScenarioResult
{
    public bool Success { get; }

    public string Message { get; }

    public ScenarioResult(
        bool success,
        string message)
    {
        Success = success;

        Message = message;
    }

    public static ScenarioResult Ok(string message)
    {
        return new ScenarioResult(true, message);
    }

    public static ScenarioResult Fail(string message)
    {
        return new ScenarioResult(false, message);
    }
}
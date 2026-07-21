namespace EIA.Core.Services.GameFlow;

public class GameFlowResult
{
    public bool Success { get; }

    public string Message { get; }

    public GameFlowResult(
        bool success,
        string message)
    {
        Success = success;

        Message = message;
    }

    public static GameFlowResult Ok(string message)
    {
        return new GameFlowResult(true, message);
    }

    public static GameFlowResult Fail(string message)
    {
        return new GameFlowResult(false, message);
    }
}
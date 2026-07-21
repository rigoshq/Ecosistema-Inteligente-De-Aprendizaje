namespace EIA.Core.Services.NarrativeEngine;

public class NarrativeResult
{
    public bool Success { get; }

    public string Message { get; }

    private NarrativeResult(
        bool success,
        string message)
    {
        Success = success;

        Message = message;
    }

    public static NarrativeResult Ok(string message)
        => new(true, message);

    public static NarrativeResult Fail(string message)
        => new(false, message);
}
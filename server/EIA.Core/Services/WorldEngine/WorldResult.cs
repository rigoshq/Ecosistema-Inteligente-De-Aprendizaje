namespace EIA.Core.Services.WorldEngine;

public class WorldResult
{
    public bool Success { get; }

    public string Message { get; }

    private WorldResult(
        bool success,
        string message)
    {
        Success = success;
        Message = message;
    }

    public static WorldResult Ok(string message)
        => new(true, message);

    public static WorldResult Fail(string message)
        => new(false, message);
}
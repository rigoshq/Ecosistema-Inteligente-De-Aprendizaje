namespace EIA.Core.Services.Adventure;

public class AdventureResult
{
    public bool Success { get; }

    public string Message { get; }

    private AdventureResult(
        bool success,
        string message)
    {
        Success = success;

        Message = message;
    }

    public static AdventureResult Ok(string message)
        => new(true, message);

    public static AdventureResult Fail(string message)
        => new(false, message);
}
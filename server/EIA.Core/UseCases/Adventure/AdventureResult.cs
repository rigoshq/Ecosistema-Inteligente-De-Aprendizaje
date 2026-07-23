namespace EIA.Core.UseCases.Adventure;

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

    public static AdventureResult Ok(
        string message)
    {
        return new AdventureResult(
            true,
            message);
    }

    public static AdventureResult Fail(
        string message)
    {
        return new AdventureResult(
            false,
            message);
    }
}
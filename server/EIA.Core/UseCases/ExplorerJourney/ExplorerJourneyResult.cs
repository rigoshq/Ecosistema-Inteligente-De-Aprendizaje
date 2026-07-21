namespace EIA.Core.UseCases.ExplorerJourney;

public class ExplorerJourneyResult
{
    public bool Success { get; }

    public string Message { get; }

    public ExplorerJourneyResult(
        bool success,
        string message)
    {
        Success = success;

        Message = message;
    }

    public static ExplorerJourneyResult Ok(string message)
    {
        return new ExplorerJourneyResult(
            true,
            message);
    }

    public static ExplorerJourneyResult Fail(string message)
    {
        return new ExplorerJourneyResult(
            false,
            message);
    }
}
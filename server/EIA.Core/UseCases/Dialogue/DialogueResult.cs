namespace EIA.Core.UseCases.Dialogue;

public class DialogueResult
{
    public bool Success { get; }

    public string Message { get; }

    private DialogueResult(
        bool success,
        string message)
    {
        Success = success;

        Message = message;
    }

    public static DialogueResult Ok(
        string message)
    {
        return new DialogueResult(
            true,
            message);
    }

    public static DialogueResult Fail(
        string message)
    {
        return new DialogueResult(
            false,
            message);
    }
}
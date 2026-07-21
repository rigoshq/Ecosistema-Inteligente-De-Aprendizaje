namespace EIA.Domain.Entities.Dialogue;

public class DialogueNode
{
    public Guid Id { get; }

    public string Message { get; }

    public List<DialogueOption> Options { get; }

    public DialogueNode(string message)
    {
        Id = Guid.NewGuid();

        Message = message;

        Options = new();
    }

    public void AddOption(DialogueOption option)
    {
        Options.Add(option);
    }
}
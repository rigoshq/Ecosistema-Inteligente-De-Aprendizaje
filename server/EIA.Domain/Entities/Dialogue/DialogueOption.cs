namespace EIA.Domain.Entities.Dialogue;

public class DialogueOption
{
    public Guid Id { get; }

    public string Text { get; }

    public Guid? NextNodeId { get; }

    public DialogueOption(
        string text,
        Guid? nextNodeId)
    {
        Id = Guid.NewGuid();

        Text = text;

        NextNodeId = nextNodeId;
    }
}
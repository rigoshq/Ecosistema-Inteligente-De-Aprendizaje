namespace EIA.Core.Services.NarrativeEngine;

public class DialogueChoice
{
    public Guid Id { get; }

    public string Text { get; }

    public DialogueChoice(string text)
    {
        Id = Guid.NewGuid();

        Text = text;
    }
}
namespace EIA.Core.Services.NarrativeEngine;

public class DialogueSequence
{
    public Guid Id { get; }

    public string Title { get; }

    public List<DialogueLine> Lines { get; }

    public List<DialogueChoice> Choices { get; }

    public DialogueSequence(string title)
    {
        Id = Guid.NewGuid();

        Title = title;

        Lines = new();

        Choices = new();
    }

    public void AddLine(DialogueLine line)
    {
        Lines.Add(line);
    }

    public void AddChoice(DialogueChoice choice)
    {
        Choices.Add(choice);
    }
}
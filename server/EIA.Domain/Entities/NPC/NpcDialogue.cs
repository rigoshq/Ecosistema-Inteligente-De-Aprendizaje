namespace EIA.Domain.Entities.NPC;

public class NpcDialogue
{
    public Guid Id { get; private set; }

    public string Text { get; private set; }

    public bool IsGreeting { get; private set; }

    public bool IsFarewell { get; private set; }

    public bool IsMissionDialogue { get; private set; }

    private NpcDialogue()
    {
        Id = Guid.NewGuid();

        Text = string.Empty;
    }

    public NpcDialogue(
        string text,
        bool greeting = false,
        bool farewell = false,
        bool missionDialogue = false)
        : this()
    {
        Text = text;

        IsGreeting = greeting;

        IsFarewell = farewell;

        IsMissionDialogue = missionDialogue;
    }
}
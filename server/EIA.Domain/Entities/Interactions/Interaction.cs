using EIA.Domain.Entities.Interactions.Enums;

namespace EIA.Domain.Entities.Interactions;

public class Interaction
{
    public Guid Id { get; }

    public string Title { get; }

    public InteractionType Type { get; }

    public InteractionRequirement Requirement { get; }

    public List<InteractionOption> Options { get; }

    public Interaction(
        string title,
        InteractionType type,
        InteractionRequirement requirement)
    {
        Id = Guid.NewGuid();

        Title = title;

        Type = type;

        Requirement = requirement;

        Options = new();
    }

    public void AddOption(InteractionOption option)
    {
        Options.Add(option);
    }
}
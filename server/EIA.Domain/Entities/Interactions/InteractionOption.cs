namespace EIA.Domain.Entities.Interactions;

public class InteractionOption
{
    public Guid Id { get; }

    public string Text { get; }

    public InteractionOption(string text)
    {
        Id = Guid.NewGuid();

        Text = text;
    }
}
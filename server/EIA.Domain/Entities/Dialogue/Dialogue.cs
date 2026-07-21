namespace EIA.Domain.Entities.Dialogue;

public class Dialogue
{
    public Guid Id { get; }

    public string Title { get; }

    public DialogueCondition Condition { get; }

    public DialogueReward? Reward { get; private set; }

    public List<DialogueNode> Nodes { get; }

    public Dialogue(
        string title,
        DialogueCondition condition)
    {
        Id = Guid.NewGuid();

        Title = title;

        Condition = condition;

        Nodes = new();
    }

    public void AddNode(DialogueNode node)
    {
        Nodes.Add(node);
    }

    public void SetReward(DialogueReward reward)
    {
        Reward = reward;
    }
}
using DialogueEntity = EIA.Domain.Entities.Dialogue.Dialogue;
using EIA.Domain.Entities.Dialogue;
using EIA.Domain.Entities.Explorer;
using EIA.Domain.Entities.NPC;

namespace EIA.Core.UseCases.Dialogue;

public class DialogueContext
{
    public Explorer Explorer { get; }

    public Npc Npc { get; }

    public DialogueEntity Dialogue { get; }

    public DialogueState State { get; private set; }

    public DialogueNode? CurrentNode { get; private set; }

    public DialogueContext(
        Explorer explorer,
        Npc npc,
        DialogueEntity dialogue)
    {
        Explorer = explorer;

        Npc = npc;

        Dialogue = dialogue;

        State = DialogueState.Created;
    }

    public void Start()
    {
        State = DialogueState.Started;

        CurrentNode =
            Dialogue.Nodes.FirstOrDefault();
    }

    public void MoveToNode(
        DialogueNode node)
    {
        CurrentNode = node;
    }

    public void Finish()
    {
        State = DialogueState.Finished;
    }

    public bool HasCurrentNode()
    {
        return CurrentNode != null;
    }

    public bool IsFinished()
    {
        return State == DialogueState.Finished;
    }
}
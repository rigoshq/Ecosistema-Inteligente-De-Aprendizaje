using EIA.Domain.Entities.Dialogue;

namespace EIA.Core.UseCases.Dialogue;

public class DialogueEngine
{
    public DialogueResult StartDialogue(
        DialogueContext context)
    {
        context.Start();

        return DialogueResult.Ok(
            "Dialogue started.");
    }

    public DialogueNode? GetCurrentNode(
        DialogueContext context)
    {
        return context.CurrentNode;
    }

    public IReadOnlyCollection<DialogueOption> GetOptions(
        DialogueContext context)
    {
        if (!context.HasCurrentNode())
            return Array.Empty<DialogueOption>();

        return context.CurrentNode!.Options;
    }

    public DialogueResult SelectOption(
        DialogueContext context,
        Guid optionId)
    {
        if (!context.HasCurrentNode())
        {
            return DialogueResult.Fail(
                "Current dialogue node not found.");
        }

        var option =
            context.CurrentNode!
                .Options
                .FirstOrDefault(o => o.Id == optionId);

        if (option == null)
        {
            return DialogueResult.Fail(
                "Dialogue option not found.");
        }

        if (option.NextNodeId == null)
        {
            context.Finish();

            return DialogueResult.Ok(
                "Dialogue finished.");
        }

        var nextNode =
            context.Dialogue.Nodes
                .FirstOrDefault(n => n.Id == option.NextNodeId);

        if (nextNode == null)
        {
            context.Finish();

            return DialogueResult.Fail(
                "Next dialogue node not found.");
        }

        context.MoveToNode(nextNode);

        return DialogueResult.Ok(
            "Dialogue advanced.");
    }

    public bool IsFinished(
        DialogueContext context)
    {
        return context.IsFinished();
    }

    public bool HasOptions(
        DialogueContext context)
    {
        return context.HasCurrentNode()
            && context.CurrentNode!.Options.Any();
    }
}
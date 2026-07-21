using EIA.Core.Services.NarrativeEngine.Enums;

namespace EIA.Core.Services.NarrativeEngine;

public class NarrativeEngine
{
    public NarrativeResult StartDialogue(
        NarrativeContext context,
        DialogueSequence sequence)
    {
        if (sequence.Lines.Count == 0)
        {
            return NarrativeResult.Fail(
                "Dialogue sequence has no lines.");
        }

        return NarrativeResult.Ok(
            $"Dialogue '{sequence.Title}' started.");
    }

    public NarrativeDecision SelectChoice(
        DialogueChoice choice)
    {
        if (string.IsNullOrWhiteSpace(choice.Text))
        {
            return NarrativeDecision.Deny(
                "Invalid dialogue choice.");
        }

        return NarrativeDecision.Allow(
            $"Choice '{choice.Text}' accepted.");
    }

    public NarrativeEvent RegisterEvent(
        string description)
    {
        return new NarrativeEvent(description);
    }

    public DialogueLine CreateDialogueLine(
        string speaker,
        string text,
        DialogueEmotion emotion)
    {
        return new DialogueLine(
            speaker,
            text,
            emotion);
    }

    public DialogueChoice CreateChoice(
        string text)
    {
        return new DialogueChoice(text);
    }
}
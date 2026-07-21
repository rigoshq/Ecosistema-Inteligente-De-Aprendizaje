using EIA.Core.Services.NarrativeEngine.Enums;

namespace EIA.Core.Services.NarrativeEngine;

public class DialogueLine
{
    public Guid Id { get; }

    public string Speaker { get; }

    public string Text { get; }

    public DialogueEmotion Emotion { get; }

    public DialogueLine(
        string speaker,
        string text,
        DialogueEmotion emotion)
    {
        Id = Guid.NewGuid();

        Speaker = speaker;

        Text = text;

        Emotion = emotion;
    }
}
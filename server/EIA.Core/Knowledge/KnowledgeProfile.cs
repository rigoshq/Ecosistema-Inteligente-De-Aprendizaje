namespace EIA.Core.Knowledge;

public class KnowledgeProfile
{
    public KnowledgeNode Node { get; }

    public int EstimatedMinutes { get; set; }

    public int Difficulty { get; set; }

    public List<string> Competencies { get; }

    public List<string> CommonMistakes { get; }

    public List<string> Careers { get; }

    public KnowledgeProfile(
        KnowledgeNode node)
    {
        Node = node;

        Competencies = new();

        CommonMistakes = new();

        Careers = new();
    }
}
namespace EIA.Core.Knowledge;

public class KnowledgeRelation
{
    public KnowledgeNode From { get; }

    public KnowledgeNode To { get; }

    public string Relation { get; }

    public KnowledgeRelation(
        KnowledgeNode from,
        KnowledgeNode to,
        string relation)
    {
        From = from;

        To = to;

        Relation = relation;
    }
}
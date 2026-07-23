namespace EIA.Core.Knowledge;

public class KnowledgeGraph
{
    private readonly List<KnowledgeNode> _nodes;

    private readonly List<KnowledgeRelation> _relations;

    public IReadOnlyCollection<KnowledgeNode> Nodes
        => _nodes.AsReadOnly();

    public IReadOnlyCollection<KnowledgeRelation> Relations
        => _relations.AsReadOnly();

    public KnowledgeGraph()
    {
        _nodes = new();

        _relations = new();
    }

    public KnowledgeNode AddNode(
        string name,
        string description)
    {
        var node =
            new KnowledgeNode(
                name,
                description);

        _nodes.Add(node);

        return node;
    }

    public void Connect(
        KnowledgeNode from,
        KnowledgeNode to,
        string relation)
    {
        _relations.Add(
            new KnowledgeRelation(
                from,
                to,
                relation));
    }
}
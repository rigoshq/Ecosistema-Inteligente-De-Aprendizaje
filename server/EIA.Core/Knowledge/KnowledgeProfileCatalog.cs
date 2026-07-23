namespace EIA.Core.Knowledge;

public class KnowledgeProfileCatalog
{
    private readonly Dictionary<Guid, KnowledgeProfile> _profiles;

    public KnowledgeProfileCatalog()
    {
        _profiles = new();
    }

    public KnowledgeProfile Register(
        KnowledgeNode node)
    {
        var profile =
            new KnowledgeProfile(node);

        _profiles[node.Id] = profile;

        return profile;
    }

    public KnowledgeProfile? Get(
        KnowledgeNode node)
    {
        _profiles.TryGetValue(
            node.Id,
            out var profile);

        return profile;
    }
}
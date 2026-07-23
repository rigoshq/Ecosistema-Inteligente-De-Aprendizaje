namespace EIA.Core.Knowledge;

public class LearningResourceCatalog
{
    private readonly List<LearningResource> _resources;

    public IReadOnlyCollection<LearningResource> Resources
        => _resources.AsReadOnly();

    public LearningResourceCatalog()
    {
        _resources = new();
    }

    public LearningResource Register(
        string name,
        string type,
        string referenceId)
    {
        var resource = new LearningResource(
            name,
            type,
            referenceId);

        _resources.Add(resource);

        return resource;
    }
}
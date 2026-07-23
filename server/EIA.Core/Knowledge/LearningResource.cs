namespace EIA.Core.Knowledge;

public class LearningResource
{
    public Guid Id { get; }

    public string Name { get; }

    public string ResourceType { get; }

    public string ReferenceId { get; }

    public LearningResource(
        string name,
        string resourceType,
        string referenceId)
    {
        Id = Guid.NewGuid();

        Name = name;

        ResourceType = resourceType;

        ReferenceId = referenceId;
    }
}
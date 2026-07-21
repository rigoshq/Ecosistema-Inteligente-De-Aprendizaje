namespace EIA.Core.Services.WorldEngine;

public class WorldRule
{
    public string Name { get; }

    public string Description { get; }

    public WorldRule(
        string name,
        string description)
    {
        Name = name;

        Description = description;
    }
}
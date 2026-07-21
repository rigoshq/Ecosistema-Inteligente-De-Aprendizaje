namespace EIA.Core.Services.AdventureEngine;

public class AdventureRule
{
    public string Name { get; }

    public string Description { get; }

    public AdventureRule(
        string name,
        string description)
    {
        Name = name;

        Description = description;
    }
}
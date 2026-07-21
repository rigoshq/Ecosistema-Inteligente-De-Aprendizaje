using EIA.Core.Services.AdventureEngine.Enums;

namespace EIA.Core.Services.AdventureEngine;

public class AdventureAction
{
    public AdventureActionType Type { get; }

    public string Description { get; }

    public AdventureAction(
        AdventureActionType type,
        string description)
    {
        Type = type;

        Description = description;
    }
}
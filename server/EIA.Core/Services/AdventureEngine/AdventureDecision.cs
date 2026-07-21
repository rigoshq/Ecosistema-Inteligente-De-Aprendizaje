namespace EIA.Core.Services.AdventureEngine;

public class AdventureDecision
{
    public bool Approved { get; }

    public string Reason { get; }

    public AdventureDecision(
        bool approved,
        string reason)
    {
        Approved = approved;

        Reason = reason;
    }

    public static AdventureDecision Allow(string reason)
        => new(true, reason);

    public static AdventureDecision Deny(string reason)
        => new(false, reason);
}
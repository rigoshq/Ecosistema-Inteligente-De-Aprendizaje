namespace EIA.Core.Services.NarrativeEngine;

public class NarrativeDecision
{
    public bool Approved { get; }

    public string Reason { get; }

    public NarrativeDecision(
        bool approved,
        string reason)
    {
        Approved = approved;

        Reason = reason;
    }

    public static NarrativeDecision Allow(string reason)
        => new(true, reason);

    public static NarrativeDecision Deny(string reason)
        => new(false, reason);
}
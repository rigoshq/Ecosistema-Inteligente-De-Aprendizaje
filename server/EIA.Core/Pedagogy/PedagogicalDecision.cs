namespace EIA.Core.Pedagogy;

public class PedagogicalDecision
{
    public TeachingStrategy Strategy { get; }

    public string Reason { get; }

    public PedagogicalDecision(
        TeachingStrategy strategy,
        string reason)
    {
        Strategy = strategy;

        Reason = reason;
    }
}
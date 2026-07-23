using EIA.Core.Pedagogy;

namespace EIA.Core.Meta;

public class MetaDecision
{
    public TeachingStrategy Strategy { get; }

    public string NextConcept { get; }

    public string Recommendation { get; }

    public MetaDecision(
        TeachingStrategy strategy,
        string nextConcept,
        string recommendation)
    {
        Strategy = strategy;

        NextConcept = nextConcept;

        Recommendation = recommendation;
    }
}
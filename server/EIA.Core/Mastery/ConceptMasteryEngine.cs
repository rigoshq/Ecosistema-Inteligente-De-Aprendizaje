namespace EIA.Core.Mastery;

public class ConceptMasteryEngine
{
    private readonly Dictionary<Guid, ConceptMastery> _mastery;

    public ConceptMasteryEngine()
    {
        _mastery = new();
    }

    public void Register(
        ConceptMastery mastery)
    {
        _mastery[mastery.ConceptId] = mastery;
    }

    public ConceptMastery? Get(
        Guid conceptId)
    {
        _mastery.TryGetValue(
            conceptId,
            out var mastery);

        return mastery;
    }

    public IReadOnlyCollection<ConceptMastery> All()
    {
        return _mastery.Values.ToList().AsReadOnly();
    }
}
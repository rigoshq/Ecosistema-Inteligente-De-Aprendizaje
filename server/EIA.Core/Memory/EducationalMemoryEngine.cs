namespace EIA.Core.Memory;

public class EducationalMemoryEngine
{
    private readonly List<LearningMemory> _memories = new();

    public void Remember(
        LearningMemory memory)
    {
        _memories.Add(memory);
    }

    public IReadOnlyCollection<LearningMemory> Recall()
    {
        return _memories
            .OrderByDescending(m => m.Date)
            .ToList()
            .AsReadOnly();
    }

    public IReadOnlyCollection<LearningMemory> RecallConcept(
        string concept)
    {
        return _memories
            .Where(m => m.Concept == concept)
            .OrderByDescending(m => m.Date)
            .ToList()
            .AsReadOnly();
    }
}
namespace EIA.Core.Events;

public class KnowledgeConceptLearnedEvent
    : LearningEvent
{
    public Guid ExplorerId { get; }

    public Guid ConceptId { get; }

    public string ConceptName { get; }

    public KnowledgeConceptLearnedEvent(
        Guid explorerId,
        Guid conceptId,
        string conceptName)
    {
        ExplorerId = explorerId;

        ConceptId = conceptId;

        ConceptName = conceptName;
    }
}
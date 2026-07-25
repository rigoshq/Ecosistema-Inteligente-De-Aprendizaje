namespace EIA.Core.Events;

public class LaboratoryCompletedEvent
    : LearningEvent
{
    public Guid ExplorerId { get; }

    public Guid LaboratoryId { get; }

    public LaboratoryCompletedEvent(
        Guid explorerId,
        Guid laboratoryId)
    {
        ExplorerId = explorerId;

        LaboratoryId = laboratoryId;
    }
}
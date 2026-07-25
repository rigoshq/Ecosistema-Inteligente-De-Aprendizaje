namespace EIA.Core.Events;

public interface IEventHandler<in TEvent>
    where TEvent : LearningEvent
{
    Task HandleAsync(
        TEvent learningEvent);
}
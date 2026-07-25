namespace EIA.Core.Events;

public class EventBus
{
    private readonly Dictionary<Type, List<object>> _handlers;

    public EventBus()
    {
        _handlers = new();
    }

    public void Subscribe<TEvent>(
        IEventHandler<TEvent> handler)
        where TEvent : LearningEvent
    {
        var type = typeof(TEvent);

        if (!_handlers.ContainsKey(type))
        {
            _handlers[type] = new();
        }

        _handlers[type].Add(handler);
    }

    public async Task PublishAsync<TEvent>(
        TEvent learningEvent)
        where TEvent : LearningEvent
    {
        var type = typeof(TEvent);

        if (!_handlers.ContainsKey(type))
        {
            return;
        }

        foreach (var handler in _handlers[type]
                     .Cast<IEventHandler<TEvent>>())
        {
            await handler.HandleAsync(learningEvent);
        }
    }
}
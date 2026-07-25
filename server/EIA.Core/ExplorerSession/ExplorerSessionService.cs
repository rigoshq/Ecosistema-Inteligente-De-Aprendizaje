using EIA.Core.Intelligence;
using EIA.Domain.Entities.Explorer;
using EIA.Domain.Entities;
namespace EIA.Core.ExplorerSession;

public class ExplorerSessionService
{
    private readonly Dictionary<Guid, ExplorerSession> _sessions;

    private readonly LearningWorld _world;

    public ExplorerSessionService(
        LearningWorld world)
    {
        _world = world;

        _sessions = new();
    }

    public ExplorerSession Create(
        Explorer explorer)
    {
        var record =
            new ExplorerAcademicRecord();

        var session =
            new ExplorerSession(
                explorer,
                _world,
                record);

        _sessions.Add(
            session.SessionId,
            session);

        return session;
    }

    public ExplorerSession? Get(
        Guid sessionId)
    {
        _sessions.TryGetValue(
            sessionId,
            out var session);

        return session;
    }

    public IReadOnlyCollection<ExplorerSession> GetActiveSessions()
    {
        return _sessions.Values.ToList().AsReadOnly();
    }

    public void Close(
        Guid sessionId)
    {
        if (_sessions.TryGetValue(sessionId, out var session))
        {
            session.Close();

            _sessions.Remove(sessionId);
        }
    }
    
}
using EIA.Domain.Entities.Missions;
using ExplorerSessionModel = EIA.Core.ExplorerSession.ExplorerSession;

namespace EIA.Core.Intelligence;

public class LearningContext
{
    //---------------------------------------------------------
    // Sesión activa del explorador
    //---------------------------------------------------------

    public ExplorerSessionModel Session { get; }

    //---------------------------------------------------------
    // Misión actual
    //---------------------------------------------------------

    public Mission? CurrentMission { get; }

    //---------------------------------------------------------
    // Ubicación actual
    //---------------------------------------------------------

    public string CurrentLocation { get; }

    //---------------------------------------------------------
    // Fecha de creación del contexto
    //---------------------------------------------------------

    public DateTime CreatedAt { get; }

    //---------------------------------------------------------

    public LearningContext(
        ExplorerSessionModel session)
    {
        Session = session;

        CurrentMission = session.CurrentMission;

        CurrentLocation = session.CurrentLocation;

        CreatedAt = DateTime.UtcNow;
    }

    //---------------------------------------------------------

    public bool HasMission()
    {
        return CurrentMission != null;
    }

    //---------------------------------------------------------

    public bool IsInside(string location)
    {
        return CurrentLocation == location;
    }
}
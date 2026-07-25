using EIA.Core.ExplorerSession;
using EIA.Core.Intelligence;
using EIA.Core.Missions;
using EIA.Domain.Entities.Explorer;
using EIA.Domain.Entities.Missions;
using ExplorerSessionModel = EIA.Core.ExplorerSession.ExplorerSession;

namespace EIA.Core.Engine;

public class ExplorerEngine
{
    private readonly ExplorerSessionService _sessionService;

    private readonly MissionService _missionService;

    public ExplorerEngine(
        ExplorerSessionService sessionService,
        MissionService missionService)
    {
        _sessionService = sessionService;
        _missionService = missionService;
    }

    //--------------------------------------------------------
    // Iniciar el Ecosistema
    //--------------------------------------------------------

    public ExplorerSessionModel Start(
        Explorer explorer)
    {
        return _sessionService.Create(explorer);
    }

    //--------------------------------------------------------
    // Obtener sesión
    //--------------------------------------------------------

   public ExplorerSessionModel? GetSession(Guid sessionId)
    {
        return _sessionService.Get(sessionId);
    }

    //--------------------------------------------------------
    // Cambiar ubicación
    //--------------------------------------------------------

    public bool MoveExplorer(
        Guid sessionId,
        string location)
    {
        var session =
            _sessionService.Get(sessionId);

        if (session is null)
            return false;

        session.MoveTo(location);

        return true;
    }

    //--------------------------------------------------------
    // Iniciar misión
    //--------------------------------------------------------

    public bool StartMission(
        Guid sessionId,
        Guid missionId)
    {
        var session =
            _sessionService.Get(sessionId);

        if (session is null)
            return false;

        var ok =
            _missionService.StartMission(
                session.Explorer,
                missionId);

        if (!ok)
            return false;

        var mission =
            _missionService.GetById(missionId);

        if (mission is null)
            return false;

        session.AssignMission(mission);

        return true;
    }

    //--------------------------------------------------------
    // Completar misión
    //--------------------------------------------------------

    public bool CompleteMission(
        Guid sessionId)
    {
        var session =
            _sessionService.Get(sessionId);

        if (session is null)
            return false;

        if (session.CurrentMission is null)
            return false;

        _missionService.CompleteMission(
            session.Explorer,
            session.CurrentMission.Id);

        session.FinishMission();

        return true;
    }

    //--------------------------------------------------------
    // Finalizar sesión
    //--------------------------------------------------------

    public void Finish(
        Guid sessionId)
    {
        _sessionService.Close(sessionId);
    }
}
using EIA.Domain.Entities.Explorer;
using EIA.Core.Intelligence;
using EIA.Domain.Entities;
using EIA.Domain.Entities.Missions;

namespace EIA.Core.ExplorerSession;

public class ExplorerSession
{
    public Guid SessionId { get; }

    public DateTime StartedAt { get; }

    public Explorer Explorer { get; }

    public LearningWorld World { get; }

    public ExplorerAcademicRecord AcademicRecord { get; }

    public Mission? CurrentMission { get; private set; }

    public string CurrentLocation { get; private set; }

    public bool IsActive { get; private set; }

    public ExplorerSession(
        Explorer explorer,
        LearningWorld world,
        ExplorerAcademicRecord academicRecord)
    {
        SessionId = Guid.NewGuid();

        StartedAt = DateTime.UtcNow;

        Explorer = explorer;

        World = world;

        AcademicRecord = academicRecord;

        CurrentLocation = "CentralSquare";

        IsActive = true;
    }

    public void MoveTo(string location)
    {
        CurrentLocation = location;
    }

    public void AssignMission(Mission mission)
    {
        CurrentMission = mission;
    }

    public void FinishMission()
    {
        CurrentMission = null;
    }

    public void Close()
    {
        IsActive = false;
    }
}
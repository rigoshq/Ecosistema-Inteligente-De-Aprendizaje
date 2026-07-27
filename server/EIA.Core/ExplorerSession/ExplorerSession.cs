using EIA.Core.Intelligence;
using EIA.Domain.Entities;
using EIA.Domain.Entities.Explorer;
using EIA.Domain.Entities.Missions;
using EIA.Domain.Entities.World;

namespace EIA.Core.ExplorerSession;

public class ExplorerSession
{
    //---------------------------------------------------------
    // Información de la sesión
    //---------------------------------------------------------

    public Guid SessionId { get; }

    public DateTime StartedAt { get; }

    public bool IsActive { get; private set; }

    //---------------------------------------------------------
    // Explorador
    //---------------------------------------------------------

    public Explorer Explorer { get; }

    public ExplorerAcademicRecord AcademicRecord { get; }

    //---------------------------------------------------------
    // Mundo
    //---------------------------------------------------------

    public LearningWorld World { get; }

    public KnowledgeDistrict? CurrentDistrict { get; private set; }

    public KnowledgeBuilding? CurrentBuilding { get; private set; }

    //---------------------------------------------------------
    // Compatibilidad temporal
    //---------------------------------------------------------

    public string CurrentLocation { get; private set; }

    //---------------------------------------------------------
    // Misión actual
    //---------------------------------------------------------

    public Mission? CurrentMission { get; private set; }

    //---------------------------------------------------------
    // Constructor
    //---------------------------------------------------------

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

    //---------------------------------------------------------
    // Navegación (compatibilidad)
    //---------------------------------------------------------

    public void MoveTo(string location)
    {
        CurrentLocation = location;
    }

    //---------------------------------------------------------
    // Entrar a un Distrito
    //---------------------------------------------------------

    public void EnterDistrict(
        KnowledgeDistrict district)
    {
        CurrentDistrict = district;

        CurrentBuilding = null;

        CurrentLocation = district.Name;
    }

    //---------------------------------------------------------
    // Entrar a un Edificio
    //---------------------------------------------------------

    public void EnterBuilding(
        KnowledgeBuilding building)
    {
        CurrentBuilding = building;

        CurrentLocation = building.Name;
    }

    //---------------------------------------------------------
    // Misiones
    //---------------------------------------------------------

    public void AssignMission(
        Mission mission)
    {
        CurrentMission = mission;
    }

    public void FinishMission()
    {
        CurrentMission = null;
    }

    //---------------------------------------------------------
    // Finalizar sesión
    //---------------------------------------------------------

    public void Close()
    {
        IsActive = false;
    }
}
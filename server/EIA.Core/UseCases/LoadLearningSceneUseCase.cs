using EIA.Domain.Entities.Missions;
using ExplorerSessionModel = EIA.Core.ExplorerSession.ExplorerSession;

namespace EIA.Core.UseCases;

public class LoadLearningSceneUseCase
{
    /// <summary>
    /// Construye la escena que verá el Explorador al ingresar
    /// a un edificio del conocimiento.
    /// </summary>
    public LearningScene Load(
        ExplorerSessionModel session)
    {
        return new LearningScene(
            session.CurrentLocation,
            session.CurrentMission);
    }
}

public class LearningScene
{
    /// <summary>
    /// Ubicación actual del Explorador.
    /// </summary>
    public string Location { get; }

    /// <summary>
    /// Misión activa.
    /// </summary>
    public Mission? ActiveMission { get; }

    /// <summary>
    /// La escena tendrá Tutor IA.
    /// </summary>
    public bool HasTutor => true;

    /// <summary>
    /// Objetos interactivos.
    /// </summary>
    public bool HasInteractiveObjects => true;

    /// <summary>
    /// Laboratorios disponibles.
    /// </summary>
    public bool HasLaboratory => true;

    /// <summary>
    /// Eventos dinámicos.
    /// </summary>
    public bool HasEvents => true;

    public LearningScene(
        string location,
        Mission? activeMission)
    {
        Location = location;
        ActiveMission = activeMission;
    }
}
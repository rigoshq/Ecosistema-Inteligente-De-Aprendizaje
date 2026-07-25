namespace EIA.Core.Intelligence;

public class LearningEvidenceCollector
{
    private readonly List<LearningEvidence> _evidences;

    public LearningEvidenceCollector()
    {
        _evidences = new();
    }

    //---------------------------------------------------------
    // Registro manual de una evidencia
    //---------------------------------------------------------

    public void Collect(
        LearningEvidence evidence)
    {
        _evidences.Add(evidence);
    }

    //---------------------------------------------------------
    // Crear evidencia proveniente de un laboratorio
    //---------------------------------------------------------

    public LearningEvidence CreateLaboratoryEvidence(
        string laboratory,
        string competency,
        double score,
        double timeSpentMinutes,
        int attempts,
        bool neededHelp,
        string observation)
    {
        var evidence =
            new LearningEvidence(
                source: laboratory,
                competency: competency,
                score: score,
                timeSpentMinutes: timeSpentMinutes,
                attempts: attempts,
                neededHelp: neededHelp,
                observation: observation);

        Collect(evidence);

        return evidence;
    }

    //---------------------------------------------------------
    // Crear evidencia proveniente de una misión
    //---------------------------------------------------------

    public LearningEvidence CreateMissionEvidence(
        string mission,
        string competency,
        double score,
        double timeSpentMinutes,
        int attempts,
        bool neededHelp,
        string observation)
    {
        var evidence =
            new LearningEvidence(
                source: mission,
                competency: competency,
                score: score,
                timeSpentMinutes: timeSpentMinutes,
                attempts: attempts,
                neededHelp: neededHelp,
                observation: observation);

        Collect(evidence);

        return evidence;
    }

    //---------------------------------------------------------
    // Crear evidencia proveniente de un diálogo con un NPC
    //---------------------------------------------------------

    public LearningEvidence CreateDialogueEvidence(
        string npc,
        string competency,
        string observation)
    {
        var evidence =
            new LearningEvidence(
                source: npc,
                competency: competency,
                score: 100,
                timeSpentMinutes: 0,
                attempts: 1,
                neededHelp: false,
                observation: observation);

        Collect(evidence);

        return evidence;
    }

    //---------------------------------------------------------
    // Obtener todas las evidencias
    //---------------------------------------------------------

    public IReadOnlyCollection<LearningEvidence> GetAll()
    {
        return _evidences.AsReadOnly();
    }

    //---------------------------------------------------------
    // Buscar por origen
    //---------------------------------------------------------

    public IReadOnlyCollection<LearningEvidence> GetBySource(
        string source)
    {
        return _evidences
            .Where(x => x.Source == source)
            .ToList()
            .AsReadOnly();
    }

    //---------------------------------------------------------
    // Buscar por competencia
    //---------------------------------------------------------

    public IReadOnlyCollection<LearningEvidence> GetByCompetency(
        string competency)
    {
        return _evidences
            .Where(x => x.Competency == competency)
            .ToList()
            .AsReadOnly();
    }

    //---------------------------------------------------------
    // Eliminar todas las evidencias
    //---------------------------------------------------------

    public void Clear()
    {
        _evidences.Clear();
    }
}
namespace EIA.Core.Intelligence;

public class TalentDiscoveryEngine
{
    public IReadOnlyCollection<Talent> Discover(
        ExplorerAcademicRecord record)
    {
        var talents = new List<Talent>();

        //---------------------------------------------------
        // Pensamiento lógico
        //---------------------------------------------------

        if (record.LearningProfile.AverageScore >= 90)
        {
            talents.Add(
                new Talent(
                    "Pensamiento Lógico",
                    0.95,
                    "Presenta una excelente capacidad para resolver problemas."));
        }

        //---------------------------------------------------
        // Autonomía
        //---------------------------------------------------

        if (record.LearningProfile.IndependentSolutions >
            record.LearningProfile.HelpRequests)
        {
            talents.Add(
                new Talent(
                    "Aprendizaje Autónomo",
                    0.90,
                    "Aprende con poca intervención del docente."));
        }

        //---------------------------------------------------
        // Rapidez de aprendizaje
        //---------------------------------------------------

        if (record.LearningProfile.AverageTimeMinutes < 10)
        {
            talents.Add(
                new Talent(
                    "Aprendizaje Rápido",
                    0.88,
                    "Comprende nuevos conceptos en poco tiempo."));
        }

        return talents
            .OrderByDescending(t => t.Score)
            .ToList()
            .AsReadOnly();
    }
}
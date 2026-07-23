namespace EIA.Core.Intelligence;

public class LearningInsightEngine
{
    public IReadOnlyCollection<LearningInsight> Analyze(
        ExplorerLearningProfile profile)
    {
        var insights = new List<LearningInsight>();

        //----------------------------------------------------
        // Rendimiento
        //----------------------------------------------------

        if (profile.AverageScore >= 90)
        {
            insights.Add(
                new LearningInsight(
                    "Academic",
                    "Presenta un rendimiento académico sobresaliente.",
                    0.95));
        }

        //----------------------------------------------------
        // Autonomía
        //----------------------------------------------------

        if (profile.IndependentSolutions >
            profile.HelpRequests)
        {
            insights.Add(
                new LearningInsight(
                    "Autonomy",
                    "Resuelve actividades de manera independiente.",
                    0.90));
        }

        //----------------------------------------------------
        // Tiempo de aprendizaje
        //----------------------------------------------------

        if (profile.AverageTimeMinutes < 10)
        {
            insights.Add(
                new LearningInsight(
                    "LearningSpeed",
                    "Aprende rápidamente los nuevos conceptos.",
                    0.85));
        }

        //----------------------------------------------------
        // Competencias
        //----------------------------------------------------

        foreach (var competency in profile.Competencies)
        {
            if (competency.Value >= 90)
            {
                insights.Add(
                    new LearningInsight(
                        "Competency",
                        $"Fortaleza en {competency.Key}.",
                        0.90));
            }
        }

        return insights;
    }
}
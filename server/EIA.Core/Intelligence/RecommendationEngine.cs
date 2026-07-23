namespace EIA.Core.Intelligence;

public class RecommendationEngine
{
    public IReadOnlyCollection<Recommendation> Generate(
        ExplorerLearningProfile profile,
        IReadOnlyCollection<LearningInsight> insights)
    {
        var recommendations = new List<Recommendation>();

        //--------------------------------------------
        // Tiempo de aprendizaje
        //--------------------------------------------

        if (profile.AverageTimeMinutes > 15)
        {
            recommendations.Add(
                new Recommendation(
                    "Reforzar conceptos",
                    "Se recomienda realizar un laboratorio de refuerzo antes de continuar.",
                    10));
        }

        //--------------------------------------------
        // Ayuda frecuente
        //--------------------------------------------

        if (profile.HelpRequests >
            profile.IndependentSolutions)
        {
            recommendations.Add(
                new Recommendation(
                    "Acompañamiento",
                    "Es recomendable conversar con un NPC tutor antes de iniciar la siguiente misión.",
                    9));
        }

        //--------------------------------------------
        // Alto desempeño
        //--------------------------------------------

        if (profile.AverageScore >= 90)
        {
            recommendations.Add(
                new Recommendation(
                    "Nuevo desafío",
                    "Puede avanzar a actividades de mayor dificultad.",
                    8));
        }

        return recommendations
            .OrderByDescending(r => r.Priority)
            .ToList()
            .AsReadOnly();
    }
}
using EIA.Core.Intelligence;

namespace EIA.Core.Pedagogy;

public class AdaptivePedagogicalEngine
{
    public PedagogicalDecision Decide(
        ExplorerAcademicRecord record)
    {
        var profile = record.LearningProfile;

        //----------------------------------------------------
        // Alta autonomía
        //----------------------------------------------------

        if (profile.IndependentSolutions >
            profile.HelpRequests)
        {
            return new PedagogicalDecision(
                TeachingStrategy.Challenge,
                "El estudiante demuestra autonomía.");
        }

        //----------------------------------------------------
        // Mucha ayuda solicitada
        //----------------------------------------------------

        if (profile.HelpRequests >
            profile.IndependentSolutions)
        {
            return new PedagogicalDecision(
                TeachingStrategy.Guided,
                "Necesita acompañamiento.");
        }

        //----------------------------------------------------
        // Estrategia por defecto
        //----------------------------------------------------

        return new PedagogicalDecision(
            TeachingStrategy.Experimental,
            "Favorecer el aprendizaje mediante experimentación.");
    }
}
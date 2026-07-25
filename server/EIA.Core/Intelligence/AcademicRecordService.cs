namespace EIA.Core.Intelligence;

public class AcademicRecordService
{
    private readonly LearningInsightEngine _insightEngine;

    private readonly RecommendationEngine _recommendationEngine;

    public AcademicRecordService()
    {
        _insightEngine = new();

        _recommendationEngine = new();
    }

    public ExplorerAcademicRecord Update(
        ExplorerAcademicRecord record,
        LearningEvidence evidence)
    {
        //---------------------------------------------------
        // 1. Registrar evidencia
        //---------------------------------------------------

        record.AddEvidence(evidence);

        //---------------------------------------------------
        // 2. Registrar Timeline
        //---------------------------------------------------

        record.AddTimelineEvent(

            new LearningTimelineEvent(

                $"Actividad: {evidence.Source}",

                evidence.Observation,

                evidence.Competency));

        //---------------------------------------------------
        // 3. Calcular Insights
        //---------------------------------------------------

        var insights =
            _insightEngine.Analyze(
                record.LearningProfile);

        record.AddInsights(insights);

        //---------------------------------------------------
        // 4. Calcular recomendaciones
        //---------------------------------------------------

        var recommendations =
            _recommendationEngine.Generate(

                record.LearningProfile,

                insights);

        record.AddRecommendations(recommendations);

        return record;
    }
}
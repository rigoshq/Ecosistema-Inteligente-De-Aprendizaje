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
        //-------------------------------------------
        // Registrar evidencia
        //-------------------------------------------

        record.AddEvidence(evidence);

        //-------------------------------------------
        // Calcular nuevos insights
        //-------------------------------------------

        var insights =
            _insightEngine.Analyze(
                record.LearningProfile);

        record.AddInsights(insights);

        //-------------------------------------------
        // Calcular recomendaciones
        //-------------------------------------------

        var recommendations =
            _recommendationEngine.Generate(
                record.LearningProfile,
                insights);

        record.AddRecommendations(recommendations);

        return record;
    }
}
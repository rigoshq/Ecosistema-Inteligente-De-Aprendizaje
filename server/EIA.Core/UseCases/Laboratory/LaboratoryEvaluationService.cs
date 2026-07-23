namespace EIA.Core.UseCases.Laboratory;

public class LaboratoryEvaluationService
{
    private readonly LaboratoryAnalyzer _analyzer;

    public LaboratoryEvaluationService()
    {
        _analyzer = new LaboratoryAnalyzer();
    }

    public LaboratoryEvaluationResult Evaluate(
        LaboratorySession session)
    {
        var averageVelocity =
            _analyzer.CalculateAverageVelocity(session);

        var averageDistance =
            _analyzer.CalculateAverageDistance(session);

        var averageTime =
            _analyzer.CalculateAverageTime(session);

        var uniform =
            _analyzer.IsUniformMotion(session);

        var score = uniform ? 100 : 60;

        return new LaboratoryEvaluationResult(
            score,
            uniform,
            averageVelocity,
            averageDistance,
            averageTime);
    }
}
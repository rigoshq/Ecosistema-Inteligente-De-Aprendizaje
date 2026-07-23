using EIA.Domain.Entities.Laboratories;

namespace EIA.Core.UseCases.Laboratory;

public class ExecuteLaboratoryUseCase
{
    private readonly LaboratoryEngine _engine;

    private readonly LaboratoryEvaluationService _evaluation;

    public ExecuteLaboratoryUseCase()
    {
        _engine = new LaboratoryEngine();

        _evaluation = new LaboratoryEvaluationService();
    }

    public LaboratoryEvaluationResult Execute(
        Domain.Entities.Laboratories.Laboratory laboratory)
    {
        //----------------------------------------------------------
        // Inicia laboratorio
        //----------------------------------------------------------

        _engine.StartLaboratory(laboratory);

        //----------------------------------------------------------
        // Crea la sesión
        //----------------------------------------------------------

        var session = new LaboratorySession(laboratory);

        //----------------------------------------------------------
        // Aquí posteriormente Unity registrará los datos
        //----------------------------------------------------------

        //----------------------------------------------------------
        // Evalúa el laboratorio
        //----------------------------------------------------------

        var result = _evaluation.Evaluate(session);

        //----------------------------------------------------------
        // Finaliza laboratorio
        //----------------------------------------------------------

        _engine.CompleteLaboratory(laboratory);

        return result;
    }
}